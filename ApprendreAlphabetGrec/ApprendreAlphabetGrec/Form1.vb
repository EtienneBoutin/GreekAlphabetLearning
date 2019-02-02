Public Class Form1
    Dim LastValue As Integer = 100
    Dim OriginalLettersArrayGreek(24) As Integer
    Dim OriginalLettersArrayGreek2(24) As Integer

    Dim OriginalLettersArrayFrench(24) As Integer
    Dim OriginalLettersArrayFrench2(24) As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel2.Visible = True
        Panel1.Visible = False

        Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        EnableButtons(False)
        Label1.ForeColor = Color.White
        Label1.Visible = False
        Label2.ForeColor = Color.White
        Label2.Visible = False
        OriginalGreekLettersLocation()
        OriginalFrenchLettersLocation()
        RadioButton1.Checked = True
        RadioButton3.Checked = True
        PictureBox1.Image = ImageList1.Images.Item(RandomImage())
        PictureBox2.Image = PictureBox1.Image


    End Sub

    Private Function RandomImage()
        ' Initialize the random-number generator.
        Dim RandomValue As Integer
        Randomize()
        ' Generate random value between 1 and 48.
        RandomValue = CInt(Int((48 * Rnd()) + 1))
        While LastValue = RandomValue
            RandomValue = CInt(Int((48 * Rnd()) + 1))

        End While
        LastValue = RandomValue

        If Panel1.Visible = True And RadioButton2.Checked = True Then
            MixLetters()
        ElseIf Panel2.Visible = True And RadioButton4.Checked = True Then
            MixLettersFrench()
        End If

        EnableButtons(True)

        Return Randomvalue - 1
    End Function

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button26.Click, Button27.Click, Button28.Click, Button29.Click, Button30.Click, Button31.Click, Button32.Click, Button33.Click, Button34.Click, Button35.Click, Button36.Click, Button37.Click, Button38.Click, Button39.Click, Button40.Click, Button41.Click, Button42.Click, Button43.Click, Button44.Click, Button45.Click, Button46.Click, Button47.Click, Button48.Click, Button1.Click
        EnableButtons(False)
        Dim ButtonClicked As Button = sender
        Dim LetterClicked As String = ButtonClicked.Text.ToLower
        Dim MinusculeMajuscule As String
        If InStr(ImageList1.Images.Keys(LastValue - 1).ToString, "_U.jpg") <> 0 Then
            MinusculeMajuscule = " majuscule"
        Else
            MinusculeMajuscule = " minuscule"
        End If
        Dim GreekLetter As String = ImageList1.Images.Keys(LastValue - 1).ToString.Replace("_U.jpg", "").Replace("_L.jpg", "").ToLower

        If GreekLetter = LetterClicked Then
            Label2.BackColor = Color.Green
            Label2.Text = "Bravo ! La lettre est bien " & LetterClicked & MinusculeMajuscule
        Else
            Label2.BackColor = Color.Red
            Label2.Text = "Oups ! La lettre est " & GreekLetter & MinusculeMajuscule
        End If
        Label2.Visible = True
        Timer1.Start()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles sigma.Click, bêta.Click, gamma.Click, delta.Click, thêta.Click, êta.Click, zêta.Click, epsilon.Click, alpha.Click, nu.Click, iota.Click, pi.Click, omicron.Click, ksi.Click, mu.Click, lambda.Click, kappa.Click, phi.Click, rho.Click, omêga.Click, psi.Click, khi.Click, upsilon.Click, tau.Click
        EnableButtons(False)
        Dim ButtonClicked As Button = sender
        Dim LetterClicked As String = ButtonClicked.Name.ToLower
        Dim MinusculeMajuscule As String
        If InStr(ImageList1.Images.Keys(LastValue - 1).ToString, "_U.jpg") <> 0 Then
            MinusculeMajuscule = " majuscule"
        Else
            MinusculeMajuscule = " minuscule"
        End If
        Dim GreekLetter As String = ImageList1.Images.Keys(LastValue - 1).ToString.Replace("_U.jpg", "").Replace("_L.jpg", "").ToLower

        If GreekLetter = LetterClicked Then
            Label1.BackColor = Color.Green
            Label1.Text = "Bravo ! La lettre est bien " & LetterClicked & MinusculeMajuscule
        Else
            Label1.BackColor = Color.Red
            Label1.Text = "Oups ! La lettre est " & GreekLetter & MinusculeMajuscule
        End If
        Label1.Visible = True
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Label1.Visible = False
        Label2.Visible = False
        PictureBox1.Image = ImageList1.Images.Item(RandomImage())
        PictureBox2.Image = PictureBox1.Image
    End Sub

    Private Sub EnableButtons(ByVal TrueFalse As Boolean)
        nu.Enabled = TrueFalse
        iota.Enabled = TrueFalse
        pi.Enabled = TrueFalse
        omicron.Enabled = TrueFalse
        ksi.Enabled = TrueFalse
        mu.Enabled = TrueFalse
        lambda.Enabled = TrueFalse
        kappa.Enabled = TrueFalse
        phi.Enabled = TrueFalse
        rho.Enabled = TrueFalse
        bêta.Enabled = TrueFalse
        omêga.Enabled = TrueFalse
        psi.Enabled = TrueFalse
        khi.Enabled = TrueFalse
        upsilon.Enabled = TrueFalse
        tau.Enabled = TrueFalse
        sigma.Enabled = TrueFalse
        gamma.Enabled = TrueFalse
        delta.Enabled = TrueFalse
        thêta.Enabled = TrueFalse
        êta.Enabled = TrueFalse
        zêta.Enabled = TrueFalse
        epsilon.Enabled = TrueFalse
        alpha.Enabled = TrueFalse
        Button1.Enabled = TrueFalse
        Button26.Enabled = TrueFalse
        Button27.Enabled = TrueFalse
        Button28.Enabled = TrueFalse
        Button29.Enabled = TrueFalse
        Button30.Enabled = TrueFalse
        Button31.Enabled = TrueFalse
        Button32.Enabled = TrueFalse
        Button33.Enabled = TrueFalse
        Button34.Enabled = TrueFalse
        Button35.Enabled = TrueFalse
        Button36.Enabled = TrueFalse
        Button37.Enabled = TrueFalse
        Button38.Enabled = TrueFalse
        Button39.Enabled = TrueFalse
        Button40.Enabled = TrueFalse
        Button41.Enabled = TrueFalse
        Button42.Enabled = TrueFalse
        Button43.Enabled = TrueFalse
        Button44.Enabled = TrueFalse
        Button45.Enabled = TrueFalse
        Button46.Enabled = TrueFalse
        Button47.Enabled = TrueFalse
        Button48.Enabled = TrueFalse



    End Sub



    Private Sub LettresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LettresToolStripMenuItem.Click
        Panel1.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub LettresEnGrecToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LettresEnGrecToolStripMenuItem.Click
        Panel1.Visible = True
        Panel2.Visible = False

    End Sub

    Private Sub MontrerToutesLesLettresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MontrerToutesLesLettresToolStripMenuItem.Click
        AllLetters.ShowDialog()
    End Sub

    Private Sub MixLettersFrench()

        If RadioButton4.Checked = True Then
            Dim LettersArray(24) As Integer
            Dim LettersArray2(24) As Integer
            Dim tmpLetter As Integer
            Dim tmpLetter2 As Integer
            LettersArray(1) = Button1.Left
            LettersArray(2) = Button26.Left
            LettersArray(3) = Button27.Left
            LettersArray(4) = Button28.Left
            LettersArray(5) = Button29.Left
            LettersArray(6) = Button30.Left
            LettersArray(7) = Button31.Left
            LettersArray(8) = Button32.Left
            LettersArray(9) = Button33.Left
            LettersArray(10) = Button34.Left
            LettersArray(11) = Button35.Left
            LettersArray(12) = Button36.Left
            LettersArray(13) = Button37.Left
            LettersArray(14) = Button38.Left
            LettersArray(15) = Button39.Left
            LettersArray(16) = Button40.Left
            LettersArray(17) = Button41.Left
            LettersArray(18) = Button42.Left
            LettersArray(19) = Button43.Left
            LettersArray(20) = Button44.Left
            LettersArray(21) = Button45.Left
            LettersArray(22) = Button46.Left
            LettersArray(23) = Button47.Left
            LettersArray(24) = Button48.Left
            LettersArray2(1) = Button1.Top
            LettersArray2(2) = Button26.Top
            LettersArray2(3) = Button27.Top
            LettersArray2(4) = Button28.Top
            LettersArray2(5) = Button29.Top
            LettersArray2(6) = Button30.Top
            LettersArray2(7) = Button31.Top
            LettersArray2(8) = Button32.Top
            LettersArray2(9) = Button33.Top
            LettersArray2(10) = Button34.Top
            LettersArray2(11) = Button35.Top
            LettersArray2(12) = Button36.Top
            LettersArray2(13) = Button37.Top
            LettersArray2(14) = Button38.Top
            LettersArray2(15) = Button39.Top
            LettersArray2(16) = Button40.Top
            LettersArray2(17) = Button41.Top
            LettersArray2(18) = Button42.Top
            LettersArray2(19) = Button43.Top
            LettersArray2(20) = Button44.Top
            LettersArray2(21) = Button45.Top
            LettersArray2(22) = Button46.Top
            LettersArray2(23) = Button47.Top
            LettersArray2(24) = Button48.Top

            Dim RandomPos As Integer
            Dim RandomPos2 As Integer
            Randomize()

            For ii = 0 To 500
                ' Generate random value between 1 and 24.
                RandomPos = CInt(Int((24 * Rnd()) + 1))
                RandomPos2 = CInt(Int((24 * Rnd()) + 1))

                If RandomPos <> RandomPos2 Then
                    tmpLetter = LettersArray(RandomPos)
                    tmpLetter2 = LettersArray2(RandomPos)
                    LettersArray(RandomPos) = LettersArray(RandomPos2)
                    LettersArray2(RandomPos) = LettersArray2(RandomPos2)
                    LettersArray(RandomPos2) = tmpLetter
                    LettersArray2(RandomPos2) = tmpLetter2
                End If
            Next

            Button1.Left = LettersArray(1)
            Button1.Top = LettersArray2(1)
            Button26.Left = LettersArray(2)
            Button26.Top = LettersArray2(2)
            Button27.Left = LettersArray(3)
            Button27.Top = LettersArray2(3)
            Button28.Left = LettersArray(4)
            Button28.Top = LettersArray2(4)
            Button29.Left = LettersArray(5)
            Button29.Top = LettersArray2(5)
            Button30.Left = LettersArray(6)
            Button30.Top = LettersArray2(6)
            Button31.Left = LettersArray(7)
            Button31.Top = LettersArray2(7)
            Button32.Left = LettersArray(8)
            Button32.Top = LettersArray2(8)
            Button33.Left = LettersArray(9)
            Button33.Top = LettersArray2(9)
            Button34.Left = LettersArray(10)
            Button34.Top = LettersArray2(10)
            Button35.Left = LettersArray(11)
            Button35.Top = LettersArray2(11)
            Button36.Left = LettersArray(12)
            Button36.Top = LettersArray2(12)
            Button37.Left = LettersArray(13)
            Button37.Top = LettersArray2(13)
            Button38.Left = LettersArray(14)
            Button38.Top = LettersArray2(14)
            Button39.Left = LettersArray(15)
            Button39.Top = LettersArray2(15)
            Button40.Left = LettersArray(16)
            Button40.Top = LettersArray2(16)
            Button41.Left = LettersArray(17)
            Button41.Top = LettersArray2(17)
            Button42.Left = LettersArray(18)
            Button42.Top = LettersArray2(18)
            Button43.Left = LettersArray(19)
            Button43.Top = LettersArray2(19)
            Button44.Left = LettersArray(20)
            Button44.Top = LettersArray2(20)
            Button45.Left = LettersArray(21)
            Button45.Top = LettersArray2(21)
            Button46.Left = LettersArray(22)
            Button46.Top = LettersArray2(22)
            Button47.Left = LettersArray(23)
            Button47.Top = LettersArray2(23)
            Button48.Left = LettersArray(24)
            Button48.Top = LettersArray2(24)

        End If


    End Sub

    Private Sub MixLetters()

        If RadioButton2.Checked = True Then
            Dim LettersArray(24) As Integer
            Dim LettersArray2(24) As Integer
            Dim tmpLetter As Integer
            Dim tmpLetter2 As Integer
            LettersArray(1) = iota.Left
            LettersArray(2) = pi.Left
            LettersArray(3) = omicron.Left
            LettersArray(4) = ksi.Left
            LettersArray(5) = mu.Left
            LettersArray(6) = lambda.Left
            LettersArray(7) = kappa.Left
            LettersArray(8) = phi.Left
            LettersArray(9) = rho.Left
            LettersArray(10) = bêta.Left
            LettersArray(11) = omêga.Left
            LettersArray(12) = psi.Left
            LettersArray(13) = khi.Left
            LettersArray(14) = upsilon.Left
            LettersArray(15) = tau.Left
            LettersArray(16) = sigma.Left
            LettersArray(17) = gamma.Left
            LettersArray(18) = delta.Left
            LettersArray(19) = thêta.Left
            LettersArray(20) = êta.Left
            LettersArray(21) = zêta.Left
            LettersArray(22) = epsilon.Left
            LettersArray(23) = alpha.Left
            LettersArray(24) = nu.Left
            LettersArray2(1) = iota.Top
            LettersArray2(2) = pi.Top
            LettersArray2(3) = omicron.Top
            LettersArray2(4) = ksi.Top
            LettersArray2(5) = mu.Top
            LettersArray2(6) = lambda.Top
            LettersArray2(7) = kappa.Top
            LettersArray2(8) = phi.Top
            LettersArray2(9) = rho.Top
            LettersArray2(10) = bêta.Top
            LettersArray2(11) = omêga.Top
            LettersArray2(12) = psi.Top
            LettersArray2(13) = khi.Top
            LettersArray2(14) = upsilon.Top
            LettersArray2(15) = tau.Top
            LettersArray2(16) = sigma.Top
            LettersArray2(17) = gamma.Top
            LettersArray2(18) = delta.Top
            LettersArray2(19) = thêta.Top
            LettersArray2(20) = êta.Top
            LettersArray2(21) = zêta.Top
            LettersArray2(22) = epsilon.Top
            LettersArray2(23) = alpha.Top
            LettersArray2(24) = nu.Top

            Dim RandomPos As Integer
            Dim RandomPos2 As Integer
            Randomize()

            For ii = 0 To 500
                ' Generate random value between 1 and 24.
                RandomPos = CInt(Int((24 * Rnd()) + 1))
                RandomPos2 = CInt(Int((24 * Rnd()) + 1))

                If RandomPos <> RandomPos2 Then
                    tmpLetter = LettersArray(RandomPos)
                    tmpLetter2 = LettersArray2(RandomPos)
                    LettersArray(RandomPos) = LettersArray(RandomPos2)
                    LettersArray2(RandomPos) = LettersArray2(RandomPos2)
                    LettersArray(RandomPos2) = tmpLetter
                    LettersArray2(RandomPos2) = tmpLetter2
                End If
            Next

            iota.Left = LettersArray(1)
            iota.Top = LettersArray2(1)
            pi.Left = LettersArray(2)
            pi.Top = LettersArray2(2)
            omicron.Left = LettersArray(3)
            omicron.Top = LettersArray2(3)
            ksi.Left = LettersArray(4)
            ksi.Top = LettersArray2(4)
            mu.Left = LettersArray(5)
            mu.Top = LettersArray2(5)
            lambda.Left = LettersArray(6)
            lambda.Top = LettersArray2(6)
            kappa.Left = LettersArray(7)
            kappa.Top = LettersArray2(7)
            phi.Left = LettersArray(8)
            phi.Top = LettersArray2(8)
            rho.Left = LettersArray(9)
            rho.Top = LettersArray2(9)
            bêta.Left = LettersArray(10)
            bêta.Top = LettersArray2(10)
            omêga.Left = LettersArray(11)
            omêga.Top = LettersArray2(11)
            psi.Left = LettersArray(12)
            psi.Top = LettersArray2(12)
            khi.Left = LettersArray(13)
            khi.Top = LettersArray2(13)
            upsilon.Left = LettersArray(14)
            upsilon.Top = LettersArray2(14)
            tau.Left = LettersArray(15)
            tau.Top = LettersArray2(15)
            sigma.Left = LettersArray(16)
            sigma.Top = LettersArray2(16)
            gamma.Left = LettersArray(17)
            gamma.Top = LettersArray2(17)
            delta.Left = LettersArray(18)
            delta.Top = LettersArray2(18)
            thêta.Left = LettersArray(19)
            thêta.Top = LettersArray2(19)
            êta.Left = LettersArray(20)
            êta.Top = LettersArray2(20)
            zêta.Left = LettersArray(21)
            zêta.Top = LettersArray2(21)
            epsilon.Left = LettersArray(22)
            epsilon.Top = LettersArray2(22)
            alpha.Left = LettersArray(23)
            alpha.Top = LettersArray2(23)
            nu.Left = LettersArray(24)
            nu.Top = LettersArray2(24)

        End If


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked = True Then
            MixLetters()
        End If
    End Sub

    Private Sub OriginalFrenchLettersLocation()

        OriginalLettersArrayFrench(1) = Button1.Left
        OriginalLettersArrayFrench(2) = Button26.Left
        OriginalLettersArrayFrench(3) = Button27.Left
        OriginalLettersArrayFrench(4) = Button28.Left
        OriginalLettersArrayFrench(5) = Button29.Left
        OriginalLettersArrayFrench(6) = Button30.Left
        OriginalLettersArrayFrench(7) = Button31.Left
        OriginalLettersArrayFrench(8) = Button32.Left
        OriginalLettersArrayFrench(9) = Button33.Left
        OriginalLettersArrayFrench(10) = Button34.Left
        OriginalLettersArrayFrench(11) = Button35.Left
        OriginalLettersArrayFrench(12) = Button36.Left
        OriginalLettersArrayFrench(13) = Button37.Left
        OriginalLettersArrayFrench(14) = Button38.Left
        OriginalLettersArrayFrench(15) = Button39.Left
        OriginalLettersArrayFrench(16) = Button40.Left
        OriginalLettersArrayFrench(17) = Button41.Left
        OriginalLettersArrayFrench(18) = Button42.Left
        OriginalLettersArrayFrench(19) = Button43.Left
        OriginalLettersArrayFrench(20) = Button44.Left
        OriginalLettersArrayFrench(21) = Button45.Left
        OriginalLettersArrayFrench(22) = Button46.Left
        OriginalLettersArrayFrench(23) = Button47.Left
        OriginalLettersArrayFrench(24) = Button48.Left
        OriginalLettersArrayFrench2(1) = Button1.Top
        OriginalLettersArrayFrench2(2) = Button26.Top
        OriginalLettersArrayFrench2(3) = Button27.Top
        OriginalLettersArrayFrench2(4) = Button28.Top
        OriginalLettersArrayFrench2(5) = Button29.Top
        OriginalLettersArrayFrench2(6) = Button30.Top
        OriginalLettersArrayFrench2(7) = Button31.Top
        OriginalLettersArrayFrench2(8) = Button32.Top
        OriginalLettersArrayFrench2(9) = Button33.Top
        OriginalLettersArrayFrench2(10) = Button34.Top
        OriginalLettersArrayFrench2(11) = Button35.Top
        OriginalLettersArrayFrench2(12) = Button36.Top
        OriginalLettersArrayFrench2(13) = Button37.Top
        OriginalLettersArrayFrench2(14) = Button38.Top
        OriginalLettersArrayFrench2(15) = Button39.Top
        OriginalLettersArrayFrench2(16) = Button40.Top
        OriginalLettersArrayFrench2(17) = Button41.Top
        OriginalLettersArrayFrench2(18) = Button42.Top
        OriginalLettersArrayFrench2(19) = Button43.Top
        OriginalLettersArrayFrench2(20) = Button44.Top
        OriginalLettersArrayFrench2(21) = Button45.Top
        OriginalLettersArrayFrench2(22) = Button46.Top
        OriginalLettersArrayFrench2(23) = Button47.Top
        OriginalLettersArrayFrench2(24) = Button48.Top


    End Sub

    Private Sub OriginalGreekLettersLocation()

        OriginalLettersArrayGreek(1) = iota.Left
        OriginalLettersArrayGreek(2) = pi.Left
        OriginalLettersArrayGreek(3) = omicron.Left
        OriginalLettersArrayGreek(4) = ksi.Left
        OriginalLettersArrayGreek(5) = mu.Left
        OriginalLettersArrayGreek(6) = lambda.Left
        OriginalLettersArrayGreek(7) = kappa.Left
        OriginalLettersArrayGreek(8) = phi.Left
        OriginalLettersArrayGreek(9) = rho.Left
        OriginalLettersArrayGreek(10) = bêta.Left
        OriginalLettersArrayGreek(11) = omêga.Left
        OriginalLettersArrayGreek(12) = psi.Left
        OriginalLettersArrayGreek(13) = khi.Left
        OriginalLettersArrayGreek(14) = upsilon.Left
        OriginalLettersArrayGreek(15) = tau.Left
        OriginalLettersArrayGreek(16) = sigma.Left
        OriginalLettersArrayGreek(17) = gamma.Left
        OriginalLettersArrayGreek(18) = delta.Left
        OriginalLettersArrayGreek(19) = thêta.Left
        OriginalLettersArrayGreek(20) = êta.Left
        OriginalLettersArrayGreek(21) = zêta.Left
        OriginalLettersArrayGreek(22) = epsilon.Left
        OriginalLettersArrayGreek(23) = alpha.Left
        OriginalLettersArrayGreek(24) = nu.Left
        OriginalLettersArrayGreek2(1) = iota.Top
        OriginalLettersArrayGreek2(2) = pi.Top
        OriginalLettersArrayGreek2(3) = omicron.Top
        OriginalLettersArrayGreek2(4) = ksi.Top
        OriginalLettersArrayGreek2(5) = mu.Top
        OriginalLettersArrayGreek2(6) = lambda.Top
        OriginalLettersArrayGreek2(7) = kappa.Top
        OriginalLettersArrayGreek2(8) = phi.Top
        OriginalLettersArrayGreek2(9) = rho.Top
        OriginalLettersArrayGreek2(10) = bêta.Top
        OriginalLettersArrayGreek2(11) = omêga.Top
        OriginalLettersArrayGreek2(12) = psi.Top
        OriginalLettersArrayGreek2(13) = khi.Top
        OriginalLettersArrayGreek2(14) = upsilon.Top
        OriginalLettersArrayGreek2(15) = tau.Top
        OriginalLettersArrayGreek2(16) = sigma.Top
        OriginalLettersArrayGreek2(17) = gamma.Top
        OriginalLettersArrayGreek2(18) = delta.Top
        OriginalLettersArrayGreek2(19) = thêta.Top
        OriginalLettersArrayGreek2(20) = êta.Top
        OriginalLettersArrayGreek2(21) = zêta.Top
        OriginalLettersArrayGreek2(22) = epsilon.Top
        OriginalLettersArrayGreek2(23) = alpha.Top
        OriginalLettersArrayGreek2(24) = nu.Top

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            iota.Left = OriginalLettersArrayGreek(1)
            iota.Top = OriginalLettersArrayGreek2(1)
            pi.Left = OriginalLettersArrayGreek(2)
            pi.Top = OriginalLettersArrayGreek2(2)
            omicron.Left = OriginalLettersArrayGreek(3)
            omicron.Top = OriginalLettersArrayGreek2(3)
            ksi.Left = OriginalLettersArrayGreek(4)
            ksi.Top = OriginalLettersArrayGreek2(4)
            mu.Left = OriginalLettersArrayGreek(5)
            mu.Top = OriginalLettersArrayGreek2(5)
            lambda.Left = OriginalLettersArrayGreek(6)
            lambda.Top = OriginalLettersArrayGreek2(6)
            kappa.Left = OriginalLettersArrayGreek(7)
            kappa.Top = OriginalLettersArrayGreek2(7)
            phi.Left = OriginalLettersArrayGreek(8)
            phi.Top = OriginalLettersArrayGreek2(8)
            rho.Left = OriginalLettersArrayGreek(9)
            rho.Top = OriginalLettersArrayGreek2(9)
            bêta.Left = OriginalLettersArrayGreek(10)
            bêta.Top = OriginalLettersArrayGreek2(10)
            omêga.Left = OriginalLettersArrayGreek(11)
            omêga.Top = OriginalLettersArrayGreek2(11)
            psi.Left = OriginalLettersArrayGreek(12)
            psi.Top = OriginalLettersArrayGreek2(12)
            khi.Left = OriginalLettersArrayGreek(13)
            khi.Top = OriginalLettersArrayGreek2(13)
            upsilon.Left = OriginalLettersArrayGreek(14)
            upsilon.Top = OriginalLettersArrayGreek2(14)
            tau.Left = OriginalLettersArrayGreek(15)
            tau.Top = OriginalLettersArrayGreek2(15)
            sigma.Left = OriginalLettersArrayGreek(16)
            sigma.Top = OriginalLettersArrayGreek2(16)
            gamma.Left = OriginalLettersArrayGreek(17)
            gamma.Top = OriginalLettersArrayGreek2(17)
            delta.Left = OriginalLettersArrayGreek(18)
            delta.Top = OriginalLettersArrayGreek2(18)
            thêta.Left = OriginalLettersArrayGreek(19)
            thêta.Top = OriginalLettersArrayGreek2(19)
            êta.Left = OriginalLettersArrayGreek(20)
            êta.Top = OriginalLettersArrayGreek2(20)
            zêta.Left = OriginalLettersArrayGreek(21)
            zêta.Top = OriginalLettersArrayGreek2(21)
            epsilon.Left = OriginalLettersArrayGreek(22)
            epsilon.Top = OriginalLettersArrayGreek2(22)
            alpha.Left = OriginalLettersArrayGreek(23)
            alpha.Top = OriginalLettersArrayGreek2(23)
            nu.Left = OriginalLettersArrayGreek(24)
            nu.Top = OriginalLettersArrayGreek2(24)
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Button1.Left = OriginalLettersArrayFrench(1)
            Button1.Top = OriginalLettersArrayFrench2(1)
            Button26.Left = OriginalLettersArrayFrench(2)
            Button26.Top = OriginalLettersArrayFrench2(2)
            Button27.Left = OriginalLettersArrayFrench(3)
            Button27.Top = OriginalLettersArrayFrench2(3)
            Button28.Left = OriginalLettersArrayFrench(4)
            Button28.Top = OriginalLettersArrayFrench2(4)
            Button29.Left = OriginalLettersArrayFrench(5)
            Button29.Top = OriginalLettersArrayFrench2(5)
            Button30.Left = OriginalLettersArrayFrench(6)
            Button30.Top = OriginalLettersArrayFrench2(6)
            Button31.Left = OriginalLettersArrayFrench(7)
            Button31.Top = OriginalLettersArrayFrench2(7)
            Button32.Left = OriginalLettersArrayFrench(8)
            Button32.Top = OriginalLettersArrayFrench2(8)
            Button33.Left = OriginalLettersArrayFrench(9)
            Button33.Top = OriginalLettersArrayFrench2(9)
            Button34.Left = OriginalLettersArrayFrench(10)
            Button34.Top = OriginalLettersArrayFrench2(10)
            Button35.Left = OriginalLettersArrayFrench(11)
            Button35.Top = OriginalLettersArrayFrench2(11)
            Button36.Left = OriginalLettersArrayFrench(12)
            Button36.Top = OriginalLettersArrayFrench2(12)
            Button37.Left = OriginalLettersArrayFrench(13)
            Button37.Top = OriginalLettersArrayFrench2(13)
            Button38.Left = OriginalLettersArrayFrench(14)
            Button38.Top = OriginalLettersArrayFrench2(14)
            Button39.Left = OriginalLettersArrayFrench(15)
            Button39.Top = OriginalLettersArrayFrench2(15)
            Button40.Left = OriginalLettersArrayFrench(16)
            Button40.Top = OriginalLettersArrayFrench2(16)
            Button41.Left = OriginalLettersArrayFrench(17)
            Button41.Top = OriginalLettersArrayFrench2(17)
            Button42.Left = OriginalLettersArrayFrench(18)
            Button42.Top = OriginalLettersArrayFrench2(18)
            Button43.Left = OriginalLettersArrayFrench(19)
            Button43.Top = OriginalLettersArrayFrench2(19)
            Button44.Left = OriginalLettersArrayFrench(20)
            Button44.Top = OriginalLettersArrayFrench2(20)
            Button45.Left = OriginalLettersArrayFrench(21)
            Button45.Top = OriginalLettersArrayFrench2(21)
            Button46.Left = OriginalLettersArrayFrench(22)
            Button46.Top = OriginalLettersArrayFrench2(22)
            Button47.Left = OriginalLettersArrayFrench(23)
            Button47.Top = OriginalLettersArrayFrench2(23)
            Button48.Left = OriginalLettersArrayFrench(24)
            Button48.Top = OriginalLettersArrayFrench2(24)
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then

            MixLettersFrench()
        End If
    End Sub
End Class
