Public Class frmMain

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If apps_loaded = False Then Exit Sub
        'Dim win_Id As Long

        ' Activate the selected application.
        If app_index <> 0 Then AppActivate(Apps.window_name(app_index))

        ' Get a handle to the Calculator application. The window class
        ' and window name were obtained using the Spy++ tool.
        Dim appHandle As IntPtr = FindWindow(Apps.class_name(app_index), Apps.window_name(app_index))

        '' Verify that Application is a running process.
        'If appHandle = IntPtr.Zero Then
        '    MsgBox("Appli8cation is not running.")
        '    Return
        'End If
        'win_Id = GetActiveWindow()
        ' Make Application the foreground application and send it 
        ' a set of calculations.
        'SetForegroundWindow(appHandle)
        'win_Id = SetActiveWindow()
        SetForegroundWindow(appHandle)
        ' Send the keystrokes to the Calculator application.
        'My.Computer.Keyboard.SendKeys(" " & keybuf, True)
        Buildbuff()
        SendKeys.Send(keybuf & Me.txt_out.Text)
        'SendKeys.SendWait(keybuf)
    End Sub




    Private Sub btnApps_Click(sender As Object, e As EventArgs) Handles btnApps.Click
        In_Debug = False
        clear_apps()
        txt_apps.Text = ""
        txt_apps.Text = getApplications()
        Fill_Selector()
        Load_Tabs()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Key Send " & Version
        ChkTop.CheckState = CheckState.Checked
        sendat = False
        cmbapps.Text = "No Apps Loaded"
        apps_loaded = False
        TabCtl.TabPages.Clear()
        default_icon = Me.Icon


    End Sub

    Private Sub ChkTop_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTop.CheckedChanged
        If ChkTop.CheckState = CheckState.Unchecked Then Me.TopMost = False Else Me.TopMost = True
    End Sub

    Private Sub ChkAt_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAt.CheckedChanged
        If ChkAt.CheckState = CheckState.Checked Then sendat = True Else sendat = False
    End Sub
    Private Sub ChkTime_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTime.CheckedChanged
        If ChkTime.CheckState = CheckState.Checked Then sendtime = True Else sendtime = False
    End Sub
    Private Sub ChkDate_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDate.CheckedChanged
        If ChkDate.CheckState = CheckState.Checked Then senddate = True Else senddate = False
    End Sub
    Private Sub Buildbuff()
        keybuf = ""
        If senddate = True Then
            keybuf = Format((Date.Now), "MM" & "-" & "dd" & "-" & "yyyy")
        End If
        If sendat = True Then
            keybuf = keybuf & "@"
        End If
        If sendtime = True Then
            keybuf = keybuf & Format((Date.Now), "hh" & ":" & "mm" & ":" & "ss" & " " & "tt")
        End If
    End Sub
    Private Sub sendit()
        txt_out.Text = keybuf
        copytoclipboard()
    End Sub

    Private Sub cmbapps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbapps.SelectedIndexChanged
        app_index = cmbapps.SelectedIndex
        TabCtl.SelectedIndex = app_index
    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If sendat = True Then
            keybuf = " @"
            txt_out.Text = " @"
        Else
            keybuf = ""
            txt_out.Text = ""
        End If
        keybuf = keybuf & DateTimePicker1.Value.ToString
        sendit()
    End Sub
    Private Sub tabctl_ValueChanged(sender As Object, e As EventArgs)
        app_index = TabCtl.SelectedIndex
        cmbapps.SelectedIndex = app_index
    End Sub
    Private Sub tabctl_MouseClick(sender As Object, e As MouseEventArgs) Handles TabCtl.MouseClick
        app_index = TabCtl.SelectedIndex
        cmbapps.SelectedIndex = app_index
    End Sub
    Private Sub Fill_Selector()
        Dim x As Integer

        Me.cmbapps.Items.Clear()
        For x = 0 To Apps.count
            Me.cmbapps.Items.Add(Apps.window_name(x))
        Next
        Me.cmbapps.Text = Me.cmbapps.Items.Item(0)
    End Sub
    Private Sub Load_Tabs()
        Dim x As Integer
        'Dim newpage As New TabPage()

        '' Visual Basic
        'Dim myTabPage As New TabPage()
        'myTabPage.Text = "TabPage" & (TabControl1.TabPages.Count + 1)
        'TabControl1.TabPages.Add(myTabPage)

        '' Visual Basic
        '' Removes the selected tab:
        'TabControl1.TabPages.Remove(TabControl1.SelectedTab)
        '' Removes all the tabs:
        'TabControl1.TabPages.Clear()

        Me.imglst.Images.Clear()
        Me.TabCtl.TabPages.Clear()
        For x = 0 To Apps.count
            Dim newpage As New TabPage()
            Me.imglst.Images.Add(Apps.icon(x))
            newpage.Text = Apps.class_name(x)
            Me.TabCtl.TabPages.Add(newpage)
            Me.TabCtl.SelectTab(x)
            Me.TabCtl.SelectedTab.ImageIndex = x
        Next
        Me.cmbapps.Text = Me.cmbapps.Items.Item(0)
        apps_loaded = True
    End Sub
    Private Sub copytoclipboard()
        Me.txt_out.SelectAll()
        Clipboard.SetText(keybuf & Me.txt_out.SelectedText)
        Me.txt_out.Select(0, 0)
    End Sub

    'Private Sub chkDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkDate.CheckedChanged
    '    If chkDate.Checked = True Then
    '        clearbuffs()
    '        keybuf = keybuf & Format((Date.Now), "MM" & "-" & "dd" & "-" & "yyyy")
    '        sendit()
    '    End If
    'End Sub

    'Private Sub chkTime_CheckedChanged(sender As Object, e As EventArgs) Handles chkTime.CheckedChanged
    '    If chkTime.Checked = True Then
    '        clearbuffs()
    '        keybuf = keybuf & Format((Date.Now), "hh" & ":" & "mm" & ":" & "ss" & " " & "tt")
    '        sendit()
    '    End If
    'End Sub
End Class
