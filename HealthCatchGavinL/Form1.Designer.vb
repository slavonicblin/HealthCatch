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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiffucultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EasyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModerateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsaneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrammerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.tmrKitMove = New System.Windows.Forms.Timer(Me.components)
        Me.picKit = New System.Windows.Forms.PictureBox()
        Me.lblTimeRemaining = New System.Windows.Forms.Label()
        Me.tmrTimeLimit = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picKit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.DiffucultyToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(754, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.StopToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.GameToolStripMenuItem.Text = "Game"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'DiffucultyToolStripMenuItem
        '
        Me.DiffucultyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EasyToolStripMenuItem, Me.ModerateToolStripMenuItem, Me.HardToolStripMenuItem, Me.InsaneToolStripMenuItem})
        Me.DiffucultyToolStripMenuItem.Name = "DiffucultyToolStripMenuItem"
        Me.DiffucultyToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.DiffucultyToolStripMenuItem.Text = "Difficulty"
        '
        'EasyToolStripMenuItem
        '
        Me.EasyToolStripMenuItem.Checked = True
        Me.EasyToolStripMenuItem.CheckOnClick = True
        Me.EasyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EasyToolStripMenuItem.Name = "EasyToolStripMenuItem"
        Me.EasyToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EasyToolStripMenuItem.Text = "Easy"
        '
        'ModerateToolStripMenuItem
        '
        Me.ModerateToolStripMenuItem.CheckOnClick = True
        Me.ModerateToolStripMenuItem.Name = "ModerateToolStripMenuItem"
        Me.ModerateToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModerateToolStripMenuItem.Text = "Moderate"
        '
        'HardToolStripMenuItem
        '
        Me.HardToolStripMenuItem.CheckOnClick = True
        Me.HardToolStripMenuItem.Name = "HardToolStripMenuItem"
        Me.HardToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.HardToolStripMenuItem.Text = "Hard"
        '
        'InsaneToolStripMenuItem
        '
        Me.InsaneToolStripMenuItem.CheckOnClick = True
        Me.InsaneToolStripMenuItem.Name = "InsaneToolStripMenuItem"
        Me.InsaneToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.InsaneToolStripMenuItem.Text = "Insane"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutGameToolStripMenuItem, Me.ProgrammerToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutGameToolStripMenuItem
        '
        Me.AboutGameToolStripMenuItem.Name = "AboutGameToolStripMenuItem"
        Me.AboutGameToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AboutGameToolStripMenuItem.Text = "Game instructions"
        '
        'ProgrammerToolStripMenuItem
        '
        Me.ProgrammerToolStripMenuItem.Name = "ProgrammerToolStripMenuItem"
        Me.ProgrammerToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ProgrammerToolStripMenuItem.Text = "Programmer"
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.lblScore.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(12, 34)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(83, 65)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrKitMove
        '
        '
        'picKit
        '
        Me.picKit.Image = Global.HealthCatchGavinL.My.Resources.Resources.smallkit
        Me.picKit.Location = New System.Drawing.Point(314, 209)
        Me.picKit.Name = "picKit"
        Me.picKit.Size = New System.Drawing.Size(69, 90)
        Me.picKit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKit.TabIndex = 1
        Me.picKit.TabStop = False
        '
        'lblTimeRemaining
        '
        Me.lblTimeRemaining.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.lblTimeRemaining.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeRemaining.Location = New System.Drawing.Point(659, 34)
        Me.lblTimeRemaining.Name = "lblTimeRemaining"
        Me.lblTimeRemaining.Size = New System.Drawing.Size(83, 65)
        Me.lblTimeRemaining.TabIndex = 3
        Me.lblTimeRemaining.Text = "0"
        Me.lblTimeRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrTimeLimit
        '
        Me.tmrTimeLimit.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(754, 500)
        Me.Controls.Add(Me.lblTimeRemaining)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picKit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Health Kit Catch"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picKit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiffucultyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EasyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModerateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsaneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgrammerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picKit As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents tmrKitMove As Timer
    Friend WithEvents lblTimeRemaining As Label
    Friend WithEvents tmrTimeLimit As Timer
End Class
