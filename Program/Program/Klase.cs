using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Gdomacica
    {
        public string ime;
        public string prezime;
        public string dprezime;
        public DateTime dtmrodjenja;
        public long JMBG;
        public long BrLK;
        public string Adresa;
        public string brTel;
        public string brMobTel;
        public string email;
        public string obrazovanje;
        public string radnoIskustvo;
        public string hobi;
        public bulstring alergije, FOgranicenja, ZdrProb, OdbRadi;
        public Gdomacica(string ime, string prezime, string dprezime, DateTime dtmrodjenja, long JMBG, long BrLK, string Adresa, string brTel, string brMobTel, string email, string obrazovanje, string radnoIskustvo, string hobi, bulstring alergije, bulstring FOgranicenja, bulstring ZdrProb, bulstring OdbRadi)
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
        }

        public string PunoIme()
        {
            return ime + " " + prezime;
        }

    }

    public struct bulstring
    {
        public string tekst;
        public bool bul;
    }

}