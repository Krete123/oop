using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KK_teineprojekt
{
    public partial class KK_3 : Form
    {
        public Button KK_button3;

        public KK_3()
        {
            InitializeComponent();
            KK_listBox1.Sorted = KK_checkBox2.Checked;
        }

        private void KK_3_FormClosing(object sender, FormClosingEventArgs e)
        {
            KK_button3.Enabled = true;

        }

        private void KK_listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KK_button2_Click(object sender, EventArgs e)
        {
            string t = KK_textBox1.Text;
            int number = KK_listBox1.SelectedIndex;
            if (number == -1)
                KK_listBox1.Items.Add(t);
            else
            {
                KK_listBox1.Items.Insert(number, t);
                KK_listBox1.SelectedIndex = -1;

            }



            KK_textBox1.Text = "";
            KK_textBox1.Focus();

        }

        private void KK_checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (KK_checkBox2.Checked)
                KK_checkBox2.Text = "Sorted";

            else
                KK_checkBox2.Text = "Unsorted";
            KK_listBox1.Sorted = KK_checkBox2.Checked;


        }

        private void KK_button4_Click(object sender, EventArgs e)
        {
            int number = KK_listBox1.SelectedIndex;
            if (number == -1)
            {
                MessageBox.Show("Valik puudub");
                return;


            }
            string t = KK_listBox1.Items[number].ToString();
            t = "Soovid kustutada:" + (char)(13) + t;
            DialogResult vastus = MessageBox.Show(t, "Hoiatus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
                KK_listBox1.Items.RemoveAt(number);
            else
                KK_listBox1.SelectedIndex = -1;



        }

        private void KK_button5_Click(object sender, EventArgs e)
        {
            int number = KK_listBox1.SelectedIndex;
            if (number == -1)
            {
                MessageBox.Show("Valik puudub");
                return;
            }
            KK_listBox1.Items[number] = KK_textBox1.Text;

        }
    }





}
