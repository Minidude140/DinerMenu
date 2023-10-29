'Zachary Christensen
'RCET 2265
'Fall 2023
'Diner Menu
'https://github.com/Minidude140/DinerMenu.git
'Extra References:
'https://starwars.fandom.com/wiki/Category:Food_at_Dex%27s_Diner

Public Class DinerMenuForm
    'Custom Methods
    ''' <summary>
    ''' Updates DailySpecialLabel text to the welcome screen
    ''' </summary>
    Sub SetDefault()
        DailySpecialsLabel.Text = "~Welcome to Dex's Diner~" & vbCrLf & vbCrLf &
            "Take a seat I'll be right with ya" & vbCrLf & vbCrLf &
        "Please select from Dex's daily options of Soup, Salad, and Fish"
    End Sub

    ''' <summary>
    ''' Updates DailySpecialLabel text to the Soup menu
    ''' </summary>
    Sub DisplaySoup()
        DailySpecialsLabel.Text = "~Soup of the Day~" & vbCrLf & vbCrLf &
        "Creamed Rishi corn soup:" & vbCrLf &
        "Our Rishi corn comes straight from the Outer Rim weekly, where we locally cream it here at Dex's Diner" & vbCrLf &
        "-1.7 Credits"
    End Sub

    ''' <summary>
    ''' Updates DailySpecialLabel text to the Salad menu
    ''' </summary>
    Sub DisplaySalad()
        DailySpecialsLabel.Text = "~Salad of the Day~" & vbCrLf & vbCrLf &
        "Xizor Salad:" & vbCrLf &
        "Fresh laser-cut Sizhranian lettuce tossed with Hocekureem Sea salt croutons" & vbCrLf &
        "- 7.7 credits"
    End Sub

    ''' <summary>
    ''' Updates DailySpecialLabel text to the Fish menu
    ''' </summary>
    Sub DisplayFish()
        DailySpecialsLabel.Text = "~Fresh Fish~" & vbCrLf & vbCrLf &
        "Rokarian dirt-fish fillets:" & vbCrLf &
        "These little fish from the Rokaria System are much more appetizing than their name suggests" & vbCrLf &
        "-6.1 Credits"
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
