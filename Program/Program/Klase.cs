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
                ime = sr.ReadLine();
                prezime = sr.ReadLine();
                dprezime = sr.ReadLine();
                dtmrodjenja = new DateTime(Convert.ToInt32(sr.ReadLine()), Convert.ToInt32(sr.ReadLine()), Convert.ToInt32(sr.ReadLine()));
                JMBG = sr.ReadLine();
                BrLK = sr.ReadLine();
                string pomocni = sr.ReadLine();
                Adresa = "";
                while (pomocni != "* * * * * * * * * *")
                {
                    this.Adresa += pomocni;
                    pomocni = sr.ReadLine();
                }
                brTel = sr.ReadLine();
                brMobTel = sr.ReadLine();
                email = sr.ReadLine();
                obrazovanje = "";
                pomocni = sr.ReadLine();
                while (pomocni != "-* * * * * * * * * *-")
                {
                    obrazovanje += pomocni + "\n";
                    pomocni = sr.ReadLine();
                }
                pomocni = sr.ReadLine();
                radnoIskustvo = "";
                while (pomocni != "+* * * * * * * * * *+")
                {
                    radnoIskustvo += pomocni + "\n";
                    pomocni = sr.ReadLine();
                }
                pusac = Convert.ToBoolean(sr.ReadLine());
                alergije = sr.ReadLine();
                FOgranicenja = sr.ReadLine();
                ZdrProb = sr.ReadLine();
                OdbRadi = sr.ReadLine();
                hobi = sr.ReadLine();
                if (sr.ReadLine() == "====================")
                    ispravnost = true;
                else
                    ispravnost = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Tehnicka Greska");
            }
            
        }
        public void Upis()
        {
            StreamWriter sw = new StreamWriter(Globalne.pathgd);
            sw.WriteLine(ime);
            sw.WriteLine(prezime);
            sw.WriteLine(dprezime);
            sw.WriteLine(dtmrodjenja.Year.ToString());
            sw.WriteLine(dtmrodjenja.Month.ToString());
            sw.WriteLine(dtmrodjenja.Day.ToString());
            sw.WriteLine(JMBG);
            sw.WriteLine(BrLK);
            sw.Write(Adresa);
            sw.WriteLine("\n"+"* * * * * * * * * *");
            sw.WriteLine(brTel);
            sw.WriteLine(brMobTel);
            sw.WriteLine(email);
            sw.Write(obrazovanje);
            sw.WriteLine("\n"+"-* * * * * * * * * *-");
            sw.Write(radnoIskustvo);
            sw.WriteLine("\n" + "+* * * * * * * * * *+");
            sw.WriteLine(pusac.ToString());
            sw.WriteLine(alergije);
            sw.WriteLine(FOgranicenja);
            sw.WriteLine(ZdrProb);
            sw.WriteLine(OdbRadi);
            sw.WriteLine(hobi);
            sw.WriteLine("====================");
            sw.Close();
                

        }

        public string PunoIme()
        {
            return ime + " " + prezime;
        }

    }




}