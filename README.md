Sub RunCommandLineApp()
    Dim wsh As Object
    Dim exePath As String
    Dim input As String
    Dim output As String
    Dim command As String

    ' WScript.Shellオブジェクトを作成
    Set wsh = CreateObject("WScript.Shell")

    ' EXEファイルのパス
    exePath = "C:\path\to\your\exe\CommandLineApp.exe"
    
    ' コマンド引数無しで実行してULIDを生成
    command = exePath
    output = wsh.Exec(command).StdOut.ReadAll
    MsgBox "Generated ULID: " & output
    
    ' -convertDateTimeコマンドでULIDを日時に変換
    input = Trim(output) ' 生成されたULIDを使用
    command = exePath & " -convertDateTime " & input
    output = wsh.Exec(command).StdOut.ReadAll
    MsgBox "Converted DateTime: " & output
End Sub
