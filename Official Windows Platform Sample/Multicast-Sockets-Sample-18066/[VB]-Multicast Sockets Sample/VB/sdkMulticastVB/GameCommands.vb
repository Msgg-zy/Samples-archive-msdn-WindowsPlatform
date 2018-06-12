'
'   Copyright (c) 2011 Microsoft Corporation.  All rights reserved.
'   Use of this sample source code is subject to the terms of the Microsoft license 
'   agreement under which you licensed this sample source code and is provided AS-IS.
'   If you did not accept the terms of the license agreement, you are not authorized 
'   to use this sample source code.  For the terms of the license, please see the 
'   license agreement between you and Microsoft.
'  
'   To see all Code Samples for Windows Phone, visit http://go.microsoft.com/fwlink/?LinkID=219604 
'  
'
Public Class GameCommands
    Public Const CommandDelimeter As String = "|"
    Public Const Join As String = "J"
    Public Const Leave As String = "L"
    Public Const Challenge As String = "C"
    Public Const AcceptChallenge As String = "AC"
    Public Const RejectChallenge As String = "RC"
    Public Const Play As String = "P"
    Public Const Ready As String = "G"
    Public Const NewGame As String = "N"
    Public Const LeaveGame As String = "LG"

    Public Const JoinFormat As String = Join & CommandDelimeter & "{0}"
    Public Const LeaveFormat As String = Leave & CommandDelimeter & "{0}"
    Public Const LeaveGameFormat As String = LeaveGame & CommandDelimeter & "{0}"
    Public Const ChallengeFormat As String = Challenge & CommandDelimeter & "{0}"
    Public Const AcceptChallengeFormat As String = AcceptChallenge & CommandDelimeter & "{0}"
    Public Const NewGameFormat As String = NewGame & CommandDelimeter & "{0}"
    Public Const RejectChallengeFormat As String = RejectChallenge & CommandDelimeter & "{0}"
    Public Const PlayFormat As String = Play & CommandDelimeter & "{0}" & CommandDelimeter & "{1}"
    Public Const ReadyFormat As String = Ready & CommandDelimeter & "{0}"

End Class
