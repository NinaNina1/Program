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
    public partial class PostojecaDomacica : Form
    {
        public PostojecaDomacica()
        {
            InitializeComponent();
        }

       public void ispisiGD(Gdomacica gd)
        {
            tbIme.Text = gd.ime;
            tbPrezime.Text = gd.prezime;
            tbDevojackoPrezime.Text = gd.dprezime;
            dateTimePicker1.Value = gd.dtmrodjenja;
            tbJMBG.Text = gd.JMBG;
            tbBrojLicne.Text = gd.BrLK;
            tbAdresa.Text = gd.Adresa;
            tbTelefon.Text = gd.brTel;
            tbMobilni.Text = gd.brMobTel;
            tbEmail.Text = gd.email;
            tbObrazovanje.Text = gd.obrazovanje;
            if (gd.pusac == true)
            {
                cbPusac.Checked = true;
            }
            if (gd.alergije!="")
            {
                cbAlergije.Checked = true;
                tbAlergije.Text = gd.alergije;
            }
            if (gd.FOgranicenja != "")
            {
                cbFizickaOgrc.Checked = true;
                tbFizickaOgrc.Text = gd.FOgranicenja;
            }
            if (gd.ZdrProb != "")
            {
                cbZdravstveniProb.Checked = true;
                tbZdravstveniProblemi.Text = gd.ZdrProb;
            }
            tbHobi.Text = gd.hobi;



        }


        private void btKorisnik_Click(object sender, EventArgs e)
        {
            ListaKorisnika lk = new ListaKorisnika();
            lk.Show();
        }

        private void PostojecaDomacica_Load(object sender, EventArgs e)
        {

        }
    }
}
