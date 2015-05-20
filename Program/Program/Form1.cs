using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btDomacica_Click(object sender, EventArgs e)
        {
            KreirajDomacicu kd = new KreirajDomacicu();
            kd.Show();
            Gdomacica gdm = new Gdomacica();
           
        }
    }
}
