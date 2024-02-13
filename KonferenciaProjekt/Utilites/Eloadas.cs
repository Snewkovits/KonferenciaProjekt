using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonferenciaProjekt
{
    internal class Eloadas
    {
        string cim;
        int sorDb;
        int helyDb;
        int[,] ertekeles;

        public string Cim { get => cim; }
        public int SorDb { get => sorDb; }
        public int HelyDb { get => helyDb; }
        public int[,] Ertekeles { get => ertekeles; }

        public Eloadas(string cim, int sorDb, int helyDb, int[,] ertekeles)
        {
            this.cim = cim;
            this.sorDb = sorDb;
            this.helyDb = helyDb;
            this.ertekeles = ertekeles;
        }
    }
}
