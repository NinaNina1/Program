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
        public static readonly string pathbaze = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FNBaza");

    }
}
