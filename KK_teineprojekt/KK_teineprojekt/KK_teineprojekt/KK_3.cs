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
    public partial class KK_3 : Form
    {
        public Button KK_button3;

        public KK_3()
        {
            InitializeComponent();
        }

        private void KK_3_FormClosing(object sender, FormClosingEventArgs e)
        {
            KK_button3.Enabled = true; 

        }
    }
}
