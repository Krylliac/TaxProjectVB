Public Class pph

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim jp As Integer, pkp1 As Integer, netot As Integer, jb As Integer, netob As Integer, neto As Integer, iu As Integer, ja As Integer, prem As Integer, ptkp As Integer, pkp As Integer
        jp = Val(TextBox1.Text)
        iu = Val(TextBox6.Text)
        ja = Val(TextBox2.Text)
        prem = Val(TextBox3.Text)
        If ja > 3 Then
            MsgBox("anak maximal 3")
        Else
            If mnikah.Checked Then
                jb = jp + prem
                neto = (0.05 * jb) + iu
                netob = (jb - neto)
                netot = (netob * 12)
                ptkp = (netot - (2880000 + 1440000 + (ja * 1440000)))
                TextBox4.Text = ptkp

                If tada.Checked Then
                    jb = jp + prem
                    neto = (0.05 * jb) + iu
                    netob = (jb - neto)
                    netot = (netob * 12)
                    ptkp = (netot - (2880000 + 1440000 + (ja * 1440000)))
                    TextBox4.Text = ptkp

                    pkp1 = (0.05 * ptkp) / 12
                    pkp = pkp1 * 1.2
                    TextBox5.Text = pkp
                End If
            End If
            If mnikah.Checked Then
                jb = jp + prem
                neto = (0.05 * jb) + iu
                netob = (jb - neto)
                netot = (netob * 12)
                ptkp = (netot - (2880000 + 1440000 + (ja * 1440000)))
                TextBox4.Text = ptkp

                If ada.Checked Then
                    jb = jp + prem
                    neto = (0.05 * jb) + iu
                    netob = (jb - neto)
                    netot = (netob * 12)
                    ptkp = (netot - (2880000 + 1440000 + (ja * 1440000)))
                    TextBox4.Text = ptkp
                    pkp1 = (0.05 * ptkp) / 12
                    TextBox5.Text = pkp1
                End If
            End If
            If bmnikah.Checked Then
                jb = jp + prem
                neto = (0.05 * jb) + iu
                netob = (jb - neto)
                netot = (netob * 12)
                ptkp = (netot - (2880000 + (ja * 1440000)))
                TextBox4.Text = ptkp

                If tada.Checked Then
                    jb = jp + prem
                    neto = (0.05 * jb) + iu
                    netob = (jb - neto)
                    netot = (netob * 12)
                    ptkp = (netot - (2880000 + (ja * 1440000)))
                    TextBox4.Text = ptkp

                    pkp1 = (0.05 * ptkp) / 12
                    pkp = pkp1 * 1.2
                    TextBox5.Text = pkp
                End If
            End If
            If bmnikah.Checked Then
                jb = jp + prem
                neto = (0.05 * jb) + iu
                netob = (jb - neto)
                netot = (netob * 12)
                ptkp = (netot - (2880000 + (ja * 1440000)))
                TextBox4.Text = ptkp

                If ada.Checked Then
                    jb = jp + prem
                    neto = (0.05 * jb) + iu
                    netob = (jb - neto)
                    netot = (netob * 12)
                    ptkp = (netot - (2880000 + (ja * 1440000)))
                    TextBox4.Text = ptkp
                    pkp1 = (0.05 * ptkp) / 12
                    TextBox5.Text = pkp1
                End If
            End If
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub pph_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub bmnikah_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bmnikah.CheckedChanged
        TextBox2.ReadOnly = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        mnikah.Checked = False
        bmnikah.Checked = False
        ada.Checked = False
        tada.Checked = False
    End Sub

    Private Sub mnikah_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnikah.CheckedChanged
        TextBox2.ReadOnly = False
    End Sub
End Class