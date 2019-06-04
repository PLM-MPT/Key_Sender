<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txt_out = New System.Windows.Forms.TextBox()
        Me.txt_apps = New System.Windows.Forms.TextBox()
        Me.btnApps = New System.Windows.Forms.Button()
        Me.ChkTop = New System.Windows.Forms.CheckBox()
        Me.ChkAt = New System.Windows.Forms.CheckBox()
        Me.cmbapps = New System.Windows.Forms.ComboBox()
        Me.TabCtl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.imglst = New System.Windows.Forms.ImageList(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ChkDate = New System.Windows.Forms.CheckBox()
        Me.ChkTime = New System.Windows.Forms.CheckBox()
        Me.TabCtl.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(247, 114)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(88, 22)
        Me.btnSend.TabIndex = 0
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txt_out
        '
        Me.txt_out.Location = New System.Drawing.Point(12, 61)
        Me.txt_out.Name = "txt_out"
        Me.txt_out.Size = New System.Drawing.Size(323, 20)
        Me.txt_out.TabIndex = 1
        '
        'txt_apps
        '
        Me.txt_apps.Location = New System.Drawing.Point(-1, -2)
        Me.txt_apps.Multiline = True
        Me.txt_apps.Name = "txt_apps"
        Me.txt_apps.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_apps.Size = New System.Drawing.Size(40, 25)
        Me.txt_apps.TabIndex = 5
        Me.txt_apps.Visible = False
        '
        'btnApps
        '
        Me.btnApps.Location = New System.Drawing.Point(12, 114)
        Me.btnApps.Name = "btnApps"
        Me.btnApps.Size = New System.Drawing.Size(86, 22)
        Me.btnApps.TabIndex = 6
        Me.btnApps.Text = "Get Apps"
        Me.btnApps.UseVisualStyleBackColor = True
        '
        'ChkTop
        '
        Me.ChkTop.AutoSize = True
        Me.ChkTop.Location = New System.Drawing.Point(214, 12)
        Me.ChkTop.Name = "ChkTop"
        Me.ChkTop.Size = New System.Drawing.Size(59, 17)
        Me.ChkTop.TabIndex = 7
        Me.ChkTop.Text = "OnTop"
        Me.ChkTop.UseVisualStyleBackColor = True
        '
        'ChkAt
        '
        Me.ChkAt.AutoSize = True
        Me.ChkAt.Location = New System.Drawing.Point(71, 38)
        Me.ChkAt.Name = "ChkAt"
        Me.ChkAt.Size = New System.Drawing.Size(37, 17)
        Me.ChkAt.TabIndex = 8
        Me.ChkAt.Text = "@"
        Me.ChkAt.UseVisualStyleBackColor = True
        '
        'cmbapps
        '
        Me.cmbapps.FormattingEnabled = True
        Me.cmbapps.Location = New System.Drawing.Point(12, 87)
        Me.cmbapps.Name = "cmbapps"
        Me.cmbapps.Size = New System.Drawing.Size(323, 21)
        Me.cmbapps.TabIndex = 9
        '
        'TabCtl
        '
        Me.TabCtl.Controls.Add(Me.TabPage1)
        Me.TabCtl.Controls.Add(Me.TabPage2)
        Me.TabCtl.ImageList = Me.imglst
        Me.TabCtl.Location = New System.Drawing.Point(12, 142)
        Me.TabCtl.Multiline = True
        Me.TabCtl.Name = "TabCtl"
        Me.TabCtl.SelectedIndex = 0
        Me.TabCtl.Size = New System.Drawing.Size(323, 190)
        Me.TabCtl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabCtl.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(315, 163)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(315, 163)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'imglst
        '
        Me.imglst.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imglst.ImageSize = New System.Drawing.Size(16, 16)
        Me.imglst.TransparentColor = System.Drawing.Color.Transparent
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(196, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'ChkDate
        '
        Me.ChkDate.AutoSize = True
        Me.ChkDate.Location = New System.Drawing.Point(16, 38)
        Me.ChkDate.Name = "ChkDate"
        Me.ChkDate.Size = New System.Drawing.Size(49, 17)
        Me.ChkDate.TabIndex = 12
        Me.ChkDate.Text = "Date"
        Me.ChkDate.UseVisualStyleBackColor = True
        '
        'ChkTime
        '
        Me.ChkTime.AutoSize = True
        Me.ChkTime.Location = New System.Drawing.Point(114, 38)
        Me.ChkTime.Name = "ChkTime"
        Me.ChkTime.Size = New System.Drawing.Size(49, 17)
        Me.ChkTime.TabIndex = 13
        Me.ChkTime.Text = "Time"
        Me.ChkTime.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 340)
        Me.Controls.Add(Me.ChkTime)
        Me.Controls.Add(Me.ChkDate)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TabCtl)
        Me.Controls.Add(Me.cmbapps)
        Me.Controls.Add(Me.ChkAt)
        Me.Controls.Add(Me.ChkTop)
        Me.Controls.Add(Me.btnApps)
        Me.Controls.Add(Me.txt_apps)
        Me.Controls.Add(Me.txt_out)
        Me.Controls.Add(Me.btnSend)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Key Sender"
        Me.TopMost = True
        Me.TabCtl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txt_out As System.Windows.Forms.TextBox
    Friend WithEvents txt_apps As System.Windows.Forms.TextBox
    Friend WithEvents btnApps As System.Windows.Forms.Button
    Friend WithEvents ChkTop As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAt As System.Windows.Forms.CheckBox
    Friend WithEvents cmbapps As System.Windows.Forms.ComboBox
    Friend WithEvents TabCtl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents imglst As System.Windows.Forms.ImageList
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChkDate As CheckBox
    Friend WithEvents ChkTime As CheckBox

End Class
