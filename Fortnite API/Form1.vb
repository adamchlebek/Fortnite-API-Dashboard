Imports System.IO
Imports System.Net
Imports Newtonsoft
Imports Newtonsoft.Json.Linq

Public Class Form1
    Dim newUser As New account
    Dim user As String
    Dim platform As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        GetInfo(user, platform)
        FillLabels()
    End Sub

    Public Sub GetInfo(user As String, platform As String)
        Dim web As WebRequest = WebRequest.Create("https://api.fortnitetracker.com/v1/profile/" & platform & "/" & user)
        Dim reader As StreamReader
        Dim webResponse As WebResponse
        Dim jsonString As String

        web.Headers.Add("TRN-Api-Key", "bea985f1-1bfb-46b0-acd6-88ea399ebfcb")
        Try
            webResponse = web.GetResponse()
            reader = New StreamReader(webResponse.GetResponseStream())
            jsonString = reader.ReadToEnd()

            Dim json As JObject = JObject.Parse(jsonString)

            If jsonString.Contains("Player Not Found") Then
                gbUserInfo.Visible = False
                lblplayernotfound.Visible = True
            Else
                AssignVaraibles(json)
            End If
        Catch ex As Exception
            gbUserInfo.Visible = False
            lblplayernotfound.Visible = True
        End Try
    End Sub

    Public Sub AssignVaraibles(jsonobj As JObject)
        newUser.epicUserHandle = jsonobj.SelectToken("epicUserHandle")
        newUser.platformNameLong = jsonobj.SelectToken("platformNameLong")
        newUser.score = jsonobj.SelectToken("lifeTimeStats[6].value")
        newUser.matchesPlayed = jsonobj.SelectToken("lifeTimeStats[7].value")
        newUser.Wins = jsonobj.SelectToken("lifeTimeStats[8].value")
        newUser.WinPercent = jsonobj.SelectToken("lifeTimeStats[9].value")
        newUser.Kills = jsonobj.SelectToken("lifeTimeStats[10].value")
        newUser.KD = jsonobj.SelectToken("lifeTimeStats[11].value")

        newUser.SoloMatches = jsonobj.SelectToken("stats").SelectToken("p2").SelectToken("matches").SelectToken("value")
        newUser.SoloWins = jsonobj.SelectToken("stats").SelectToken("p2").SelectToken("top1").SelectToken("valueInt")
        newUser.SoloKills = jsonobj.SelectToken("stats").SelectToken("p2").SelectToken("kills").SelectToken("value")
        newUser.SoloKD = jsonobj.SelectToken("stats").SelectToken("p2").SelectToken("kd").SelectToken("valueDec")
        newUser.SoloWinPercent = jsonobj.SelectToken("stats").SelectToken("p2").SelectToken("winRatio").SelectToken("valueDec")

        newUser.DuoMatches = jsonobj.SelectToken("stats").SelectToken("p10").SelectToken("matches").SelectToken("value")
        newUser.DuoWins = jsonobj.SelectToken("stats").SelectToken("p10").SelectToken("top1").SelectToken("valueInt")
        newUser.DuoKills = jsonobj.SelectToken("stats").SelectToken("p10").SelectToken("kills").SelectToken("value")
        newUser.DuoKD = jsonobj.SelectToken("stats").SelectToken("p10").SelectToken("kd").SelectToken("valueDec")
        newUser.DuoWinPercent = jsonobj.SelectToken("stats").SelectToken("p10").SelectToken("winRatio").SelectToken("valueDec")

        newUser.SquadMatches = jsonobj.SelectToken("stats").SelectToken("p9").SelectToken("matches").SelectToken("value")
        newUser.SquadWins = jsonobj.SelectToken("stats").SelectToken("p9").SelectToken("top1").SelectToken("valueInt")
        newUser.SquadKills = jsonobj.SelectToken("stats").SelectToken("p9").SelectToken("kills").SelectToken("value")
        newUser.SquadKD = jsonobj.SelectToken("stats").SelectToken("p9").SelectToken("kd").SelectToken("valueDec")
        newUser.SquadWinPercent = jsonobj.SelectToken("stats").SelectToken("p9").SelectToken("winRatio").SelectToken("valueDec")

    End Sub

    Public Sub FillLabels()
        lblEpicUserName.Text = newUser.epicUserHandle
        lblPlatform.Text = newUser.platformNameLong
        lblScore.Text = newUser.score
        lblMatchesPlayed.Text = newUser.matchesPlayed
        lblWins.Text = newUser.Wins
        lblWinPercentage.Text = newUser.WinPercent
        lblKills.Text = newUser.Kills
        lblKillsPerMatch.Text = newUser.KD

        lblSoloMatchesPlayed.Text = newUser.SoloMatches
        lblSoloWins.Text = newUser.SoloWins
        lblSoloKills.Text = newUser.SoloKills
        lblSoloKillsPerMatch.Text = newUser.SoloKD
        lblSoloWinPercentage.Text = newUser.SoloWinPercent

        lblDuoMatchesPlayed.Text = newUser.DuoMatches
        lblDuoWins.Text = newUser.DuoWins
        lblDuoKills.Text = newUser.DuoKills
        lblDuoKillsPerMatch.Text = newUser.DuoKD
        lblDuoWinPercentage.Text = newUser.DuoWinPercent

        lblSquadMatchesPlayed.Text = newUser.SquadMatches
        lblSquadWins.Text = newUser.SquadWins
        lblSquadKills.Text = newUser.SquadKills
        lblSquadKillsPerMatch.Text = newUser.SquadKD
        lblSquadWinPercentage.Text = newUser.SquadWinPercent

    End Sub

    Public Sub CenterToForm(obj As Control)
        obj.Left = (Me.gbUserInfo.Width - obj.Width) / 2
        'obj.Top = (Me.ClientSize.Height - obj.Height) / 2
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbUserInfo.Visible = False
        btnRefresh.Visible = False
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        user = InputBox("Enter the Username of the player you would like to check!", "Username")
        platform = InputBox("Enter the Platform of the player you would like to check!", "Username")

        GetInfo(user, platform)
        FillLabels()
        gbUserInfo.Visible = True
        btnRefresh.Visible = True
    End Sub
End Class
