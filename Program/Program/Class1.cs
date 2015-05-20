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

    }

    public struct bulstring
    {
        public string tekst;
        public bool bul;
    }

}