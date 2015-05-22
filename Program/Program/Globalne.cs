using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Program
{
    class Globalne
    {
        public static SortedDictionary<string, Gdomacica> poImenu = new SortedDictionary<string, Gdomacica>();
        public static SortedDictionary<string, Gdomacica> poPrezimenu = new SortedDictionary<string, Gdomacica>();
        public static Dictionary<string, Gdomacica> poJMBG = new Dictionary<string, Gdomacica>();
        public static int brojGdomacica;
        public static int brojKorisnika;
        public static readonly string pathfolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FNBaza");
        public static readonly string pathgd = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FNBaza", "gd.data");
        public static readonly string pathkor = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FNBaza", "kor.data");
        public static readonly string pathsettings = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FNBaza", "settings.op");
    }
}
