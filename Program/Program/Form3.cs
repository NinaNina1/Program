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
    public partial class KreirajDomacicu : Form
    {
        public KreirajDomacicu()
        {
            InitializeComponent();
        }

        private void tbJMBG_TextChanged(object sender, EventArgs e)
        {
            string tekst = tbJMBG.Text;
            if (tekst.Length>13)
            {
                tbJMBG.Text = tekst.Substring(0, tekst.Length - 1);
                tbJMBG.Select(tekst.Length, 0);
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(tbJMBG.Text, "[^0-9]"))
            {
                MessageBox.Show("JMBG mora biti sastavljen samo od cifara!",@"Greška");
                tbJMBG.Text=tekst.Substring(0,tekst.Length-1);
                tbJMBG.Select(tekst.Length, 0);
            }
        }

        private void tbJMBG_Validating(object sender, CancelEventArgs e)
        {
            string tekst = tbJMBG.Text;
            if (tekst.Length != 13)
            {
                tbJMBG.ForeColor = Color.Red;
            }
        }

        private void tbBrojLicne_Validating(object sender, CancelEventArgs e)
        {
            string tekst = tbBrojLicne.Text;
            if (tekst.Length != 9)
            {
                tbBrojLicne.ForeColor = Color.Red;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(tbJMBG.Text, "[^0-9]"))
            {
                MessageBox.Show("JMBG mora biti sastavljen samo od cifara!", @"Greška");
                tbJMBG.Text = tekst.Substring(0, tekst.Length - 1);
                tbJMBG.Select(tekst.Length, 0);
            }

        }

        private void tbBrojLicne_TextChanged(object sender, EventArgs e)
        {
            string tekst = tbBrojLicne.Text;
            if (tekst.Length > 9)
            {
                tbBrojLicne.Text = tekst.Substring(0, tekst.Length - 1);
                tbBrojLicne.Select(tekst.Length, 0);
            }
            
        }

        private void btPrihvacena_Click(object sender, EventArgs e)
        {
            Gdomacica gd = new Gdomacica(tbIme.Text, tbPrezime.Text, tbDevojackoPrezime.Text, dateTimePicker1.Value, tbJMBG.Text, tbBrojLicne.Text, tbAdresa.Text, tbTelefon.Text, tbMobilni.Text, tbEmail.Text, tbObrazovanje.Text, tbRadnoIskustvo.Text, tbHobi.Text, new bulstring(cbAlergije.Checked, tbAlergije.Text), new bulstring(cbFizickaOgrc.Checked, tbFizickaOgrc.Text), new bulstring(cbZdravstveniProb.Checked, tbZdravstveniProblemi.Text), new bulstring(cbOdbija.Checked, tbOdbijaDaRadi.Text));
;
            
        }
    }
}
