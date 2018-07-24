<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.gbUserInfo = New System.Windows.Forms.GroupBox()
        Me.lblEpicUserName = New System.Windows.Forms.Label()
        Me.lblPlatform = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.gbWins = New System.Windows.Forms.GroupBox()
        Me.tblStats = New System.Windows.Forms.TableLayoutPanel()
        Me.hdMatchesPlayed = New System.Windows.Forms.Label()
        Me.lblMatchesPlayed = New System.Windows.Forms.Label()
        Me.hdWins = New System.Windows.Forms.Label()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.hdWinPercentage = New System.Windows.Forms.Label()
        Me.lblWinPercentage = New System.Windows.Forms.Label()
        Me.hdKills = New System.Windows.Forms.Label()
        Me.lblKills = New System.Windows.Forms.Label()
        Me.hdKillsPerMatch = New System.Windows.Forms.Label()
        Me.lblKillsPerMatch = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbDuos = New System.Windows.Forms.TabPage()
        Me.tbSquads = New System.Windows.Forms.TabPage()
        Me.tblDuos = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDuoWinPercentage = New System.Windows.Forms.Label()
        Me.hdDuoWinPercentage = New System.Windows.Forms.Label()
        Me.lblDuoKillsPerMatch = New System.Windows.Forms.Label()
        Me.hdDuoKillsPerMatch = New System.Windows.Forms.Label()
        Me.lblDuoKills = New System.Windows.Forms.Label()
        Me.hdDuoKills = New System.Windows.Forms.Label()
        Me.lblDuoWins = New System.Windows.Forms.Label()
        Me.hdDuoWins = New System.Windows.Forms.Label()
        Me.lblDuoMatchesPlayed = New System.Windows.Forms.Label()
        Me.hdDuoMatchesPlayed = New System.Windows.Forms.Label()
        Me.tblSquads = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSquadWinPercentage = New System.Windows.Forms.Label()
        Me.hdSquadWinPercentage = New System.Windows.Forms.Label()
        Me.lblSquadKillsPerMatch = New System.Windows.Forms.Label()
        Me.hdSquadKillsPerMatch = New System.Windows.Forms.Label()
        Me.lblSquadKills = New System.Windows.Forms.Label()
        Me.hdSquadKills = New System.Windows.Forms.Label()
        Me.lblSquadWins = New System.Windows.Forms.Label()
        Me.hdSquadWins = New System.Windows.Forms.Label()
        Me.lblSquadMatchesPlayed = New System.Windows.Forms.Label()
        Me.hdSquadMatchesPlayed = New System.Windows.Forms.Label()
        Me.tbSolos = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSoloWinPercentage = New System.Windows.Forms.Label()
        Me.hdSoloWinPercentaage = New System.Windows.Forms.Label()
        Me.lblSoloKillsPerMatch = New System.Windows.Forms.Label()
        Me.hdSoloKD = New System.Windows.Forms.Label()
        Me.lblSoloKills = New System.Windows.Forms.Label()
        Me.hdSoloKills = New System.Windows.Forms.Label()
        Me.lblSoloWins = New System.Windows.Forms.Label()
        Me.hdSoloWins = New System.Windows.Forms.Label()
        Me.lblSoloMatchesPlayed = New System.Windows.Forms.Label()
        Me.hdSoloMatches = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lblplayernotfound = New System.Windows.Forms.Label()
        Me.gbUserInfo.SuspendLayout()
        Me.gbWins.SuspendLayout()
        Me.tblStats.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbDuos.SuspendLayout()
        Me.tbSquads.SuspendLayout()
        Me.tblDuos.SuspendLayout()
        Me.tblSquads.SuspendLayout()
        Me.tbSolos.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(12, 12)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(184, 42)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'gbUserInfo
        '
        Me.gbUserInfo.Controls.Add(Me.TabControl1)
        Me.gbUserInfo.Controls.Add(Me.gbWins)
        Me.gbUserInfo.Controls.Add(Me.lblScore)
        Me.gbUserInfo.Controls.Add(Me.lblPlatform)
        Me.gbUserInfo.Controls.Add(Me.lblEpicUserName)
        Me.gbUserInfo.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbUserInfo.Location = New System.Drawing.Point(12, 61)
        Me.gbUserInfo.Name = "gbUserInfo"
        Me.gbUserInfo.Size = New System.Drawing.Size(377, 528)
        Me.gbUserInfo.TabIndex = 1
        Me.gbUserInfo.TabStop = False
        '
        'lblEpicUserName
        '
        Me.lblEpicUserName.AutoSize = True
        Me.lblEpicUserName.Font = New System.Drawing.Font("Bahnschrift", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpicUserName.Location = New System.Drawing.Point(6, 13)
        Me.lblEpicUserName.Name = "lblEpicUserName"
        Me.lblEpicUserName.Size = New System.Drawing.Size(127, 24)
        Me.lblEpicUserName.TabIndex = 0
        Me.lblEpicUserName.Text = "[USERNAME]"
        '
        'lblPlatform
        '
        Me.lblPlatform.AutoSize = True
        Me.lblPlatform.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatform.Location = New System.Drawing.Point(6, 39)
        Me.lblPlatform.Name = "lblPlatform"
        Me.lblPlatform.Size = New System.Drawing.Size(75, 14)
        Me.lblPlatform.TabIndex = 1
        Me.lblPlatform.Text = "[PLATFORM]"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(319, 17)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(52, 14)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "[SCORE]"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gbWins
        '
        Me.gbWins.Controls.Add(Me.tblStats)
        Me.gbWins.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbWins.Location = New System.Drawing.Point(10, 67)
        Me.gbWins.Name = "gbWins"
        Me.gbWins.Size = New System.Drawing.Size(361, 180)
        Me.gbWins.TabIndex = 3
        Me.gbWins.TabStop = False
        Me.gbWins.Text = "Stats"
        '
        'tblStats
        '
        Me.tblStats.ColumnCount = 2
        Me.tblStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.71831!))
        Me.tblStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.28169!))
        Me.tblStats.Controls.Add(Me.lblKillsPerMatch, 1, 4)
        Me.tblStats.Controls.Add(Me.hdKillsPerMatch, 0, 4)
        Me.tblStats.Controls.Add(Me.lblKills, 1, 3)
        Me.tblStats.Controls.Add(Me.hdKills, 0, 3)
        Me.tblStats.Controls.Add(Me.lblWinPercentage, 1, 2)
        Me.tblStats.Controls.Add(Me.hdWinPercentage, 0, 2)
        Me.tblStats.Controls.Add(Me.lblWins, 1, 1)
        Me.tblStats.Controls.Add(Me.hdWins, 0, 1)
        Me.tblStats.Controls.Add(Me.lblMatchesPlayed, 1, 0)
        Me.tblStats.Controls.Add(Me.hdMatchesPlayed, 0, 0)
        Me.tblStats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblStats.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tblStats.Location = New System.Drawing.Point(3, 19)
        Me.tblStats.Name = "tblStats"
        Me.tblStats.RowCount = 5
        Me.tblStats.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblStats.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblStats.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblStats.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblStats.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblStats.Size = New System.Drawing.Size(355, 158)
        Me.tblStats.TabIndex = 4
        '
        'hdMatchesPlayed
        '
        Me.hdMatchesPlayed.AutoSize = True
        Me.hdMatchesPlayed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdMatchesPlayed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdMatchesPlayed.Location = New System.Drawing.Point(3, 0)
        Me.hdMatchesPlayed.Name = "hdMatchesPlayed"
        Me.hdMatchesPlayed.Size = New System.Drawing.Size(135, 31)
        Me.hdMatchesPlayed.TabIndex = 0
        Me.hdMatchesPlayed.Text = "Matches Played:"
        Me.hdMatchesPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMatchesPlayed
        '
        Me.lblMatchesPlayed.AutoSize = True
        Me.lblMatchesPlayed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMatchesPlayed.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatchesPlayed.ForeColor = System.Drawing.Color.Black
        Me.lblMatchesPlayed.Location = New System.Drawing.Point(144, 0)
        Me.lblMatchesPlayed.Name = "lblMatchesPlayed"
        Me.lblMatchesPlayed.Size = New System.Drawing.Size(208, 31)
        Me.lblMatchesPlayed.TabIndex = 1
        Me.lblMatchesPlayed.Text = "[MATCHES PLAYED]"
        Me.lblMatchesPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdWins
        '
        Me.hdWins.AutoSize = True
        Me.hdWins.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdWins.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdWins.Location = New System.Drawing.Point(3, 31)
        Me.hdWins.Name = "hdWins"
        Me.hdWins.Size = New System.Drawing.Size(135, 31)
        Me.hdWins.TabIndex = 2
        Me.hdWins.Text = "Wins:"
        Me.hdWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWins
        '
        Me.lblWins.AutoSize = True
        Me.lblWins.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWins.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWins.ForeColor = System.Drawing.Color.Black
        Me.lblWins.Location = New System.Drawing.Point(144, 31)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(208, 31)
        Me.lblWins.TabIndex = 3
        Me.lblWins.Text = "[WINS]"
        Me.lblWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdWinPercentage
        '
        Me.hdWinPercentage.AutoSize = True
        Me.hdWinPercentage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdWinPercentage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdWinPercentage.Location = New System.Drawing.Point(3, 62)
        Me.hdWinPercentage.Name = "hdWinPercentage"
        Me.hdWinPercentage.Size = New System.Drawing.Size(135, 31)
        Me.hdWinPercentage.TabIndex = 4
        Me.hdWinPercentage.Text = "Win Percentage:"
        Me.hdWinPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWinPercentage
        '
        Me.lblWinPercentage.AutoSize = True
        Me.lblWinPercentage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWinPercentage.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinPercentage.ForeColor = System.Drawing.Color.Black
        Me.lblWinPercentage.Location = New System.Drawing.Point(144, 62)
        Me.lblWinPercentage.Name = "lblWinPercentage"
        Me.lblWinPercentage.Size = New System.Drawing.Size(208, 31)
        Me.lblWinPercentage.TabIndex = 5
        Me.lblWinPercentage.Text = "[WIN PERCENTAGE]"
        Me.lblWinPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdKills
        '
        Me.hdKills.AutoSize = True
        Me.hdKills.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdKills.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdKills.Location = New System.Drawing.Point(3, 93)
        Me.hdKills.Name = "hdKills"
        Me.hdKills.Size = New System.Drawing.Size(135, 31)
        Me.hdKills.TabIndex = 6
        Me.hdKills.Text = "Kills:"
        Me.hdKills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKills
        '
        Me.lblKills.AutoSize = True
        Me.lblKills.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKills.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKills.ForeColor = System.Drawing.Color.Black
        Me.lblKills.Location = New System.Drawing.Point(144, 93)
        Me.lblKills.Name = "lblKills"
        Me.lblKills.Size = New System.Drawing.Size(208, 31)
        Me.lblKills.TabIndex = 7
        Me.lblKills.Text = "[KILLS]"
        Me.lblKills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdKillsPerMatch
        '
        Me.hdKillsPerMatch.AutoSize = True
        Me.hdKillsPerMatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdKillsPerMatch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdKillsPerMatch.Location = New System.Drawing.Point(3, 124)
        Me.hdKillsPerMatch.Name = "hdKillsPerMatch"
        Me.hdKillsPerMatch.Size = New System.Drawing.Size(135, 34)
        Me.hdKillsPerMatch.TabIndex = 8
        Me.hdKillsPerMatch.Text = "Kills Per Match:"
        Me.hdKillsPerMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKillsPerMatch
        '
        Me.lblKillsPerMatch.AutoSize = True
        Me.lblKillsPerMatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKillsPerMatch.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKillsPerMatch.ForeColor = System.Drawing.Color.Black
        Me.lblKillsPerMatch.Location = New System.Drawing.Point(144, 124)
        Me.lblKillsPerMatch.Name = "lblKillsPerMatch"
        Me.lblKillsPerMatch.Size = New System.Drawing.Size(208, 34)
        Me.lblKillsPerMatch.TabIndex = 9
        Me.lblKillsPerMatch.Text = "[KILLS PER MATCH]"
        Me.lblKillsPerMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbSolos)
        Me.TabControl1.Controls.Add(Me.tbDuos)
        Me.TabControl1.Controls.Add(Me.tbSquads)
        Me.TabControl1.Location = New System.Drawing.Point(10, 253)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(358, 269)
        Me.TabControl1.TabIndex = 4
        '
        'tbDuos
        '
        Me.tbDuos.Controls.Add(Me.tblDuos)
        Me.tbDuos.Font = New System.Drawing.Font("Bahnschrift", 9.0!)
        Me.tbDuos.Location = New System.Drawing.Point(4, 22)
        Me.tbDuos.Name = "tbDuos"
        Me.tbDuos.Size = New System.Drawing.Size(350, 243)
        Me.tbDuos.TabIndex = 2
        Me.tbDuos.Text = "Duos"
        Me.tbDuos.UseVisualStyleBackColor = True
        '
        'tbSquads
        '
        Me.tbSquads.Controls.Add(Me.tblSquads)
        Me.tbSquads.Font = New System.Drawing.Font("Bahnschrift", 9.0!)
        Me.tbSquads.Location = New System.Drawing.Point(4, 22)
        Me.tbSquads.Name = "tbSquads"
        Me.tbSquads.Size = New System.Drawing.Size(350, 243)
        Me.tbSquads.TabIndex = 3
        Me.tbSquads.Text = "Squads"
        Me.tbSquads.UseVisualStyleBackColor = True
        '
        'tblDuos
        '
        Me.tblDuos.ColumnCount = 2
        Me.tblDuos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.71831!))
        Me.tblDuos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.28169!))
        Me.tblDuos.Controls.Add(Me.lblDuoWinPercentage, 1, 4)
        Me.tblDuos.Controls.Add(Me.hdDuoWinPercentage, 0, 4)
        Me.tblDuos.Controls.Add(Me.lblDuoKillsPerMatch, 1, 3)
        Me.tblDuos.Controls.Add(Me.hdDuoKillsPerMatch, 0, 3)
        Me.tblDuos.Controls.Add(Me.lblDuoKills, 1, 2)
        Me.tblDuos.Controls.Add(Me.hdDuoKills, 0, 2)
        Me.tblDuos.Controls.Add(Me.lblDuoWins, 1, 1)
        Me.tblDuos.Controls.Add(Me.hdDuoWins, 0, 1)
        Me.tblDuos.Controls.Add(Me.lblDuoMatchesPlayed, 1, 0)
        Me.tblDuos.Controls.Add(Me.hdDuoMatchesPlayed, 0, 0)
        Me.tblDuos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDuos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tblDuos.Location = New System.Drawing.Point(0, 0)
        Me.tblDuos.Name = "tblDuos"
        Me.tblDuos.RowCount = 5
        Me.tblDuos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblDuos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblDuos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblDuos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblDuos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblDuos.Size = New System.Drawing.Size(350, 243)
        Me.tblDuos.TabIndex = 6
        '
        'lblDuoWinPercentage
        '
        Me.lblDuoWinPercentage.AutoSize = True
        Me.lblDuoWinPercentage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuoWinPercentage.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuoWinPercentage.ForeColor = System.Drawing.Color.Black
        Me.lblDuoWinPercentage.Location = New System.Drawing.Point(142, 192)
        Me.lblDuoWinPercentage.Name = "lblDuoWinPercentage"
        Me.lblDuoWinPercentage.Size = New System.Drawing.Size(205, 51)
        Me.lblDuoWinPercentage.TabIndex = 9
        Me.lblDuoWinPercentage.Text = "[WIN PERCENTAGE]"
        Me.lblDuoWinPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdDuoWinPercentage
        '
        Me.hdDuoWinPercentage.AutoSize = True
        Me.hdDuoWinPercentage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdDuoWinPercentage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdDuoWinPercentage.Location = New System.Drawing.Point(3, 192)
        Me.hdDuoWinPercentage.Name = "hdDuoWinPercentage"
        Me.hdDuoWinPercentage.Size = New System.Drawing.Size(133, 51)
        Me.hdDuoWinPercentage.TabIndex = 8
        Me.hdDuoWinPercentage.Text = "Duo Win Percentage:"
        Me.hdDuoWinPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDuoKillsPerMatch
        '
        Me.lblDuoKillsPerMatch.AutoSize = True
        Me.lblDuoKillsPerMatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuoKillsPerMatch.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuoKillsPerMatch.ForeColor = System.Drawing.Color.Black
        Me.lblDuoKillsPerMatch.Location = New System.Drawing.Point(142, 144)
        Me.lblDuoKillsPerMatch.Name = "lblDuoKillsPerMatch"
        Me.lblDuoKillsPerMatch.Size = New System.Drawing.Size(205, 48)
        Me.lblDuoKillsPerMatch.TabIndex = 7
        Me.lblDuoKillsPerMatch.Text = "[KILLS PER MATCH]"
        Me.lblDuoKillsPerMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdDuoKillsPerMatch
        '
        Me.hdDuoKillsPerMatch.AutoSize = True
        Me.hdDuoKillsPerMatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdDuoKillsPerMatch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdDuoKillsPerMatch.Location = New System.Drawing.Point(3, 144)
        Me.hdDuoKillsPerMatch.Name = "hdDuoKillsPerMatch"
        Me.hdDuoKillsPerMatch.Size = New System.Drawing.Size(133, 48)
        Me.hdDuoKillsPerMatch.TabIndex = 6
        Me.hdDuoKillsPerMatch.Text = "Duo Kills Per Match:"
        Me.hdDuoKillsPerMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDuoKills
        '
        Me.lblDuoKills.AutoSize = True
        Me.lblDuoKills.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuoKills.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuoKills.ForeColor = System.Drawing.Color.Black
        Me.lblDuoKills.Location = New System.Drawing.Point(142, 96)
        Me.lblDuoKills.Name = "lblDuoKills"
        Me.lblDuoKills.Size = New System.Drawing.Size(205, 48)
        Me.lblDuoKills.TabIndex = 5
        Me.lblDuoKills.Text = "[KILLS]"
        Me.lblDuoKills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdDuoKills
        '
        Me.hdDuoKills.AutoSize = True
        Me.hdDuoKills.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdDuoKills.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdDuoKills.Location = New System.Drawing.Point(3, 96)
        Me.hdDuoKills.Name = "hdDuoKills"
        Me.hdDuoKills.Size = New System.Drawing.Size(133, 48)
        Me.hdDuoKills.TabIndex = 4
        Me.hdDuoKills.Text = "Duo Kills:"
        Me.hdDuoKills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDuoWins
        '
        Me.lblDuoWins.AutoSize = True
        Me.lblDuoWins.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuoWins.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuoWins.ForeColor = System.Drawing.Color.Black
        Me.lblDuoWins.Location = New System.Drawing.Point(142, 48)
        Me.lblDuoWins.Name = "lblDuoWins"
        Me.lblDuoWins.Size = New System.Drawing.Size(205, 48)
        Me.lblDuoWins.TabIndex = 3
        Me.lblDuoWins.Text = "[WINS]"
        Me.lblDuoWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdDuoWins
        '
        Me.hdDuoWins.AutoSize = True
        Me.hdDuoWins.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdDuoWins.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdDuoWins.Location = New System.Drawing.Point(3, 48)
        Me.hdDuoWins.Name = "hdDuoWins"
        Me.hdDuoWins.Size = New System.Drawing.Size(133, 48)
        Me.hdDuoWins.TabIndex = 2
        Me.hdDuoWins.Text = "Duo Wins:"
        Me.hdDuoWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDuoMatchesPlayed
        '
        Me.lblDuoMatchesPlayed.AutoSize = True
        Me.lblDuoMatchesPlayed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuoMatchesPlayed.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuoMatchesPlayed.ForeColor = System.Drawing.Color.Black
        Me.lblDuoMatchesPlayed.Location = New System.Drawing.Point(142, 0)
        Me.lblDuoMatchesPlayed.Name = "lblDuoMatchesPlayed"
        Me.lblDuoMatchesPlayed.Size = New System.Drawing.Size(205, 48)
        Me.lblDuoMatchesPlayed.TabIndex = 1
        Me.lblDuoMatchesPlayed.Text = "[MATCHES PLAYED]"
        Me.lblDuoMatchesPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdDuoMatchesPlayed
        '
        Me.hdDuoMatchesPlayed.AutoSize = True
        Me.hdDuoMatchesPlayed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdDuoMatchesPlayed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdDuoMatchesPlayed.Location = New System.Drawing.Point(3, 0)
        Me.hdDuoMatchesPlayed.Name = "hdDuoMatchesPlayed"
        Me.hdDuoMatchesPlayed.Size = New System.Drawing.Size(133, 48)
        Me.hdDuoMatchesPlayed.TabIndex = 0
        Me.hdDuoMatchesPlayed.Text = "Duo Matches Played:"
        Me.hdDuoMatchesPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tblSquads
        '
        Me.tblSquads.ColumnCount = 2
        Me.tblSquads.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.71831!))
        Me.tblSquads.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.28169!))
        Me.tblSquads.Controls.Add(Me.lblSquadWinPercentage, 1, 4)
        Me.tblSquads.Controls.Add(Me.hdSquadWinPercentage, 0, 4)
        Me.tblSquads.Controls.Add(Me.lblSquadKillsPerMatch, 1, 3)
        Me.tblSquads.Controls.Add(Me.hdSquadKillsPerMatch, 0, 3)
        Me.tblSquads.Controls.Add(Me.lblSquadKills, 1, 2)
        Me.tblSquads.Controls.Add(Me.hdSquadKills, 0, 2)
        Me.tblSquads.Controls.Add(Me.lblSquadWins, 1, 1)
        Me.tblSquads.Controls.Add(Me.hdSquadWins, 0, 1)
        Me.tblSquads.Controls.Add(Me.lblSquadMatchesPlayed, 1, 0)
        Me.tblSquads.Controls.Add(Me.hdSquadMatchesPlayed, 0, 0)
        Me.tblSquads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblSquads.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tblSquads.Location = New System.Drawing.Point(0, 0)
        Me.tblSquads.Name = "tblSquads"
        Me.tblSquads.RowCount = 5
        Me.tblSquads.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblSquads.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblSquads.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblSquads.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblSquads.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblSquads.Size = New System.Drawing.Size(350, 243)
        Me.tblSquads.TabIndex = 6
        '
        'lblSquadWinPercentage
        '
        Me.lblSquadWinPercentage.AutoSize = True
        Me.lblSquadWinPercentage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSquadWinPercentage.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSquadWinPercentage.ForeColor = System.Drawing.Color.Black
        Me.lblSquadWinPercentage.Location = New System.Drawing.Point(142, 192)
        Me.lblSquadWinPercentage.Name = "lblSquadWinPercentage"
        Me.lblSquadWinPercentage.Size = New System.Drawing.Size(205, 51)
        Me.lblSquadWinPercentage.TabIndex = 9
        Me.lblSquadWinPercentage.Text = "[WIN PERCENTAGE]"
        Me.lblSquadWinPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdSquadWinPercentage
        '
        Me.hdSquadWinPercentage.AutoSize = True
        Me.hdSquadWinPercentage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdSquadWinPercentage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdSquadWinPercentage.Location = New System.Drawing.Point(3, 192)
        Me.hdSquadWinPercentage.Name = "hdSquadWinPercentage"
        Me.hdSquadWinPercentage.Size = New System.Drawing.Size(133, 51)
        Me.hdSquadWinPercentage.TabIndex = 8
        Me.hdSquadWinPercentage.Text = "Squad Win Percentage:"
        Me.hdSquadWinPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSquadKillsPerMatch
        '
        Me.lblSquadKillsPerMatch.AutoSize = True
        Me.lblSquadKillsPerMatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSquadKillsPerMatch.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSquadKillsPerMatch.ForeColor = System.Drawing.Color.Black
        Me.lblSquadKillsPerMatch.Location = New System.Drawing.Point(142, 144)
        Me.lblSquadKillsPerMatch.Name = "lblSquadKillsPerMatch"
        Me.lblSquadKillsPerMatch.Size = New System.Drawing.Size(205, 48)
        Me.lblSquadKillsPerMatch.TabIndex = 7
        Me.lblSquadKillsPerMatch.Text = "[KILLS PER MATCH]"
        Me.lblSquadKillsPerMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdSquadKillsPerMatch
        '
        Me.hdSquadKillsPerMatch.AutoSize = True
        Me.hdSquadKillsPerMatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdSquadKillsPerMatch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdSquadKillsPerMatch.Location = New System.Drawing.Point(3, 144)
        Me.hdSquadKillsPerMatch.Name = "hdSquadKillsPerMatch"
        Me.hdSquadKillsPerMatch.Size = New System.Drawing.Size(133, 48)
        Me.hdSquadKillsPerMatch.TabIndex = 6
        Me.hdSquadKillsPerMatch.Text = "Squad Kills Per Match:"
        Me.hdSquadKillsPerMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSquadKills
        '
        Me.lblSquadKills.AutoSize = True
        Me.lblSquadKills.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSquadKills.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSquadKills.ForeColor = System.Drawing.Color.Black
        Me.lblSquadKills.Location = New System.Drawing.Point(142, 96)
        Me.lblSquadKills.Name = "lblSquadKills"
        Me.lblSquadKills.Size = New System.Drawing.Size(205, 48)
        Me.lblSquadKills.TabIndex = 5
        Me.lblSquadKills.Text = "[KILLS]"
        Me.lblSquadKills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdSquadKills
        '
        Me.hdSquadKills.AutoSize = True
        Me.hdSquadKills.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdSquadKills.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdSquadKills.Location = New System.Drawing.Point(3, 96)
        Me.hdSquadKills.Name = "hdSquadKills"
        Me.hdSquadKills.Size = New System.Drawing.Size(133, 48)
        Me.hdSquadKills.TabIndex = 4
        Me.hdSquadKills.Text = "Squad Kills:"
        Me.hdSquadKills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSquadWins
        '
        Me.lblSquadWins.AutoSize = True
        Me.lblSquadWins.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSquadWins.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSquadWins.ForeColor = System.Drawing.Color.Black
        Me.lblSquadWins.Location = New System.Drawing.Point(142, 48)
        Me.lblSquadWins.Name = "lblSquadWins"
        Me.lblSquadWins.Size = New System.Drawing.Size(205, 48)
        Me.lblSquadWins.TabIndex = 3
        Me.lblSquadWins.Text = "[WINS]"
        Me.lblSquadWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdSquadWins
        '
        Me.hdSquadWins.AutoSize = True
        Me.hdSquadWins.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdSquadWins.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdSquadWins.Location = New System.Drawing.Point(3, 48)
        Me.hdSquadWins.Name = "hdSquadWins"
        Me.hdSquadWins.Size = New System.Drawing.Size(133, 48)
        Me.hdSquadWins.TabIndex = 2
        Me.hdSquadWins.Text = "Squad Wins:"
        Me.hdSquadWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSquadMatchesPlayed
        '
        Me.lblSquadMatchesPlayed.AutoSize = True
        Me.lblSquadMatchesPlayed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSquadMatchesPlayed.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSquadMatchesPlayed.ForeColor = System.Drawing.Color.Black
        Me.lblSquadMatchesPlayed.Location = New System.Drawing.Point(142, 0)
        Me.lblSquadMatchesPlayed.Name = "lblSquadMatchesPlayed"
        Me.lblSquadMatchesPlayed.Size = New System.Drawing.Size(205, 48)
        Me.lblSquadMatchesPlayed.TabIndex = 1
        Me.lblSquadMatchesPlayed.Text = "[MATCHES PLAYED]"
        Me.lblSquadMatchesPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdSquadMatchesPlayed
        '
        Me.hdSquadMatchesPlayed.AutoSize = True
        Me.hdSquadMatchesPlayed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdSquadMatchesPlayed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdSquadMatchesPlayed.Location = New System.Drawing.Point(3, 0)
        Me.hdSquadMatchesPlayed.Name = "hdSquadMatchesPlayed"
        Me.hdSquadMatchesPlayed.Size = New System.Drawing.Size(133, 48)
        Me.hdSquadMatchesPlayed.TabIndex = 0
        Me.hdSquadMatchesPlayed.Text = "Squad Matches Played:"
        Me.hdSquadMatchesPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbSolos
        '
        Me.tbSolos.Controls.Add(Me.TableLayoutPanel2)
        Me.tbSolos.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSolos.Location = New System.Drawing.Point(4, 22)
        Me.tbSolos.Name = "tbSolos"
        Me.tbSolos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSolos.Size = New System.Drawing.Size(350, 243)
        Me.tbSolos.TabIndex = 1
        Me.tbSolos.Text = "Solos"
        Me.tbSolos.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.71831!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.28169!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblSoloWinPercentage, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.hdSoloWinPercentaage, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lblSoloKillsPerMatch, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.hdSoloKD, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblSoloKills, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.hdSoloKills, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblSoloWins, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.hdSoloWins, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblSoloMatchesPlayed, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.hdSoloMatches, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(344, 237)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'lblSoloWinPercentage
        '
        Me.lblSoloWinPercentage.AutoSize = True
        Me.lblSoloWinPercentage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSoloWinPercentage.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoloWinPercentage.ForeColor = System.Drawing.Color.Black
        Me.lblSoloWinPercentage.Location = New System.Drawing.Point(139, 188)
        Me.lblSoloWinPercentage.Name = "lblSoloWinPercentage"
        Me.lblSoloWinPercentage.Size = New System.Drawing.Size(202, 49)
        Me.lblSoloWinPercentage.TabIndex = 9
        Me.lblSoloWinPercentage.Text = "[WIN PERCENTAGE]"
        Me.lblSoloWinPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdSoloWinPercentaage
        '
        Me.hdSoloWinPercentaage.AutoSize = True
        Me.hdSoloWinPercentaage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdSoloWinPercentaage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdSoloWinPercentaage.Location = New System.Drawing.Point(3, 188)
        Me.hdSoloWinPercentaage.Name = "hdSoloWinPercentaage"
        Me.hdSoloWinPercentaage.Size = New System.Drawing.Size(130, 49)
        Me.hdSoloWinPercentaage.TabIndex = 8
        Me.hdSoloWinPercentaage.Text = "Solo Win Percentage:"
        Me.hdSoloWinPercentaage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSoloKillsPerMatch
        '
        Me.lblSoloKillsPerMatch.AutoSize = True
        Me.lblSoloKillsPerMatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSoloKillsPerMatch.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoloKillsPerMatch.ForeColor = System.Drawing.Color.Black
        Me.lblSoloKillsPerMatch.Location = New System.Drawing.Point(139, 141)
        Me.lblSoloKillsPerMatch.Name = "lblSoloKillsPerMatch"
        Me.lblSoloKillsPerMatch.Size = New System.Drawing.Size(202, 47)
        Me.lblSoloKillsPerMatch.TabIndex = 7
        Me.lblSoloKillsPerMatch.Text = "[KILLS PER MATCH]"
        Me.lblSoloKillsPerMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdSoloKD
        '
        Me.hdSoloKD.AutoSize = True
        Me.hdSoloKD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdSoloKD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdSoloKD.Location = New System.Drawing.Point(3, 141)
        Me.hdSoloKD.Name = "hdSoloKD"
        Me.hdSoloKD.Size = New System.Drawing.Size(130, 47)
        Me.hdSoloKD.TabIndex = 6
        Me.hdSoloKD.Text = "Solo Kills Per Match:"
        Me.hdSoloKD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSoloKills
        '
        Me.lblSoloKills.AutoSize = True
        Me.lblSoloKills.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSoloKills.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoloKills.ForeColor = System.Drawing.Color.Black
        Me.lblSoloKills.Location = New System.Drawing.Point(139, 94)
        Me.lblSoloKills.Name = "lblSoloKills"
        Me.lblSoloKills.Size = New System.Drawing.Size(202, 47)
        Me.lblSoloKills.TabIndex = 5
        Me.lblSoloKills.Text = "[KILLS]"
        Me.lblSoloKills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdSoloKills
        '
        Me.hdSoloKills.AutoSize = True
        Me.hdSoloKills.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdSoloKills.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdSoloKills.Location = New System.Drawing.Point(3, 94)
        Me.hdSoloKills.Name = "hdSoloKills"
        Me.hdSoloKills.Size = New System.Drawing.Size(130, 47)
        Me.hdSoloKills.TabIndex = 4
        Me.hdSoloKills.Text = "Solo Kills:"
        Me.hdSoloKills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSoloWins
        '
        Me.lblSoloWins.AutoSize = True
        Me.lblSoloWins.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSoloWins.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoloWins.ForeColor = System.Drawing.Color.Black
        Me.lblSoloWins.Location = New System.Drawing.Point(139, 47)
        Me.lblSoloWins.Name = "lblSoloWins"
        Me.lblSoloWins.Size = New System.Drawing.Size(202, 47)
        Me.lblSoloWins.TabIndex = 3
        Me.lblSoloWins.Text = "[WINS]"
        Me.lblSoloWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdSoloWins
        '
        Me.hdSoloWins.AutoSize = True
        Me.hdSoloWins.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdSoloWins.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdSoloWins.Location = New System.Drawing.Point(3, 47)
        Me.hdSoloWins.Name = "hdSoloWins"
        Me.hdSoloWins.Size = New System.Drawing.Size(130, 47)
        Me.hdSoloWins.TabIndex = 2
        Me.hdSoloWins.Text = "Solo Wins:"
        Me.hdSoloWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSoloMatchesPlayed
        '
        Me.lblSoloMatchesPlayed.AutoSize = True
        Me.lblSoloMatchesPlayed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSoloMatchesPlayed.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoloMatchesPlayed.ForeColor = System.Drawing.Color.Black
        Me.lblSoloMatchesPlayed.Location = New System.Drawing.Point(139, 0)
        Me.lblSoloMatchesPlayed.Name = "lblSoloMatchesPlayed"
        Me.lblSoloMatchesPlayed.Size = New System.Drawing.Size(202, 47)
        Me.lblSoloMatchesPlayed.TabIndex = 1
        Me.lblSoloMatchesPlayed.Text = "[MATCHES PLAYED]"
        Me.lblSoloMatchesPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdSoloMatches
        '
        Me.hdSoloMatches.AutoSize = True
        Me.hdSoloMatches.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdSoloMatches.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.hdSoloMatches.Location = New System.Drawing.Point(3, 0)
        Me.hdSoloMatches.Name = "hdSoloMatches"
        Me.hdSoloMatches.Size = New System.Drawing.Size(130, 47)
        Me.hdSoloMatches.TabIndex = 0
        Me.hdSoloMatches.Text = "Solo Matches Played:"
        Me.hdSoloMatches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(200, 12)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(184, 42)
        Me.btnNew.TabIndex = 2
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lblplayernotfound
        '
        Me.lblplayernotfound.AutoSize = True
        Me.lblplayernotfound.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblplayernotfound.Location = New System.Drawing.Point(62, 293)
        Me.lblplayernotfound.Name = "lblplayernotfound"
        Me.lblplayernotfound.Size = New System.Drawing.Size(263, 33)
        Me.lblplayernotfound.TabIndex = 3
        Me.lblplayernotfound.Text = "PLAYER NOT FOUND!"
        Me.lblplayernotfound.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 601)
        Me.Controls.Add(Me.lblplayernotfound)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.gbUserInfo)
        Me.Controls.Add(Me.btnRefresh)
        Me.Name = "Form1"
        Me.Text = "Fortnite Stats"
        Me.gbUserInfo.ResumeLayout(False)
        Me.gbUserInfo.PerformLayout()
        Me.gbWins.ResumeLayout(False)
        Me.tblStats.ResumeLayout(False)
        Me.tblStats.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tbDuos.ResumeLayout(False)
        Me.tbSquads.ResumeLayout(False)
        Me.tblDuos.ResumeLayout(False)
        Me.tblDuos.PerformLayout()
        Me.tblSquads.ResumeLayout(False)
        Me.tblSquads.PerformLayout()
        Me.tbSolos.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRefresh As Button
    Friend WithEvents gbUserInfo As GroupBox
    Friend WithEvents lblEpicUserName As Label
    Friend WithEvents lblPlatform As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents gbWins As GroupBox
    Friend WithEvents tblStats As TableLayoutPanel
    Friend WithEvents lblKillsPerMatch As Label
    Friend WithEvents hdKillsPerMatch As Label
    Friend WithEvents lblKills As Label
    Friend WithEvents hdKills As Label
    Friend WithEvents lblWinPercentage As Label
    Friend WithEvents hdWinPercentage As Label
    Friend WithEvents lblWins As Label
    Friend WithEvents hdWins As Label
    Friend WithEvents lblMatchesPlayed As Label
    Friend WithEvents hdMatchesPlayed As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbDuos As TabPage
    Friend WithEvents tbSquads As TabPage
    Friend WithEvents tbSolos As TabPage
    Friend WithEvents tblDuos As TableLayoutPanel
    Friend WithEvents lblDuoWinPercentage As Label
    Friend WithEvents hdDuoWinPercentage As Label
    Friend WithEvents lblDuoKillsPerMatch As Label
    Friend WithEvents hdDuoKillsPerMatch As Label
    Friend WithEvents lblDuoKills As Label
    Friend WithEvents hdDuoKills As Label
    Friend WithEvents lblDuoWins As Label
    Friend WithEvents hdDuoWins As Label
    Friend WithEvents lblDuoMatchesPlayed As Label
    Friend WithEvents hdDuoMatchesPlayed As Label
    Friend WithEvents tblSquads As TableLayoutPanel
    Friend WithEvents lblSquadWinPercentage As Label
    Friend WithEvents hdSquadWinPercentage As Label
    Friend WithEvents lblSquadKillsPerMatch As Label
    Friend WithEvents hdSquadKillsPerMatch As Label
    Friend WithEvents lblSquadKills As Label
    Friend WithEvents hdSquadKills As Label
    Friend WithEvents lblSquadWins As Label
    Friend WithEvents hdSquadWins As Label
    Friend WithEvents lblSquadMatchesPlayed As Label
    Friend WithEvents hdSquadMatchesPlayed As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblSoloWinPercentage As Label
    Friend WithEvents hdSoloWinPercentaage As Label
    Friend WithEvents lblSoloKillsPerMatch As Label
    Friend WithEvents hdSoloKD As Label
    Friend WithEvents lblSoloKills As Label
    Friend WithEvents hdSoloKills As Label
    Friend WithEvents lblSoloWins As Label
    Friend WithEvents hdSoloWins As Label
    Friend WithEvents lblSoloMatchesPlayed As Label
    Friend WithEvents hdSoloMatches As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents lblplayernotfound As Label
End Class
