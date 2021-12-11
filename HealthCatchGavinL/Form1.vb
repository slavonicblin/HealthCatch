'Health Kit Catch application
'G. Lepischak
'Dec. 07 2021
'The user trys to click picure while it moves
'extras:
'variable score increase and time limit based on difficulty
'audio on game complete
Public Class Form1
    Private Const EASY_LEVEL As Integer = 2500
    Private Const MODERATE_LEVEL As Integer = 1500
    Private Const HARD_LEVEL As Integer = 600
    Private Const INSANE_LEVEL As Integer = 150
    Private Const EASY_SCORE As Integer = 2
    Private Const MODERATE_SCORE As Integer = 4
    Private Const HARD_SCORE As Integer = 8
    Private Const INSANE_SCORE As Integer = 16
    Private Const EASY_TIME As Integer = 60
    Private Const MODERATE_TIME As Integer = 40
    Private Const HARD_TIME As Integer = 30
    Private Const INSANE_TIME As Integer = 20

    Private moveInterval As Integer
    Private score As Integer
    Private scoreIncrease As Integer
    Private gameOn As Boolean = False
    Private timelimit As Integer
    Private bonusOn As Boolean = False
    Private Sub EasyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EasyToolStripMenuItem.Click
        EasyToolStripMenuItem.Checked = True
        ModerateToolStripMenuItem.Checked = False
        HardToolStripMenuItem.Checked = False
        InsaneToolStripMenuItem.Checked = False

        moveInterval = EASY_LEVEL
        scoreIncrease = EASY_SCORE
        timelimit = EASY_TIME
        lblTimeRemaining.Text = timelimit
    End Sub

    Private Sub ModerateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModerateToolStripMenuItem.Click
        EasyToolStripMenuItem.Checked = False
        ModerateToolStripMenuItem.Checked = True
        HardToolStripMenuItem.Checked = False
        InsaneToolStripMenuItem.Checked = False

        moveInterval = MODERATE_LEVEL
        scoreIncrease = MODERATE_SCORE
        timelimit = MODERATE_TIME
        lblTimeRemaining.Text = timelimit
    End Sub

    Private Sub HardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HardToolStripMenuItem.Click
        EasyToolStripMenuItem.Checked = False
        ModerateToolStripMenuItem.Checked = False
        HardToolStripMenuItem.Checked = True
        InsaneToolStripMenuItem.Checked = False

        moveInterval = HARD_LEVEL
        scoreIncrease = HARD_SCORE
        timelimit = HARD_TIME
        lblTimeRemaining.Text = timelimit
    End Sub

    Private Sub InsaneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsaneToolStripMenuItem.Click
        EasyToolStripMenuItem.Checked = False
        ModerateToolStripMenuItem.Checked = False
        HardToolStripMenuItem.Checked = False
        InsaneToolStripMenuItem.Checked = True

        moveInterval = INSANE_LEVEL
        scoreIncrease = INSANE_SCORE
        timelimit = INSANE_TIME
        lblTimeRemaining.Text = timelimit
    End Sub

    Private Sub picKit_Click(sender As Object, e As EventArgs) Handles picKit.Click
        If gameOn = True Then
            My.Computer.Audio.Play(My.Resources.pickup,
                AudioPlayMode.Background)
            score = score + scoreIncrease
            lblScore.Text = score
        End If
    End Sub

    Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem.Click
        If EasyToolStripMenuItem.Checked Then
            moveInterval = EASY_LEVEL
            scoreIncrease = EASY_SCORE
            timelimit = EASY_TIME
            lblTimeRemaining.Text = timelimit
        End If
        gameOn = True
        tmrKitMove.Enabled = True
        picKit.Enabled = True
        tmrKitMove.Interval = moveInterval
        tmrTimeLimit.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gameOn = False
        picKit.Enabled = False
        tmrKitMove.Enabled = False
        tmrTimeLimit.Enabled = False
    End Sub

    Private Sub tmrKitMove_Tick(sender As Object, e As EventArgs) Handles tmrKitMove.Tick
        Randomize()
        Const MAX_TOP_POSTION As Integer = 398
        Const MAX_LEFT_POSTION As Integer = 348
        Const LOW_POSTION As Integer = 105
        Dim randomTop As Integer
        Dim randomLeft As Integer
        Static counter As Integer = 0

        If timelimit = 0 Then
            gameOn = False
            tmrKitMove.Enabled = False
            tmrTimeLimit.Enabled = False
            My.Computer.Audio.Play(My.Resources.gameover,
                AudioPlayMode.Background)
            MessageBox.Show("Game over. please try again.", "Game over", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
            Application.Exit()
        End If

        If score >= 100 Then
            gameOn = False
            tmrKitMove.Enabled = False
            tmrTimeLimit.Enabled = False
            My.Computer.Audio.Play(My.Resources._07_Red_Triumphs_,
                AudioPlayMode.Background)
            MessageBox.Show("Congratulations you made it to 100", "Game complete", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Application.Exit()
        End If

        randomTop = Int((MAX_TOP_POSTION - LOW_POSTION + 1) * Rnd() + LOW_POSTION)
        picKit.Top = randomTop
        randomLeft = Int((MAX_LEFT_POSTION - LOW_POSTION + 1) * Rnd() + LOW_POSTION)
        picKit.Left = randomLeft

        counter = counter + 1
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        If gameOn = True Then
            score = score - 1
            lblScore.Text = score
            My.Computer.Audio.Play(My.Resources.Roblox_Death_Sound,
                AudioPlayMode.Background)
        End If
    End Sub

    Private Sub tmrTimeLimit_Tick(sender As Object, e As EventArgs) Handles tmrTimeLimit.Tick
        Randomize()
        Const MAX_BONUS_CHANCE = 5
        Const MIN_BONUS_CHANCE = 1
        Static bonusCounter As Integer
        Static bonusActivator As Integer
        Static scoreIncreased As Boolean = False
        If gameOn = True Then
            timelimit = timelimit - 1
            lblTimeRemaining.Text = timelimit
        End If
        If bonusOn = False Then
            bonusActivator = Int((MAX_BONUS_CHANCE - MIN_BONUS_CHANCE + 1) * Rnd() + MIN_BONUS_CHANCE)
        End If
        Select Case bonusActivator
            Case 2
                bonusOn = True
        End Select
        If bonusOn = True Then
            bonusCounter = bonusCounter + 1
        End If
        If bonusOn = True And scoreIncreased = False Then
            scoreIncrease = scoreIncrease + 5
            scoreIncreased = True
        End If
        If bonusCounter = 5 Then
            bonusOn = False
            scoreIncrease = scoreIncrease - 5
            bonusCounter = 0
        End If
    End Sub

    Private Sub AboutGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutGameToolStripMenuItem.Click
        MessageBox.Show("Object of the game: get to 100 points (shown on left) before the time (shown on right) runs out" & vbCrLf &
                        "Step 1: select your difficulty with the difficulty tab" & vbCrLf &
                        "Easy mode: movement every 2.5 seconds, 2 points per click, 60 second time limit" & vbCrLf &
                        "Moderate mode: movement every 1.5 seconds, 4 points per click, 40 second time limit" _
                        & vbCrLf & "Hard mode: movement every .6 seconds, 8 points per click, 30 second time limit" _
                        & vbCrLf & "Insane mode: movement every .15 seconds, 16 points per click, 20 second time limit" & vbCrLf &
                        "Step 2: click the game tab then start to start" & vbCrLf &
                        "Step 3: click the health kit to get points" & vbCrLf &
                        "Every second there is a chance to get a score increase bonus of 5 for 5 seconds",
                        "Game instructions", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ProgrammerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammerToolStripMenuItem.Click
        MessageBox.Show("Programmed by Gavin Lepischak on Dec. 09 2021", "Program info", MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
