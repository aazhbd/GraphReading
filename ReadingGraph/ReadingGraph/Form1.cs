using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReadingGraph
{
    public partial class Form1 : Form
    {
        Bitmap img;
        String str;
        int x, h, w, sx, i, j;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            str = of.FileName;
            if (str.Length == 0) return;
            img = (Bitmap) Image.FromFile(str);
            x = 1;
            pictureBox1.Image = img;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color c;
            String tmp, xs;
            int tb, tr, tg;
            double r, d, m;

            if (x == 0)
            {
                OpenFileDialog of = new OpenFileDialog();
                of.ShowDialog();
                string str = of.FileName;
                if (str.Length == 0) return;
                img = (Bitmap) Image.FromFile(str);
                x = 1;
                pictureBox1.Image = img;
            }

            h = img.Height;
            w = img.Width;

            if (w > 557 || h > 398)
            {
                MessageBox.Show("Unrecognizable picture input", "Error in input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sx = 27;
            j = 0;
            xs = "";
            tmp = "";

            while (sx < w && sx < 479)
            {
                xs = textBox1.Text;
                xs += "" + j + ", ";
                textBox1.Text = xs;

                for (i = 27; i < h; i++)
                {
                    c = img.GetPixel(sx, i);
                    tb = c.B;
                    tr = c.R;
                    tg = c.G;
                    if (tb == 0 && tr == 255 && tg == 255)
                    {
                        tmp = textBox2.Text;
                        d = i - 26;
                        r = d / 8;
                        m = 20 - r;
                        tmp += " " + m + ",";
                        textBox2.Text = tmp;
                        break;
                    }
                }

                sx += 7;
                j++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("An experimental program to recognize graph and read the values,\n\nPut on the image using the load image button or using the file menu\nThen by clicking the read values button or menu the values can be read.\n\n\nAbdullah Al Zakir Hossain, www.aazhbd.com", "Help & About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void readValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color c;
            String tmp, xs;
            int tb, tr, tg;
            double r, d, m;

            if (x == 0)
            {
                OpenFileDialog of = new OpenFileDialog();
                of.ShowDialog();
                string str = of.FileName;
                if (str.Length == 0) return;
                img = (Bitmap)Image.FromFile(str);
                x = 1;
                pictureBox1.Image = img;
            }

            h = img.Height;
            w = img.Width;

            if (w > 557 || h > 398)
            {
                MessageBox.Show("Unrecognizable picture input", "Error in input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sx = 27;
            j = 0;
            xs = "";
            tmp = "";

            while (sx < w && sx < 479)
            {
                xs = textBox1.Text;
                xs += " " + j + ",";
                textBox1.Text = xs;

                for (i = 27; i < h; i++)
                {
                    c = img.GetPixel(sx, i);
                    tb = c.B;
                    tr = c.R;
                    tg = c.G;
                    if (tb == 0 && tr == 255 && tg == 255)
                    {
                        tmp = textBox2.Text;
                        d = i - 26;
                        r = d / 8;
                        m = 20 - r;
                        tmp += " " + m + ",";
                        textBox2.Text = tmp;
                        break;
                    }
                }

                sx += 7;
                j++;
            }
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            str = of.FileName;
            if (str.Length == 0) return;
            img = (Bitmap)Image.FromFile(str);
            x = 1;
            pictureBox1.Image = img;
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("An experimental program to recognize graph and read the values,\n\nPut on the image using the load image button or using the file menu\nThen by clicking the read values button or menu the values can be read.\n\n\nAbdullah Al Zakir Hossain, www.aazhbd.com", "Help & About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}