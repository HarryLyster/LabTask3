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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnFight = New System.Windows.Forms.Button()
        Me.btnMath = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblHP = New System.Windows.Forms.Label()
        Me.lblGold = New System.Windows.Forms.Label()
        Me.lblEnemy = New System.Windows.Forms.Label()
        Me.lblMath = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.grpMath = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpMath.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFight
        '
        Me.btnFight.Location = New System.Drawing.Point(50, 309)
        Me.btnFight.Name = "btnFight"
        Me.btnFight.Size = New System.Drawing.Size(178, 48)
        Me.btnFight.TabIndex = 0
        Me.btnFight.Text = "Fight"
        Me.btnFight.UseVisualStyleBackColor = True
        '
        'btnMath
        '
        Me.btnMath.Location = New System.Drawing.Point(274, 309)
        Me.btnMath.Name = "btnMath"
        Me.btnMath.Size = New System.Drawing.Size(178, 48)
        Me.btnMath.TabIndex = 1
        Me.btnMath.Text = "Math"
        Me.btnMath.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(50, 371)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(178, 48)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblHP
        '
        Me.lblHP.AutoSize = True
        Me.lblHP.Location = New System.Drawing.Point(28, 36)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(31, 20)
        Me.lblHP.TabIndex = 3
        Me.lblHP.Text = "HP"
        '
        'lblGold
        '
        Me.lblGold.AutoSize = True
        Me.lblGold.Location = New System.Drawing.Point(28, 83)
        Me.lblGold.Name = "lblGold"
        Me.lblGold.Size = New System.Drawing.Size(55, 20)
        Me.lblGold.TabIndex = 4
        Me.lblGold.Text = "GOLD"
        '
        'lblEnemy
        '
        Me.lblEnemy.AutoSize = True
        Me.lblEnemy.Location = New System.Drawing.Point(28, 130)
        Me.lblEnemy.Name = "lblEnemy"
        Me.lblEnemy.Size = New System.Drawing.Size(66, 20)
        Me.lblEnemy.TabIndex = 5
        Me.lblEnemy.Text = "ENEMY"
        '
        'lblMath
        '
        Me.lblMath.AutoSize = True
        Me.lblMath.Location = New System.Drawing.Point(28, 177)
        Me.lblMath.Name = "lblMath"
        Me.lblMath.Size = New System.Drawing.Size(54, 20)
        Me.lblMath.TabIndex = 6
        Me.lblMath.Text = "MATH"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(28, 224)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(73, 20)
        Me.lblResult.TabIndex = 7
        Me.lblResult.Text = "RESULT"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(165, 265)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(178, 38)
        Me.txtAnswer.TabIndex = 8
        '
        'grpMath
        '
        Me.grpMath.BackColor = System.Drawing.Color.Transparent
        Me.grpMath.Controls.Add(Me.PictureBox1)
        Me.grpMath.Location = New System.Drawing.Point(12, 36)
        Me.grpMath.Name = "grpMath"
        Me.grpMath.Size = New System.Drawing.Size(474, 247)
        Me.grpMath.TabIndex = 9
        Me.grpMath.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(131, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(327, 209)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(498, 33)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Menu
        '
        Me.Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.StoreToolStripMenuItem})
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(69, 29)
        Me.Menu.Text = "Menu"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StoreToolStripMenuItem
        '
        Me.StoreToolStripMenuItem.Name = "StoreToolStripMenuItem"
        Me.StoreToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.StoreToolStripMenuItem.Text = "Store"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(274, 371)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 48)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Rate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(498, 431)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblMath)
        Me.Controls.Add(Me.lblEnemy)
        Me.Controls.Add(Me.lblGold)
        Me.Controls.Add(Me.lblHP)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnMath)
        Me.Controls.Add(Me.btnFight)
        Me.Controls.Add(Me.grpMath)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpMath.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFight As Button
    Friend WithEvents btnMath As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblHP As Label
    Friend WithEvents lblGold As Label
    Friend WithEvents lblEnemy As Label
    Friend WithEvents lblMath As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents grpMath As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Menu As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
