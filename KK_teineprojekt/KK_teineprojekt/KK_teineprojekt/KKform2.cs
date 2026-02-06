using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KK_teineprojekt
{
    public partial class KKform2 : Form

    {


        internal Button button4;
        int h, w;
        int x1, y1, x2, y2;
        Image pilt;


        public KKform2()
        {
            InitializeComponent();
            w = KK_pildid1.Width;
            h = KK_pildid1.Height;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string t = "Graafilised failid|*JPG; .png; .bmp";
            t += "|JPEG failid|*.jpg|Kõik failid|*.*";
            KK_openFileDialog1.Filter = t;
            KK_openFileDialog1.ShowDialog();
            string fn = KK_openFileDialog1.FileName;
            KK_frame1.Text = fn;
            pilt = Image.FromFile(fn);
            KK_pildid1.Image = pilt;
        }

        private void KK_frame1_Enter(object sender, EventArgs e)
        {

        }

        private void KK_openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            KK_pildid1.Width = w;
            KK_pildid1.Height = h;
            if (KK_radioButton3.Checked)
                KK_pildid1.SizeMode = PictureBoxSizeMode.AutoSize;
            {

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            KK_pildid1.Width = w;
            KK_pildid1.Height = h;
            if (KK_radioButton1.Checked)

                KK_pildid1.SizeMode = PictureBoxSizeMode.Normal;
            {
            }
        }

        private void KK_radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            KK_pildid1.Width = w;
            KK_pildid1.Height = h;
            if (KK_radioButton4.Checked)

                KK_pildid1.SizeMode = PictureBoxSizeMode.CenterImage;
            {
            }
        }

        private void KK_radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            KK_pildid1.Width = w;
            KK_pildid1.Height = h;
            if (KK_radioButton5.Checked)

                KK_pildid1.SizeMode = PictureBoxSizeMode.Zoom;
            {
            }
        }

        private void KK_pildid1_MouseDown(object sender, MouseEventArgs e)
        {
            string t = e.Button.ToString();
            if (t != "Left") return;
            label1.Text = t;
            label2.Text = e.X.ToString();
            label3.Text = e.Y.ToString();
            x1 = x2 = e.X;
            y1 = y2 = e.Y;
        }

        private void KK_pildid1_MouseMove(object sender, MouseEventArgs e)
        {
            string t = e.Button.ToString();
            if (t != "Left") return;
            label1.Text = t;
            label2.Text = e.X.ToString();
            label3.Text = e.Y.ToString();
            x2 = e.X;
            y2 = e.Y;
            KK_Joonista(Color.Red, 2);
        }

        private void KK_pildid1_MouseUp(object sender, MouseEventArgs e)
        {
            string t = e.Button.ToString();
            if (t != "Left") return;
            label1.Text = t;
            label2.Text = e.X.ToString();
            label3.Text = e.Y.ToString();
            x2 = e.X;
            y2 = e.Y;
            KK_Joonista(Color.Red, 5);
        }

        private void KK_radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            KK_pildid1.Width = w;
            KK_pildid1.Height = h;
            if (KK_radioButton2.Checked)

                KK_pildid1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void KK_Joonista(Color c, int k)
        {
            Bitmap BM = new Bitmap(pilt);
            Graphics g = Graphics.FromImage(BM);
            Pen pliiats = new Pen(c, k);
            int x0 = Math.Min(x1, x2);
            int y0 = Math.Min(y1, y2);
            int dx = Math.Abs(x1 - x2);
            int dy = Math.Abs(y1 - y2);
            g.DrawRectangle(pliiats, x0, y0, dx, dy);
            KK_pildid1.Image = BM;


        }

    }
    
}

