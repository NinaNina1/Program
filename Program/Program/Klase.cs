using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Program
{

   public class Gdomacica
    {
        public string ime;
        public string prezime;
        public string dprezime;
        public DateTime dtmrodjenja;
        public string JMBG;
        public string BrLK;
        public string Adresa;
        public string brTel;
        public string brMobTel;
        public string email;
        public string obrazovanje;
        public string radnoIskustvo;
        public bool pusac;
        public string hobi;
        public string alergije, FOgranicenja, ZdrProb, OdbRadi;
        public Gdomacica(string ime, string prezime, string dprezime, DateTime dtmrodjenja, string JMBG, string BrLK, string Adresa, string brTel, string brMobTel, string email, string obrazovanje, string radnoIskustvo, string hobi, bool pusac, string alergije, string FOgranicenja, string ZdrProb, string OdbRadi)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.dprezime = dprezime;
            this.dtmrodjenja = dtmrodjenja;
            this.JMBG = JMBG;
            this.BrLK = BrLK;
            this.Adresa = Adresa;
            this.brTel = brTel;
            this.brMobTel = brMobTel;
            this.email = email;
            this.obrazovanje = obrazovanje;
            this.radnoIskustvo = radnoIskustvo;
            this.hobi = hobi;
            this.alergije = alergije;
            this.FOgranicenja = FOgranicenja;
            this.ZdrProb = ZdrProb;
            this.OdbRadi = OdbRadi;
            this.pusac = pusac;
        }

        public Gdomacica(StreamReader sr, ref Boolean ispravnost)
        {
            try
            {
                this.ime = sr.ReadLine();
                this.prezime = sr.ReadLine();
                this.dprezime = sr.ReadLine();
                this.dtmrodjenja = new DateTime(Convert.ToInt32(sr.ReadLine()), Convert.ToInt32(sr.ReadLine()), Convert.ToInt32(sr.ReadLine()));
                this.JMBG = sr.ReadLine();
                this.BrLK = sr.ReadLine();
                string pomocni = sr.ReadLine();
                this.Adresa = "";
                while (pomocni != "* * * * * * * * * *")
                {
                    this.Adresa += pomocni;
                    pomocni = sr.ReadLine();
                }
                this.brTel = sr.ReadLine();
                this.brMobTel = sr.ReadLine();
                this.email = sr.ReadLine();
                this.obrazovanje = "";
                pomocni = sr.ReadLine();
                while (pomocni != "-* * * * * * * * * *-")
                {
                    this.obrazovanje += pomocni;
                    pomocni = sr.ReadLine() + "\n";
                }
                pomocni = sr.ReadLine();
                this.radnoIskustvo = "";
                while (pomocni != "+* * * * * * * * * *+")
                {
                    this.radnoIskustvo += pomocni;
                    pomocni = sr.ReadLine() + "\n";
                }
                this.pusac = Convert.ToBoolean(sr.ReadLine());
                this.alergije = sr.ReadLine();
                this.FOgranicenja = sr.ReadLine();
                this.ZdrProb = sr.ReadLine();
                this.OdbRadi = sr.ReadLine();
                this.hobi = sr.ReadLine();
                if (sr.ReadLine() == "====================")
                    ispravnost = true;
                else
                    ispravnost = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Tehnicka Greska");
                throw;
            }
            
        }

        public string PunoIme()
        {
            return ime + " " + prezime;
        }

    }




}