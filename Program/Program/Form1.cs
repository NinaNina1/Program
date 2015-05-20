using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Program
{

    public partial class Form1 : Form
    {
        void ucitaj(string ucitajtxt)
        {
            try
            {
                if (!File.Exists(ucitajtxt))
		        {
                    File.Create(ucitajtxt);
		        }
                
            }
            catch (Exception)
            {
                
                throw;
            }
            StreamReader sr = new StreamReader(ucitajtxt);
            return;
        }
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
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btKorisnik_Click(object sender, EventArgs e)
        {
            KreirajKorisnika kk = new KreirajKorisnika();
            kk.Show();
        }
    }
}
