Module Defines
    Public keybuf As String
    Public sendat As Boolean
    Public sendtime As Boolean
    Public senddate As Boolean
    Public appcnt As Integer
    Public app_index As Integer
    Public apps_loaded As Boolean
    Public In_Debug As Boolean
    Public default_icon As Icon
    'Public Version As String = "v 1.1"                  'version 1.1 - Icons working, any cpu no pref.
    Public Version As String = "v 1.2"                  'version 1.2 - Redesign Using chkboxes...
    Public Structure App_Buff
        Public count As Integer             '# of applications running
        Public pid() As Integer
        Public class_name() As String
        Public window_name() As String
        Public icon() As Icon
        Public path() As String
        Public filename() As String
        Public user() As String
    End Structure

    'Get a handle to an application window.
    Declare Auto Function FindWindow Lib "USER32.DLL" ( _
            ByVal lpClassName As String, _
            ByVal lpWindowName As String) As IntPtr
    ' Activate an application window.
    Declare Auto Function SetForegroundWindow Lib "USER32.DLL" _
        (ByVal hWnd As IntPtr) As Boolean
    Declare Auto Function IsWindowVisible Lib "USER32.DLL" _
        (ByVal hWnd As IntPtr) As Boolean
    Declare Auto Function IsWindowEnabled Lib "USER32.DLL" _
        (ByVal hWnd As IntPtr) As Boolean
    Public Declare Function GetActiveWindow Lib "user32" _
                      Alias "GetActiveWindow" () As Long
    Public Declare Function SetActiveWindow Lib "user32" _
                      Alias "SetActiveWindow" () As Long
    'SetActiveWindow(8975651603260375040)



    'Pointers
    Public Apps As App_Buff
End Module
