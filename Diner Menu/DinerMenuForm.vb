'Zachary Christensen
'RCET 2265
'Fall 2023
'Diner Menu
'https://github.com/Minidude140/DinerMenu.git
Public Class DinerMenuForm
    'Custom Methods
    Sub SetDefault()
        DailySpecialsLabel.Text = "Welcome"
    End Sub
    Sub DisplaySoup()
        DailySpecialsLabel.Text = "Soup"
    End Sub
    Sub DisplaySalad()
        DailySpecialsLabel.Text = "Salad"
    End Sub
    Sub DisplayFish()
        DailySpecialsLabel.Text = "Fish"
    End Sub
    'Event Handlers
    Private Sub DinerMenuForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefault()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
