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
    public partial class KreirajKorisnika : Form
    {
       
        public KreirajKorisnika()
        {
            InitializeComponent();
        }

        public void ispisiK(Korisnici k)
        {
            tbIme.Text = k.ime;
            tbPrezime.Text = k.prezime;
            dateTimeDatumRodjenja.Value = k.dtmrodjenja;
            tbAdresa.Text = k.adresa;

            if (k.bracnostanje == "Udata/Oženjen")
            { comboBoxBracnoStanje.SelectedValue = 0; }
            else if (k.bracnostanje == "Neudata/Neoženjen")
            { comboBoxBracnoStanje.SelectedValue = 1; }
            else { comboBoxBracnoStanje.SelectedValue = 2; }
            
            tbTelefon.Text = k.brTel;
            tbDeca.Text = k.deca;
            tbKontaktOsobaI.Text = k.kontakt1;
            tbKontaktOsobaTelefon1.Text = k.Telkontakt1;
            tbKontaktOsoba2.Text = k.kontakt2;
            tbKontaktOsoba2Telefon.Text = k.Telkontakt2;
            tbKontaktRodbinaPrijatelji.Text = k.kontaktkomsije;
            tbKucniLjubimac.Text = k.kucniljubimac;
            dateTimePickerOdKadaKoristiPomoc.Value = k.korisnikpomociod;
            tbPenzija.Text = k.penzija;
            tbOstalo.Text = k.ostalaprimanja;

            if (k.Gzavod == "Da")
            { comboBoxKorisnikGZavoda.SelectedValue = 0; }
            else
            { comboBoxKorisnikGZavoda.SelectedValue=1;}

            tbImeLekara.Text = k.nadlezni;
            tbUslugeUD3.Text = k.uslugeuD3;
            tbSredstvaZaLekove.Text = k.zaLekove;
            if (k.listaCekanja == "Da")
            { comboBoxListaCekanja.SelectedValue = 0; }
            else comboBoxListaCekanja.SelectedValue = 1;

            if (k.fizioterapeut == true)
            { cbFizioterapeut.Checked = true; }
            if (k.asistel == true)
            { cbAsistel.Checked = true; }
            if (k.spremanje == true)
            { cbSpremanjeStana.Checked = true; }
            tbDurgaPomoc.Text = k.drugaPomoc;

            if (k.zStatus == "Hronični bolesnik")
            { comboBoxZdravstevniStatus.SelectedValue = 0; }
            else if (k.zStatus == "Invalid")
            { comboBoxZdravstevniStatus.SelectedValue = 1; }
            else comboBoxZdravstevniStatus.SelectedValue=2;

            tbDijagnozaBolesti.Text=k.dijagnoza;

            if (k.mentalnoZdravlje=="Očuvano")
            {comboBoxMentalnoZdravlje.SelectedValue=0;}
            else if (k.mentalnoZdravlje=="Delimično očuvano")
            {comboBoxMentalnoZdravlje.SelectedValue=1;}
            else comboBoxMentalnoZdravlje.SelectedValue=2;

            if (k.sluh == "Dobar")
            { comboBoxSluh.SelectedValue = 0; }
            else if (k.sluh == "Narušen")
            { comboBoxSluh.SelectedValue = 1; }
            else comboBoxSluh.SelectedValue = 2;

            if (k.vid == "Dobar")
            { comboBoxVid.SelectedValue = 0; }
            else if (k.vid == "Narušen")
            { comboBoxVid.SelectedValue = 1; }
            else comboBoxVid.SelectedValue = 2;

            if (k.komunikacija == "Dobra")
            { comboBoxKomunikacija.SelectedValue = 0; }
            else comboBoxKomunikacija.SelectedValue = 1;

            if (k.fizPotrebe == "Potpuna")
            { comboBoxFizioloskePotrebe.SelectedValue = 0; }
            else if (k.fizPotrebe == "Delimična")
            { comboBoxFizioloskePotrebe.SelectedValue = 1; }
            else comboBoxFizioloskePotrebe.SelectedValue = 2;

            if (k.kretanje == "Polupokrtan")
            { comboBoxMogucnostKretanja.SelectedValue = 0; }
            else comboBoxMogucnostKretanja.SelectedValue = 1;

            if (k.ishrana == "Normalna")
            { comboBoxSposobnostIshrane.SelectedValue = 0; }
            else comboBoxSposobnostIshrane.SelectedValue = 1;

            if (k.gutanje=="Dobra")
            {comboBoxFunkcijaGutanja.SelectedValue=0;}
            else comboBoxFunkcijaGutanja.SelectedValue=1;

            tbPomocPriKupanju.Text=k.kupanje;
            tbPomocPriOblacenju.Text=k.oblacenje;
            tbHigijenskeNavike.Text=k.higijenskeNavike;

            if (k.orijentacija=="Prisutan/na")
                comboBoxOrijentacija.SelectedValue=0;
            else comboBoxOrijentacija.SelectedValue=1;

            if (k.narav=="Blaga")
                comboBoxNarav.SelectedValue=0;
            else comboBoxNarav.SelectedValue=1;

            if (k.prostor1 == "Odgovara")
            { comboBoxProstor1.SelectedValue = 0; }
            else comboBoxProstor1.SelectedValue = 1;

            if (k.prostor2 == "Uredan")
                comboBoxProstor2.SelectedValue = 0;
            else comboBoxProstor2.SelectedValue = 1;

            tbZagrevanjeProstora.Text = k.zagrevanjeProstora;
            tbHladjenjeProstora.Text = k.hladjenjeProstora;
            tbKljuceviOdStana.Text = k.kljuceviOdStana;
            tbIzmirivanjeObaveza.Text = k.problemiIzmirivanjeObaveza;

            if (k.drustveniZivot == "Aktivan")
            { comboBoxDrustveniZivot.SelectedValue = 0; }
            else if (k.drustveniZivot == "Delimično aktivan")
            { comboBoxDrustveniZivot.SelectedValue = 1; }
            else comboBoxDrustveniZivot.SelectedValue = 2;

            if (k.oporavak == "Redovno")
            { comboBoxOporavak.SelectedValue = 0; }
            else if (k.oporavak == "Povremeno")
            { comboBoxOporavak.SelectedValue = 1; }
            else comboBoxOporavak.SelectedValue = 2;

            if (k.klubzastare == true)
                cbKlubZaStare.Checked = true;
            if (k.pozoriste == true)
                cbPozoriste.Checked = true;
            if (k.crkva == true)
                cbCrkva.Checked = true;
            if (k.biblioteka == true)
                cbBiblioteka.Checked = true;

            tbKoImJePomagaoPre.Text = k.prethodnapomoc;
            tbPosebniZahtevi.Text = k.zahteviIkomentari;


            

        
        }

        private void KreirajKorisnika_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxKomunikacija_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxNarav_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void comboBoxProstor2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
