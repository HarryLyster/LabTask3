
Public Class Form1
        Dim playerHP As Integer = 10 'initialize player hit points to 10
        Dim playerGold As Integer = 10 'initialize player gold to 10
        Dim currentEnemyHP As Integer 'initialize current enemy hit points variable
        Dim currentEnemyDamage As Integer 'initialize current enemy damage variable
    Dim currentEnemyName As String 'initialize current enemy name variable
    Dim num1 As Integer
    Dim num2 As Integer
    Dim answer As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            lblHP.Text = "HP: " & playerHP 'update player HP label
            lblGold.Text = "Gold: " & playerGold 'update player gold label
        End Sub

        Private Sub btnFight_Click(sender As Object, e As EventArgs) Handles btnFight.Click
            'generate a random enemy
            Dim enemyIndex As Integer = Int(Rnd() * 3) 'generate a random number between 0 and 2
            Select Case enemyIndex
                Case 0
                    currentEnemyName = "Goblin"
                    currentEnemyHP = 5
                    currentEnemyDamage = 2
                Case 1
                    currentEnemyName = "Skeleton"
                    currentEnemyHP = 8
                    currentEnemyDamage = 3
                Case 2
                    currentEnemyName = "Orc"
                    currentEnemyHP = 12
                    currentEnemyDamage = 4
            End Select

            'update enemy label
            lblEnemy.Text = currentEnemyName & " HP: " & currentEnemyHP

        'disable fight button and enable math button
        btnMath.Enabled = True
        btnSubmit.Enabled = False
        btnFight.Enabled = False
    End Sub

        Private Sub btnMath_Click(sender As Object, e As EventArgs) Handles btnMath.Click
        'generate a math problem for the player to solve
        num1 = Int(Rnd() * 10) + 1 'generate a random number between 1 and 10
        num2 = Int(Rnd() * 10) + 1 'generate a second random number between 1 and 10
        answer = num1 + num2 'calculate the correct answer

        lblMath.Text = "What is " & num1 & " + " & num2 & "?"

        'disable fight button and enable math button
        btnMath.Enabled = False
        btnSubmit.Enabled = True
        btnMath.Enabled = False

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'check if the player's answer is correct
        If txtAnswer.Text = (answer) Then
            'player dealt damage to enemy
            currentEnemyHP = currentEnemyHP - 5 'reduce the enemy's hit points by 5
            lblResult.Text = "You dealt 5 damage to the " & currentEnemyName & "!"
            If currentEnemyHP <= 0 Then
                'enemy defeated
                lblResult.Text = "You defeated the " & currentEnemyName & "!"
                playerGold = playerGold + 5 'give the player 5 gold
                lblGold.Text = "Gold: " & playerGold 'update player gold label
                grpMath.Visible = False 'hide math group box
                btnFight.Enabled = True 'enable fight button
                btnMath.Enabled = False 'disable math button
                lblEnemy.Text = "You win" 'clear enemy label

            End If

        Else
            'player missed
            lblResult.Text = "You missed the " & currentEnemyName & "!"
            'enemy
        End If

        'disable fight button and enable math button
        btnFight.Enabled = False
        btnMath.Enabled = True
        PictureBox1.Visible = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub StoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StoreToolStripMenuItem.Click
        Store.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim response As Integer = MessageBox.Show("How would you rate this game?", "Rate Game", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        'check the user's response and display an appropriate message
        Select Case response
            Case DialogResult.Yes
                'display an input box asking the user to enter a rating out of 10
                Dim rating As String = InputBox("Enter a rating out of 10:", "Rate Game", "0")
                If IsNumeric(rating) And rating >= 0 And rating <= 10 Then
                    MessageBox.Show("Thank you for rating the game " & rating & " out of 10!", "Rate Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Invalid rating entered.", "Rate Game", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Case DialogResult.No
                MessageBox.Show("We're sorry to hear that you didn't enjoy the game.", "Rate Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case DialogResult.Cancel
                'do nothing
        End Select
    End Sub
End Class
