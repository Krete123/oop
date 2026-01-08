using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KK_esimene_projekt
{
    public partial class KK_vorm1 : Form
    {
        public KK_vorm1()
        {
            InitializeComponent();
        }

        private void KK_button1_Click(object sender, EventArgs e)
        {
            string t = KK_text1.Text;
            if (KK_checkBox1.Checked)
                t = t.ToUpper();
            else 
                t=t.ToLower();

            KK_lable1.Text = t;
        }

        private void KK_text1_TextChanged(object sender, EventArgs e)
        {
            KK_label2.Text = KK_text1.Text;
        }

        private void KK_checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (KK_checkBox1.Checked)
            {
                KK_checkBox1.Text = "Suured tähed";
                

            }
            else
            {
                KK_checkBox1.Text = "Väiksed tähed";
            }
            KK_text1_TextChanged(null,null);
        }

        private void KK_Frame1_Enter(object sender, EventArgs e)
        {

        }

        private void KK_timer1_Tick(object sender, EventArgs e)
        {
            if (KK_rdbn1.Checked)
            KK_label3.Text = DateTime.Now.ToString();

            else if (KK_rdbn2.Checked)
                KK_label3.Text= DateTime.Now.ToLongDateString();

            else if (KK_rdbn3.Checked)
                KK_label3.Text=DateTime.Now.ToLongTimeString();

        }



        private void KKcheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (KK_checkBox2.Checked)
            {
                KK_checkBox2.Text = "Timer on";
                KK_timer1.Enabled = true;

            }
            else
            {
                KK_checkBox2.Text = "Timer OFF";
                    KK_timer1.Enabled = false;
                KK_label3.Text = "";
            }

        }
    }
}
