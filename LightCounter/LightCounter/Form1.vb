Public Class MainForm
    'Declare variables to hold counts of the # of lights that are currently on/off
    Dim NumLightsOn As UInt16 = 0
    Dim NumLightsOff As UInt16 = 16

    'Click event handler which handles turning on/off all "Lights" and changing counter values.
    Private Sub Light_Click(sender As Object, e As EventArgs) Handles Light1.Click, Light2.Click, Light3.Click, Light4.Click, Light5.Click, Light6.Click,
        Light7.Click, Light8.Click, Light9.Click, Light10.Click, Light11.Click, Light12.Click, Light13.Click, Light14.Click, Light15.Click, Light16.Click
        'Using the button clicked by the user
        With DirectCast(sender, Button)
            'If the button is currently "on"
            If .BackColor = Color.FromArgb(255, 204, 0) Then
                'Turn the button "off"
                .BackColor = Color.FromKnownColor(KnownColor.ControlLight)
                'Decrement the number of lights "on"
                NumLightsOn -= 1
                'Increment the number of lights turned "off"
                NumLightsOff += 1
            Else
                'If the light is "off" then turn the light "on"
                .BackColor = Color.FromArgb(255, 204, 0)
                'Increment the number of lights that are turned "on"
                NumLightsOn += 1
                'Decrement the number of lights that are turned "off"
                NumLightsOff -= 1
            End If
        End With
        'Set counters to string representations of the incremented/decremented int values
        LightsOnCounter.Text = NumLightsOn.ToString
        LightsOffCounter.Text = NumLightsOff.ToString
    End Sub
End Class
