Public Class awalan

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pph.Show()
        Me.Hide()
    End Sub

    Private Sub awalan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        bb.Show()
        Me.Hide()
    End Sub

    Private Sub PAJAKBUMIBANGUNANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PAJAKBUMIBANGUNANToolStripMenuItem.Click
        bb.Show()

    End Sub

    Private Sub PAJAKPENGHASILANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PAJAKPENGHASILANToolStripMenuItem.Click
        pph.Show()

    End Sub

    Private Sub COPYRIGHTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COPYRIGHTToolStripMenuItem.Click
        kredit.Show()

    End Sub

    Private Sub KELUARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KELUARToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class
