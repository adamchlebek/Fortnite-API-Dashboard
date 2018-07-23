Imports System.IO
Imports System.Net
Imports Newtonsoft

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim web As WebRequest = WebRequest.Create("https://api.fortnitetracker.com/v1/profile/pc/smokeyfishjr")
        Dim reader As StreamReader
        Dim webResponse As WebResponse
        Dim fullJson As String

        web.Headers.Add("TRN-Api-Key", "bea985f1-1bfb-46b0-acd6-88ea399ebfcb")

        webResponse = web.GetResponse()
        reader = New StreamReader(webResponse.GetResponseStream())

        fullJson = reader.ReadToEnd()

        Dim smokeyfish As User = New User()

        Newtonsoft.Json.JsonConvert.PopulateObject(fullJson, smokeyfish)

    End Sub
End Class
