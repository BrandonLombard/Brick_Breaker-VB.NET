Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ball_moving.Enabled = True
        ballupleft.Enabled = False
        ballupright.Enabled = False
        balldownright.Enabled = False
        balldownleft.Enabled = False
        collision_detection.Enabled = True
    End Sub

    Private Sub user_KeyDown(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.A Then
            player_left.Location = New Point(player_left.Location.X - 5, player_left.Location.Y - 0)
            player_right.Location = New Point(player_right.Location.X - 5, player_right.Location.Y - 0)
        ElseIf e.KeyCode = Keys.D Then
            player_left.Location = New Point(player_left.Location.X + 5, player_left.Location.Y - 0)
            player_right.Location = New Point(player_right.Location.X + 5, player_right.Location.Y - 0)
        End If
    End Sub

    Private Sub ball_moving_Tick(sender As Object, e As EventArgs) Handles ball_moving.Tick
        'If  ball touches any of these blocks, it bounces off.

        If (ball.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox2.Bounds) And PictureBox2.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox3.Bounds) And PictureBox3.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox4.Bounds) And PictureBox4.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox5.Bounds) And PictureBox5.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox6.Bounds) And PictureBox6.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox7.Bounds) And PictureBox7.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox8.Bounds) And PictureBox8.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox9.Bounds) And PictureBox9.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox10.Bounds) And PictureBox10.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox11.Bounds) And PictureBox11.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox12.Bounds) And PictureBox12.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox13.Bounds) And PictureBox13.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox14.Bounds) And PictureBox14.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox15.Bounds) And PictureBox15.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox16.Bounds) And PictureBox16.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox17.Bounds) And PictureBox17.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox18.Bounds) And PictureBox18.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox19.Bounds) And PictureBox19.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox20.Bounds) And PictureBox20.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox21.Bounds) And PictureBox21.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox22.Bounds) And PictureBox22.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox23.Bounds) And PictureBox23.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox24.Bounds) And PictureBox24.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox25.Bounds) And PictureBox25.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox26.Bounds) And PictureBox26.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox27.Bounds) And PictureBox27.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox28.Bounds) And PictureBox28.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox29.Bounds) And PictureBox29.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox30.Bounds) And PictureBox30.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox31.Bounds) And PictureBox31.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox32.Bounds) And PictureBox32.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox33.Bounds) And PictureBox33.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox34.Bounds) And PictureBox34.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox35.Bounds) And PictureBox35.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox36.Bounds) And PictureBox36.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox37.Bounds) And PictureBox37.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox38.Bounds) And PictureBox38.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox39.Bounds) And PictureBox39.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox40.Bounds) And PictureBox40.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox41.Bounds) And PictureBox41.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox42.Bounds) And PictureBox42.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox43.Bounds) And PictureBox43.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox44.Bounds) And PictureBox44.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox45.Bounds) And PictureBox45.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox46.Bounds) And PictureBox46.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox47.Bounds) And PictureBox47.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox48.Bounds) And PictureBox48.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox49.Bounds) And PictureBox49.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox50.Bounds) And PictureBox50.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox51.Bounds) And PictureBox51.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox52.Bounds) And PictureBox52.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox53.Bounds) And PictureBox53.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox54.Bounds) And PictureBox54.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox55.Bounds) And PictureBox55.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox56.Bounds) And PictureBox56.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox57.Bounds) And PictureBox57.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox58.Bounds) And PictureBox58.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox59.Bounds) And PictureBox59.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox60.Bounds) And PictureBox60.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox61.Bounds) And PictureBox61.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox62.Bounds) And PictureBox62.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox63.Bounds) And PictureBox63.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox64.Bounds) And PictureBox64.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox65.Bounds) And PictureBox65.Visible = True) _
            Or (ball.Bounds.IntersectsWith(PictureBox66.Bounds) And PictureBox66.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox67.Bounds) And PictureBox67.Visible = True) Or (ball.Bounds.IntersectsWith(PictureBox68.Bounds) And PictureBox68.Visible = True) Then

            score.Text = score.Text + 1

            If game.Text = "started" Then
                balldownleft.Enabled = True
                game.Text = "playing"
            ElseIf balldownright.Enabled = True Then
                balldownleft.Enabled = True
                balldownright.Enabled = False
            ElseIf balldownleft.Enabled = True Then
                balldownright.Enabled = True
                balldownleft.Enabled = False
            ElseIf ballupright.Enabled = True Then
                balldownright.Enabled = True
                ballupright.Enabled = False
            ElseIf ballupleft.Enabled = True Then
                ballupright.Enabled = True
                ballupleft.Enabled = False
            End If
        ElseIf game.Text = "started" Then
            ballupleft.Enabled = True
        End If

    End Sub

    Private Sub balldownleft_Tick(sender As Object, e As EventArgs) Handles balldownleft.Tick
        ballupleft.Enabled = False
        balldownright.Enabled = False
        ballupright.Enabled = False
        ball.Location = New Point(ball.Location.X - 5, ball.Location.Y + 5)
        If ball.Bounds.IntersectsWith(left_border.Bounds) Then
            balldownright.Enabled = True
            balldownleft.Enabled = False
        End If
    End Sub

    Private Sub balldownright_Tick(sender As Object, e As EventArgs) Handles balldownright.Tick
        ballupleft.Enabled = False
        balldownleft.Enabled = False
        ballupright.Enabled = False
        ball.Location = New Point(ball.Location.X + 5, ball.Location.Y + 5)
        If ball.Bounds.IntersectsWith(right_border.Bounds) Then
            balldownleft.Enabled = True
            balldownright.Enabled = False
        End If
    End Sub

    Private Sub ballupright_Tick(sender As Object, e As EventArgs) Handles ballupright.Tick
        ballupleft.Enabled = False
        balldownright.Enabled = False
        balldownright.Enabled = False
        ball.Location = New Point(ball.Location.X + 5, ball.Location.Y - 5)
        If ball.Bounds.IntersectsWith(right_border.Bounds) Then
            ballupleft.Enabled = True
            ballupright.Enabled = False
        ElseIf ball.Bounds.IntersectsWith(top_border.Bounds) Then
            balldownright.Enabled = True
            ballupright.Enabled = False
        End If

    End Sub

    Private Sub ballupleft_Tick(sender As Object, e As EventArgs) Handles ballupleft.Tick
        balldownleft.Enabled = False
        balldownright.Enabled = False
        ballupright.Enabled = False
        ball.Location = New Point(ball.Location.X - 5, ball.Location.Y - 5)
        If ball.Bounds.IntersectsWith(left_border.Bounds) Then
            ballupright.Enabled = True
            ballupleft.Enabled = False
        ElseIf ball.Bounds.IntersectsWith(top_border.Bounds) Then
            balldownleft.Enabled = True
            ballupleft.Enabled = False
        End If
    End Sub

    Private Sub collision_detection_Tick(sender As Object, e As EventArgs) Handles collision_detection.Tick

        If ball.Bounds.IntersectsWith(border_bottom.Bounds) Then
            lives.Text = lives.Text - 1

        End If

        'If ball collides with player
        If ball.Bounds.IntersectsWith(player_left.Bounds) Then
            ballupleft.Enabled = True
        ElseIf ball.Bounds.IntersectsWith(player_right.Bounds) Then
            ballupright.Enabled = True
        End If
        'PictureBox1 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox1.Bounds) Then
            If PictureBox1.BackColor = Color.DarkRed Then
                PictureBox1.Visible = False
            End If
        End If

        'PictureBox2 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            If PictureBox2.BackColor = Color.DarkRed Then
                PictureBox2.Visible = False
            End If
        End If

        'PictureBox3 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox3.Bounds) Then
            If PictureBox3.BackColor = Color.DarkRed Then
                PictureBox3.Visible = False
            End If
        End If

        'PictureBox4 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox4.Bounds) Then
            If PictureBox4.BackColor = Color.DarkRed Then
                PictureBox4.Visible = False
            End If
        End If

        'PictureBox5 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox5.Bounds) Then
            If PictureBox5.BackColor = Color.DarkRed Then
                PictureBox5.Visible = False
            End If
        End If

        'PictureBox6 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            If PictureBox6.BackColor = Color.DarkRed Then
                PictureBox6.Visible = False
            End If
        End If

        'PictureBox7 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox7.Bounds) Then
            If PictureBox7.BackColor = Color.DarkRed Then
                PictureBox7.Visible = False
            End If
        End If

        'PictureBox8 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            If PictureBox8.BackColor = Color.DarkRed Then
                PictureBox8.Visible = False
            End If
        End If

        'PictureBox9 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox9.Bounds) Then
            If PictureBox9.BackColor = Color.DarkRed Then
                PictureBox9.Visible = False
            End If
        End If

        'PictureBox10 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox10.Bounds) Then
            If PictureBox10.BackColor = Color.DarkRed Then
                PictureBox10.Visible = False
            End If
        End If

        'PictureBox11 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox11.Bounds) Then
            If PictureBox11.BackColor = Color.DarkRed Then
                PictureBox11.Visible = False
            End If
        End If

        'PictureBox12 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox12.Bounds) Then
            If PictureBox12.BackColor = Color.DarkRed Then
                PictureBox12.Visible = False
            End If
        End If

        'PictureBox13 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox13.Bounds) Then
            If PictureBox13.BackColor = Color.DarkRed Then
                PictureBox13.Visible = False
            End If
        End If

        'PictureBox14 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox14.Bounds) Then
            If PictureBox14.BackColor = Color.DarkRed Then
                PictureBox14.Visible = False
            End If
        End If

        'PictureBox15 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox15.Bounds) Then
            If PictureBox15.BackColor = Color.DarkRed Then
                PictureBox15.Visible = False
            End If
        End If

        'PictureBox16 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox16.Bounds) Then
            If PictureBox16.BackColor = Color.DarkRed Then
                PictureBox16.Visible = False
            End If
        End If

        'PictureBox17 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox17.Bounds) Then
            If PictureBox17.BackColor = Color.DarkRed Then
                PictureBox17.Visible = False
            End If
        End If

        'PictureBox18 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox18.Bounds) Then
            If PictureBox18.BackColor = Color.DarkRed Then
                PictureBox18.Visible = False
            End If
        End If

        'PictureBox19 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox19.Bounds) Then
            If PictureBox19.BackColor = Color.DarkRed Then
                PictureBox19.Visible = False
            End If
        End If

        'PictureBox20 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox20.Bounds) Then
            If PictureBox20.BackColor = Color.DarkRed Then
                PictureBox20.Visible = False
            End If
        End If

        'PictureBox21 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox21.Bounds) Then
            If PictureBox21.BackColor = Color.DarkRed Then
                PictureBox21.Visible = False
            End If
        End If

        'PictureBox22 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox22.Bounds) Then
            If PictureBox22.BackColor = Color.DarkRed Then
                PictureBox22.Visible = False
            End If
        End If

        'PictureBox23 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox23.Bounds) Then
            If PictureBox23.BackColor = Color.DarkRed Then
                PictureBox23.Visible = False
            End If
        End If

        'PictureBox24 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox24.Bounds) Then
            If PictureBox24.BackColor = Color.DarkRed Then
                PictureBox24.Visible = False
            End If
        End If

        'PictureBox25 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox25.Bounds) Then
            If PictureBox25.BackColor = Color.DarkRed Then
                PictureBox25.Visible = False
            End If
        End If

        'PictureBox26 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox26.Bounds) Then
            If PictureBox26.BackColor = Color.DarkRed Then
                PictureBox26.Visible = False
            End If
        End If

        'PictureBox27 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox27.Bounds) Then
            If PictureBox27.BackColor = Color.DarkRed Then
                PictureBox27.Visible = False
            End If
        End If

        'PictureBox28 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox28.Bounds) Then
            If PictureBox28.BackColor = Color.DarkRed Then
                PictureBox28.Visible = False
            End If
        End If

        'PictureBox29 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox29.Bounds) Then
            If PictureBox29.BackColor = Color.DarkRed Then
                PictureBox29.Visible = False
            End If
        End If

        'PictureBox30 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox30.Bounds) Then
            If PictureBox30.BackColor = Color.DarkRed Then
                PictureBox30.Visible = False
            End If
        End If

        'PictureBox31 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox31.Bounds) Then
            If PictureBox31.BackColor = Color.DarkRed Then
                PictureBox31.Visible = False
            End If
        End If

        'PictureBox32 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox32.Bounds) Then
            If PictureBox32.BackColor = Color.DarkRed Then
                PictureBox32.Visible = False
            End If
        End If

        'PictureBox33 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox33.Bounds) Then
            If PictureBox33.BackColor = Color.DarkRed Then
                PictureBox33.Visible = False
            End If
        End If

        'PictureBox34 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox34.Bounds) Then
            If PictureBox34.BackColor = Color.DarkRed Then
                PictureBox34.Visible = False
            End If
        End If

        'PictureBox35 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox35.Bounds) Then
            If PictureBox35.BackColor = Color.DarkRed Then
                PictureBox35.Visible = False
            End If
        End If

        'PictureBox36 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox36.Bounds) Then
            If PictureBox36.BackColor = Color.DarkRed Then
                PictureBox36.Visible = False
            End If
        End If

        'PictureBox37 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox37.Bounds) Then
            If PictureBox37.BackColor = Color.DarkRed Then
                PictureBox37.Visible = False
            End If
        End If

        'PictureBox38 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox38.Bounds) Then
            If PictureBox38.BackColor = Color.DarkRed Then
                PictureBox38.Visible = False
            End If
        End If

        'PictureBox39 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox39.Bounds) Then
            If PictureBox39.BackColor = Color.DarkRed Then
                PictureBox39.Visible = False
            End If
        End If

        'PictureBox40 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox40.Bounds) Then
            If PictureBox40.BackColor = Color.DarkRed Then
                PictureBox40.Visible = False
            End If
        End If

        'PictureBox41 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox41.Bounds) Then
            If PictureBox41.BackColor = Color.DarkRed Then
                PictureBox41.Visible = False
            End If
        End If

        'PictureBox42 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox42.Bounds) Then
            If PictureBox42.BackColor = Color.DarkRed Then
                PictureBox42.Visible = False
            End If
        End If

        'PictureBox43 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox43.Bounds) Then
            If PictureBox43.BackColor = Color.DarkRed Then
                PictureBox43.Visible = False
            End If
        End If

        'PictureBox44 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox44.Bounds) Then
            If PictureBox44.BackColor = Color.DarkRed Then
                PictureBox44.Visible = False
            End If
        End If

        'PictureBox45 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox45.Bounds) Then
            If PictureBox45.BackColor = Color.DarkRed Then
                PictureBox45.Visible = False
            End If
        End If

        'PictureBox46 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox46.Bounds) Then
            If PictureBox46.BackColor = Color.DarkRed Then
                PictureBox46.Visible = False
            End If
        End If

        'PictureBox47 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox47.Bounds) Then
            If PictureBox47.BackColor = Color.DarkRed Then
                PictureBox47.Visible = False
            End If
        End If

        'PictureBox48 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox48.Bounds) Then
            If PictureBox48.BackColor = Color.DarkRed Then
                PictureBox48.Visible = False
            End If
        End If

        'PictureBox49 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox49.Bounds) Then
            If PictureBox49.BackColor = Color.DarkRed Then
                PictureBox49.Visible = False
            End If
        End If

        'PictureBox50 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox50.Bounds) Then
            If PictureBox50.BackColor = Color.DarkRed Then
                PictureBox50.Visible = False
            End If
        End If

        'PictureBox51 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox51.Bounds) Then
            If PictureBox51.BackColor = Color.DarkRed Then
                PictureBox51.Visible = False
            End If
        End If

        'PictureBox52 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox52.Bounds) Then
            If PictureBox52.BackColor = Color.DarkRed Then
                PictureBox52.Visible = False
            End If
        End If

        'PictureBox53 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox53.Bounds) Then
            If PictureBox53.BackColor = Color.DarkRed Then
                PictureBox53.Visible = False
            End If
        End If

        'PictureBox54 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox54.Bounds) Then
            If PictureBox54.BackColor = Color.DarkRed Then
                PictureBox54.Visible = False
            End If
        End If

        'PictureBox55 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox55.Bounds) Then
            If PictureBox55.BackColor = Color.DarkRed Then
                PictureBox55.Visible = False
            End If
        End If

        'PictureBox56 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox56.Bounds) Then
            If PictureBox56.BackColor = Color.DarkRed Then
                PictureBox56.Visible = False
            End If
        End If

        'PictureBox57 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox57.Bounds) Then
            If PictureBox57.BackColor = Color.DarkRed Then
                PictureBox57.Visible = False
            End If
        End If

        'PictureBox58 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox58.Bounds) Then
            If PictureBox58.BackColor = Color.DarkRed Then
                PictureBox58.Visible = False
            End If
        End If

        'PictureBox59 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox59.Bounds) Then
            If PictureBox59.BackColor = Color.DarkRed Then
                PictureBox59.Visible = False
            End If
        End If

        'PictureBox60 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox60.Bounds) Then
            If PictureBox60.BackColor = Color.DarkRed Then
                PictureBox60.Visible = False
            End If
        End If

        'PictureBox61 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox61.Bounds) Then
            If PictureBox61.BackColor = Color.DarkRed Then
                PictureBox61.Visible = False
            End If
        End If

        'PictureBox62 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox62.Bounds) Then
            If PictureBox62.BackColor = Color.DarkRed Then
                PictureBox62.Visible = False
            End If
        End If

        'PictureBox63 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox63.Bounds) Then
            If PictureBox63.BackColor = Color.DarkRed Then
                PictureBox63.Visible = False
            End If
        End If

        'PictureBox64 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox64.Bounds) Then
            If PictureBox64.BackColor = Color.DarkRed Then
                PictureBox64.Visible = False
            End If
        End If

        'PictureBox65 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox65.Bounds) Then
            If PictureBox65.BackColor = Color.DarkRed Then
                PictureBox65.Visible = False
            End If
        End If
        'PictureBox66 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox66.Bounds) Then
            If PictureBox66.BackColor = Color.DarkRed Then
                PictureBox66.Visible = False
            End If
        End If

        'PictureBox67 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox67.Bounds) Then
            If PictureBox67.BackColor = Color.DarkRed Then
                PictureBox67.Visible = False
            End If
        End If

        'PictureBox68 On Collision deletion
        If ball.Bounds.IntersectsWith(PictureBox68.Bounds) Then
            If PictureBox68.BackColor = Color.DarkRed Then
                PictureBox68.Visible = False
            End If
        End If





    End Sub
End Class
