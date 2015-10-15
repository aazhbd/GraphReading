Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim img As Bitmap
        Dim col As Color
        Dim r, g, b As Byte
        Dim s As String


        img = Image.FromFile("ut.bmp")

        PictureBox1.Image = img

        col = img.GetPixel(0, 0)

        r = col.R
        g = col.G
        b = col.B

        MsgBox(r)
        MsgBox(g)
        MsgBox(b)

    End Sub
End Class
