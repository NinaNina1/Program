using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Program
{
    public class Korisnici
    {
        public string ime;
        public string prezime;
        public DateTime dtmrodjenja;
        public string adresa;
        public string bracnostanje;
        public string brTel;
        public string deca;
        public string kontakt1;
        public string Telkontakt1;
        public string kontakt2;
        public string Telkontakt2;
        public string kontaktkomsije;
        public string kucniljubimac;
        public DateTime korisnikpomociod;
        public string penzija;
        public string ostalaprimanja;
        public string Gzavod;
        public string nadlezni;
        public string uslugeuD3;
        public string zaLekove;
        public string listaCekanja;
        public bool fizioterapeut;
        public bool asistel;
        public bool spremanje;
        public string drugaPomoc;
        public string zStatus;
        public string dijagnoza;
        public string mentalnoZdravlje;
        public string sluh;
        public string vid;
        public string komunikacija;
        public string fizPotrebe;
        public string kretanje;
        public string ishrana;
        public string gutanje;
        public string kupanje;
        public string oblacenje;
        public string higijenskeNavike;
        public string orijentacija;
        public string narav;
        public string prostor1;
        public string prostor2;
        public string zagrevanjeProstora;
        public string hladjenjeProstora;
        public string kljuceviOdStana;
        public string problemiIzmirivanjeObaveza;
        public string drustveniZivot;
        public string oporavak;
        public bool klubzastare;
        public bool pozoriste;
        public bool crkva;
        public bool biblioteka;
        public string prethodnapomoc;
        public string zahteviIkomentari;

        public Korisnici(string ime, string prezime, DateTime dtmrodjenja, string adresa, string bracnostanje, string brTel, string deca, string kontakt1, string TelKontakt1, string kontakt2, string Telkontakt2, string kontaktkomsije, string kucniljubimac, DateTime korisnikpomociod, string penzija, string ostalaprimanja, string Gzavod, string nadlezni, string uslugeuD3, string zaLekove, string listaCekanja, bool fizioterapeut, bool asistel, bool spremanje, string drugaPomoc, string zStatus, string dijagnoza, string mentalnoZdravlje, string sluh, string vid, string komunikacija, string fizPotrebe, string kretanje, string ishrana, string gutanje, string kupanje, string oblacenje, string higijenskeNavike, string orijentacija, string narav, string prostor1, string prostor2, string zagrevanjeProstora, string hladjenjeProstora, string kljuceviOdStana, string problemiIzmirivanjeObaveza, string drustveniZivot, string oporavak, bool klubzastare, bool pozoriste, bool crkva, bool biblioteka, string prethodnapomoc, string zahteviIkomentari)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.dtmrodjenja = dtmrodjenja;
            this.adresa = adresa;
            this.bracnostanje = bracnostanje;
            this.brTel = brTel;
            this.deca = deca;
            this.kontakt1 = kontakt1;
            this.Telkontakt1 = TelKontakt1;
            this.kontakt2 = kontakt2;
            this.Telkontakt2 = Telkontakt2;
            this.kontaktkomsije = kontaktkomsije;
            this.kucniljubimac = kucniljubimac;
            this.korisnikpomociod = korisnikpomociod;
            this.penzija = penzija;
            this.ostalaprimanja = ostalaprimanja;
            this.Gzavod = Gzavod;
            this.nadlezni = nadlezni;
            this.uslugeuD3 = uslugeuD3;
            this.zaLekove = zaLekove;
            this.listaCekanja = listaCekanja;
            this.fizioterapeut = fizioterapeut;
            this.asistel = asistel;
            this.spremanje = spremanje;
            this.drugaPomoc = drugaPomoc;
            this.zStatus = zStatus;
            this.dijagnoza = dijagnoza;
            this.mentalnoZdravlje = mentalnoZdravlje;
            this.sluh = sluh;
            this.vid = vid;
            this.komunikacija = komunikacija;
            this.fizPotrebe = fizPotrebe;
            this.kretanje = kretanje;
            this.ishrana = ishrana;
            this.gutanje = gutanje;
            this.kupanje = kupanje;
            this.oblacenje = oblacenje;
            this.higijenskeNavike = higijenskeNavike;
            this.orijentacija = orijentacija;
            this.narav = narav;
            this.prostor1 = prostor1;
            this.prostor2 = prostor2;
            this.zagrevanjeProstora = zagrevanjeProstora;
            this.hladjenjeProstora = hladjenjeProstora;
            this.kljuceviOdStana = kljuceviOdStana;
            this.problemiIzmirivanjeObaveza = problemiIzmirivanjeObaveza;
            this.drustveniZivot = drustveniZivot;
            this.oporavak = oporavak;
            this.klubzastare = klubzastare;
            this.pozoriste = pozoriste;
            this.crkva = crkva;
            this.biblioteka = biblioteka;
            this.prethodnapomoc = prethodnapomoc;
            this.zahteviIkomentari = zahteviIkomentari;

        }

        public Korisnici(StreamReader sr, ref Boolean ispravnost)
        {
            try
            {
                ime = sr.ReadLine();
                prezime = sr.ReadLine();
                dtmrodjenja = new DateTime(Convert.ToInt32(sr.ReadLine()), Convert.ToInt32(sr.ReadLine()), Convert.ToInt32(sr.ReadLine()));
                adresa = "";
                string pom = sr.ReadLine();
                while (pom != "* * * * * * * * * *")
                {
                    adresa += pom;
                    pom = sr.ReadLine();
                }

                bracnostanje = sr.ReadLine();
                brTel = sr.ReadLine();
                deca = "";
                pom = sr.ReadLine();
                while (pom != "* * * * * * * * * *")
                {
                    deca += pom;
                    pom = sr.ReadLine();
                }
                kontakt1 = sr.ReadLine();
                Telkontakt1 = sr.ReadLine();
                kontakt2 = sr.ReadLine();
                Telkontakt2 = sr.ReadLine();
                kontaktkomsije = sr.ReadLine();
                penzija = sr.ReadLine();
                ostalaprimanja = sr.ReadLine();
                Gzavod = sr.ReadLine();
                nadlezni = sr.ReadLine();
                uslugeuD3 = sr.ReadLine();
                zaLekove = sr.ReadLine();
                listaCekanja = sr.ReadLine();
                fizioterapeut = Convert.ToBoolean(sr.ReadLine());
                asistel = Convert.ToBoolean(sr.ReadLine());
                spremanje = Convert.ToBoolean(sr.ReadLine());
                drugaPomoc = sr.ReadLine();
                zStatus = sr.ReadLine();
                dijagnoza = "";
                pom = sr.ReadLine();
                while (pom != "* * * * * * * * * *")
                {
                    dijagnoza += pom;
                    pom = sr.ReadLine();
                }
                mentalnoZdravlje = sr.ReadLine();
                sluh = sr.ReadLine();
                vid = sr.ReadLine();
                komunikacija = sr.ReadLine();
                fizPotrebe = sr.ReadLine();
                kretanje = sr.ReadLine();
                ishrana = sr.ReadLine();
                gutanje = sr.ReadLine();
                kupanje = sr.ReadLine();
                oblacenje = sr.ReadLine();
                higijenskeNavike = sr.ReadLine();
                orijentacija = sr.ReadLine();
                narav = sr.ReadLine();
                prostor1 = sr.ReadLine();
                prostor2 = sr.ReadLine();
                zagrevanjeProstora = sr.ReadLine();
                hladjenjeProstora = sr.ReadLine();
                kljuceviOdStana = sr.ReadLine();
                problemiIzmirivanjeObaveza = sr.ReadLine();
                drustveniZivot = sr.ReadLine();
                oporavak = sr.ReadLine();
                klubzastare = Convert.ToBoolean(sr.ReadLine());
                pozoriste = Convert.ToBoolean(sr.ReadLine());
                crkva = Convert.ToBoolean(sr.ReadLine());
                biblioteka = Convert.ToBoolean(sr.ReadLine());
                prethodnapomoc = sr.ReadLine();
                zahteviIkomentari = "";
                pom = sr.ReadLine();
                while (pom != "* * * * * * * * * *")
                {
                    zahteviIkomentari += pom;
                    pom = sr.ReadLine();
                }
                if (sr.ReadLine() == "====================") ispravnost = true;
                else ispravnost = false;



            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Tehnička greška"); }

 
        }

        public void Upis()
        {
            StreamWriter sw = new StreamWriter(Globalne.pathkor, true);
            sw.WriteLine(ime);
            sw.WriteLine(prezime);
            sw.WriteLine(dtmrodjenja.Year.ToString());
            sw.WriteLine(dtmrodjenja.Month.ToString());
            sw.WriteLine(dtmrodjenja.Day.ToString());
            sw.Write(adresa);
            sw.WriteLine();
            sw.WriteLine("* * * * * * * * * *");
            sw.WriteLine(bracnostanje);
            sw.WriteLine(brTel);
            sw.Write(deca);
            sw.WriteLine();
            sw.WriteLine("* * * * * * * * * *");
            sw.WriteLine(kontakt1);
            sw.WriteLine(Telkontakt1);
            sw.WriteLine(kontakt2);
            sw.WriteLine(Telkontakt2);
            sw.WriteLine(kontaktkomsije);
            sw.WriteLine(penzija);
            sw.WriteLine(ostalaprimanja);
            sw.WriteLine(Gzavod);
            sw.WriteLine(nadlezni);
            sw.WriteLine(uslugeuD3);
            sw.WriteLine(zaLekove);
            sw.WriteLine(listaCekanja);
            sw.WriteLine(fizioterapeut.ToString());
            sw.WriteLine(asistel.ToString());
            sw.WriteLine(spremanje.ToString());
            sw.WriteLine(drugaPomoc);
            sw.WriteLine(zStatus);
            sw.Write(dijagnoza);
            sw.WriteLine();
            sw.WriteLine("* * * * * * * * * *");
            sw.WriteLine(mentalnoZdravlje);
            sw.WriteLine(sluh);
            sw.WriteLine(vid);
            sw.WriteLine(komunikacija);
            sw.WriteLine(fizPotrebe);
            sw.WriteLine(kretanje);
            sw.WriteLine(ishrana);
            sw.WriteLine(gutanje);
            sw.WriteLine(kupanje);
            sw.WriteLine(oblacenje);
            sw.WriteLine(higijenskeNavike);
            sw.WriteLine(orijentacija);
            sw.WriteLine(narav);
            sw.WriteLine(prostor1);
            sw.WriteLine(prostor2);
            sw.WriteLine(zagrevanjeProstora);
            sw.WriteLine(hladjenjeProstora);
            sw.WriteLine(kljuceviOdStana);
            sw.WriteLine(problemiIzmirivanjeObaveza);
            sw.WriteLine(drustveniZivot);
            sw.WriteLine(oporavak);
            sw.WriteLine(klubzastare.ToString());
            sw.WriteLine(pozoriste.ToString());
            sw.WriteLine(crkva.ToString());
            sw.WriteLine(biblioteka.ToString());
            sw.WriteLine(prethodnapomoc);
            sw.Write(zahteviIkomentari);
            sw.WriteLine();
            sw.WriteLine("* * * * * * * * * *");
            sw.WriteLine("====================");


        }

        public string punoime()
        {
            return ime + " " + prezime;
        }




    }
}