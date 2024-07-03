using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitronApp1.BusinessLayer
{
    internal class OsnovnaKlasa
    {
        public int prviBroj { get; set; }
        public int drugiBroj { get; set; }

        public int rezultat { get; set;}

        public OsnovnaKlasa() {  prviBroj = 0; drugiBroj = 0; rezultat = 0;}

        public int Sabiranje(int prviBroj, int drugiBroj)
        {
            int rezultat = prviBroj + drugiBroj;
            return rezultat;
        }
        public int Oduzimanje(int prviBroj, int drugiBroj)
        {
            int rezultat = prviBroj - drugiBroj;
            return rezultat;
        }
        public int Mnozenje(int prviBroj, int drugiBroj)
        {
            int rezultat = prviBroj * drugiBroj;
            return rezultat;
        }
        public double Deljenje(double prviBroj, double drugiBroj)
        {
            if (drugiBroj == 0) { Console.WriteLine("Nemoguce je deliti sa 0"); return 0;  }
            else {
                double rezultat4 = prviBroj / drugiBroj;
                return rezultat4;
            }        
                
        }



    }
}
