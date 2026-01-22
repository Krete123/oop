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
    public partial class KK_formmain : Form
    {
        public KK_formmain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KK_3 F1 = new KK_3();
            F1.KK_button3 = this.KK_button1;
            F1.Show();
            KK_button1.Enabled = false; 



        }
    }
}
