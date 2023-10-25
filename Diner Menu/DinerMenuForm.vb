'Zachary Christensen
'RCET 2265
'Fall 2023
'Diner Menu
'https://github.com/Minidude140/DinerMenu.git
Public Class DinerMenuForm
    'Custom Methods
    ''' <summary>
    ''' Updates DailySpecialLabel text to the welcome screen
    ''' </summary>
    Sub SetDefault()
        DailySpecialsLabel.Text = "~Welcome to 'Diner Name'~" & vbCrLf & vbCrLf &
        "Please select from our daily options of Soup, Salad, and Fish"
    End Sub

    ''' <summary>
    ''' Updates DailySpecialLabel text to the Soup menu
    ''' </summary>
    Sub DisplaySoup()
        DailySpecialsLabel.Text = "Soup"
    End Sub

    ''' <summary>
    ''' Updates DailySpecialLabel text to the Salad menu
    ''' </summary>
    Sub DisplaySalad()
        DailySpecialsLabel.Text = "Salad"
    End Sub

    ''' <summary>
    ''' Updates DailySpecialLabel text to the Fish menu
    ''' </summary>
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

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySoup()
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySalad()
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplayFish()
    End Sub
End Class
