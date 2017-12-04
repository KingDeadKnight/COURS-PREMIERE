using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Date
    {
        private int Jour { get; set; }
        private int Mois { get; set; }
        private int Annee { get; set; }
        private int[,] DayByMonth = new int[,] { { 31, 31 }, { 28, 29 }, { 31, 31 }, { 30, 30 }, { 31, 31 }, { 30, 30 }, { 31, 31 }, { 31, 31 }, { 30, 30 }, { 31, 31 }, { 30, 30 }, { 31, 31 } };

        public Date(int Jour, int Mois, int Annee)
        {
            if(Mois < 1 && Mois > 12)
            {
                throw new Exception("Format de date mauvais");
            }
            else
            {
                if (this.IsBissextile(Annee))
                {
                    if(Jour < 1 && Jour > DayByMonth[Mois -1, 1])
                    {
                        throw new Exception("Format de date mauvais");
                    }
                }
                else
                {
                    if (Jour < 1 && Jour > DayByMonth[Mois - 1, 0])
                    {
                        throw new Exception("Format de date mauvais");
                    }
                }
            }
        }

        private bool IsBissextile(int annee)
        {
            if ((annee % 4 == 0 && annee % 100 != 0) || (annee % 400 == 0)) return true;
            return false;
        }

        
    }
}
