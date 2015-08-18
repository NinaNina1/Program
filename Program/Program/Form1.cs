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
        
        void ucitaj()
        {
            try
            {
                if (!File.Exists(Globalne.pathgd))
		        {
                    Directory.CreateDirectory(Globalne.pathfolder);
                    var myFile = File.Create(Globalne.pathgd);
                    myFile.Close();
                    
		        }
                if(!File.Exists(Globalne.pathsettings))
                {
                    var myFile = File.Create(Globalne.pathsettings);
                    myFile.Close();
                }
                if (!File.Exists(Globalne.pathkor))
                {
                    var myFile = File.Create(Globalne.pathkor);
                    myFile.Close();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Tehnicka Greska");
            }
            StreamReader srgd = new StreamReader(Globalne.pathgd);
            StreamReader srst = new StreamReader(Globalne.pathsettings);
            StreamReader srkor = new StreamReader(Globalne.pathkor);
            Gdomacica gd;
            Globalne.brojGdomacica = Convert.ToInt32(srst.ReadLine());
            Globalne.brojKorisnika = Convert.ToInt32(srst.ReadLine());
            bool ispravnost=false;
            
            for (int i = 0; i < Globalne.brojGdomacica; i++)
            {
                ispravnost = false;
                gd = new Gdomacica(srgd,ref ispravnost); 
                if (ispravnost)
                {
                    Globalne.poJMBG.Add(gd.JMBG, gd);
                    Globalne.poImenu.Add(gd.ime, gd);
                    Globalne.poPrezimenu.Add(gd.prezime, gd);
                }
                
            }
            srgd.Close();
            srst.Close();
            srkor.Close();
            return;
        }


       

        void napunilb ()
        {

        }







        public Form1()
        {
            InitializeComponent();
         

        }


        private void btDomacica_Click(object sender, EventArgs e)
        {
            KreirajDomacicu kd = new KreirajDomacicu();
            DialogResult dr = kd.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                kd.gd.Upis();
                LBdomacice.Items.Add(kd.gd.PunoIme());
            }
            else if (dr==DialogResult.No)
            {

            }
            
            
           
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

            ucitaj();
            foreach (KeyValuePair<string, Gdomacica> entry in Globalne.poImenu)
            {
                LBdomacice.Items.Add(entry.Value.PunoIme());
            }

            foreach (KeyValuePair<string, Korisnici> entry in Globalne.kpoImenu)
            {
                lbKorisnici.Items.Add(entry.Value.punoime());
            }
        }

        private void btKorisnik_Click(object sender, EventArgs e)
        {
            KreirajKorisnika kk = new KreirajKorisnika();
            DialogResult dr=kk.ShowDialog();
            if (dr == DialogResult.Yes)
            {

            }

        }

        private void btSacuvaj_Click(object sender, EventArgs e)
        {
            StreamWriter swst = new StreamWriter(Globalne.pathsettings,false);
            swst.WriteLine(Globalne.brojGdomacica.ToString());
            swst.WriteLine(Globalne.brojKorisnika.ToString());
            swst.Close();
        }

        private void lbKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var form2 = new KreirajKorisnika();
            form2.ShowDialog();
            

        }

        private void LBdomacice_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indeks = (LBdomacice.SelectedItem.ToString()).IndexOf(" ");
            string imepom = (LBdomacice.SelectedItem.ToString()).Substring(0, indeks-1);
            string prezimepom = (LBdomacice.SelectedItem.ToString()).Substring(indeks + 1);
            var form2 = new KreirajDomacicu();
            //StreamReader sr = new StreamReader(Globalne.pathgd.);
            //sr.ReadLine();

            //while (!sr.EndOfStream)
            {
              //  if (sr.ToString() == imepom)
                {
                //    string pom=sr.ToString();
                  //  if (sr.ReadLine() == prezimepom)
                    { 
                        

                    
                    }
                
                }
                //sr.ReadLine();
            }



            form2.ShowDialog();
           
        }
    }
}
