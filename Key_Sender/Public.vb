Imports System.Text
Imports System
Imports System.Collections


Module Routines
    Public Function getApplications() As String
        Dim a As New StringBuilder()
        Dim b As New Process()
        Dim c As New Integer
        Dim pid As Integer

        c = 0
        For Each b In Process.GetProcesses(".")
            Try
                If b.MainWindowTitle.Length > 0 Then
                    Prep_Apps_Array(c)
                    a.Append("Window Title:  " + b.MainWindowTitle.ToString() + Environment.NewLine)
                    a.Append("Process Name:  " + b.ProcessName.ToString() + Environment.NewLine)
                    pid = b.Id
                    Apps.pid(c) = pid
                    Apps.window_name(c) = b.MainWindowTitle.ToString()
                    Apps.class_name(c) = b.ProcessName.ToString()
                    Apps.user(c) = Environment.UserName.ToString()
                    Try
                        Apps.path(c) = b.MainModule.FileName.ToString()
                        Apps.filename(c) = b.MainModule.ModuleName.ToString()
                        Apps.icon(c) = Icon.ExtractAssociatedIcon(b.MainModule.FileName)
                    Catch Exception As System.ComponentModel.Win32Exception
                        Apps.icon(c) = default_icon
                        Apps.path(c) = "Exception thrown - get a database"
                        Apps.filename(c) = Apps.class_name(c)
                    End Try
                    a.Append(Environment.NewLine)
                    c = c + 1
                End If
            Catch
            End Try
        Next
        Apps.count = c - 1
        Return a.ToString()
    End Function
    Public Sub Prep_Apps_Array(ByVal item_number As Integer)
        ReDim Preserve Apps.window_name(item_number)
        ReDim Preserve Apps.class_name(item_number)
        ReDim Preserve Apps.pid(item_number)
        ReDim Preserve Apps.icon(item_number)
        ReDim Preserve Apps.filename(item_number)
        ReDim Preserve Apps.path(item_number)
        ReDim Preserve Apps.user(item_number)
    End Sub
    
    Public Sub clear_apps()
        Apps.count = 0
        ReDim Apps.class_name(0)
        ReDim Apps.window_name(0)
        ReDim Apps.pid(0)
        ReDim Apps.icon(0)
        ReDim Apps.filename(0)
        ReDim Apps.path(0)
        ReDim Apps.user(0)
    End Sub
End Module
