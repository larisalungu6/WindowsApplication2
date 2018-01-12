Public Class Form1
    Dim up_down_mover = 5
    Dim Left_right_mover = 5
    Dim LeftMove As Integer = 5
    Dim Invader(6) As PictureBox
    Dim invaderLife(6) As Boolean
    Dim direct As Integer



    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.Left

                Left_right_mover = -5
                up_down_mover = 0
                direct = 1

            Case Keys.Right
                Left_right_mover = 5
                up_down_mover = 0
                direct = 2

            Case Keys.Up
                up_down_mover = -5
                Left_right_mover = 0
                direct = 3

            Case Keys.Down
                up_down_mover = 5
                Left_right_mover = 0
                direct = 4
                Timer1.Start()
            Case PicBullet.Location = New System.Drawing.Point(Spaceship.Left + ((Spaceship.Width) / 2), Spaceship.Top)
                Timer2.Stop()
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Invader(1) = PicInvader1
        Invader(2) = PicInvader2
        Invader(3) = PicInvader3
        Invader(4) = PicInvader4
        Invader(5) = PicInvader5
        Invader(6) = PicInvader6

        For j = 1 To 6
            invaderLife(j) = True
        Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Spaceship.Top += up_down_mover
        Spaceship.Left += Left_right_mover
        For j = 1 To 6
            If invaderLife(j) Then
                Invader(j).Left += LeftMove
                If Invader(j).Left > 1000 Then
                    LeftMove *= -1
                End If
                If Invader(j).Left < 10 Then
                    LeftMove *= -1
                    Invader(j).Left = 11
                End If
            End If
        Next
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        PicBullet.Top -= 5
        If PicBullet.Top <= 5 Then
            Timer2.Stop()
            PicBullet.Top = 500

        End If
        If PicBullet.Bounds.IntersectsWith(PicInvader1.Bounds) Then
            PicInvader1.Location = New System.Drawing.Point(12, 500)
            invaderLife(1) = False
            PicBullet.Top = 500
            Timer2.Stop()
        End If
        If PicBullet.Bounds.IntersectsWith(PicInvader2.Bounds) Then
            PicInvader2.Location = New System.Drawing.Point(12, 500)
            invaderLife(2) = False
            PicBullet.Top = 500
            Timer2.Stop()
        End If
        If PicBullet.Bounds.IntersectsWith(PicInvader3.Bounds) Then
            PicInvader3.Location = New System.Drawing.Point(12, 500)
            invaderLife(3) = False
            PicBullet.Top = 500
            Timer2.Stop()
        End If
        If PicBullet.Bounds.IntersectsWith(PicInvader4.Bounds) Then
            PicInvader4.Location = New System.Drawing.Point(12, 500)
            invaderLife(4) = False
            PicBullet.Top = 500
            Timer2.Stop()
        End If
        If PicBullet.Bounds.IntersectsWith(PicInvader5.Bounds) Then
            PicInvader5.Location = New System.Drawing.Point(12, 500)
            invaderLife(5) = False
            PicBullet.Top = 500
            Timer2.Stop()
        End If
        If PicBullet.Bounds.IntersectsWith(PicInvader6.Bounds) Then
            PicInvader6.Location = New System.Drawing.Point(12, 500)
            invaderLife(6) = False
            PicBullet.Top = 500
            Timer2.Stop()
        End If
    End Sub
End Class


