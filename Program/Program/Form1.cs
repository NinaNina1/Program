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
            string konacnipath = Path.Combine(Globalne.pathbaze, ucitajtxt);
            try
            {
                if (!File.Exists(ucitajtxt))
		        {
                    Directory.CreateDirectory(Globalne.pathbaze);
                    var myFile = File.Create(konacnipath);
                    myFile.Close();
                    
		        }
                
            }
            catch (Exception)
            {
                
                throw;
            }
                StreamReader sr = new StreamReader(konacnipath);
            if (!sr.EndOfStream)
            {
                Globalne.brojGdomacica = Convert.ToInt32(sr.ReadLine());
               
            }
            else
            {
                Globalne.brojGdomacica = 0;
            }
            Gdomacica gd;
            bool ispravnost=false;
            for (int i = 0; i < Globalne.brojGdomacica; i++)
            {
                gd = new Gdomacica(sr,ref ispravnost); 
                if (ispravnost)
                {
                    Globalne.poJMBG.Add(gd.JMBG, gd);
                    Globalne.poImenu.Add(gd.ime, gd);
                    Globalne.poPrezimenu.Add(gd.prezime, gd);
                }
            }
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
            DialogResult dr = kd.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("yes");
            }
            else if (dr==DialogResult.No)
            {

                MessageBox.Show("no");
            }
            
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ucitaj("baze.data");
        }

        private void btKorisnik_Click(object sender, EventArgs e)
        {
            KreirajKorisnika kk = new KreirajKorisnika();
            DialogResult dr=kk.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("yes");
            }

        }
    }
}
