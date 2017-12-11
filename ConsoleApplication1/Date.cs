using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Date
    {
        public int Jour { get; private set; }
        public int Mois { get; private set; }
        public int Annee { get; private set; }
        private int[,] DayByMonth = new int[,] { { 31, 31 }, { 28, 29 }, { 31, 31 }, { 30, 30 }, { 31, 31 }, { 30, 30 }, { 31, 31 }, { 31, 31 }, { 30, 30 }, { 31, 31 }, { 30, 30 }, { 31, 31 } };

        public Date(int Jour, int Mois, int Annee)
        {
            if(Mois < 1 && Mois > 12)
            {
                throw new Exception("Format de date mauvais");
            }
            else
            {
                if (Jour < 1 && Jour > DayByMonth[Mois -1, IsBissextile(Annee)])
                {
                        throw new Exception("Format de date mauvais");
                }
            }
            this.Jour = Jour;
            this.Mois = Mois;
            this.Annee = Annee;
        }

        private int IsBissextile(int annee)
        {
            if ((annee % 4 == 0 && annee % 100 != 0) || (annee % 400 == 0)) return 1;
            return 0;
        }

        public static bool operator == (Date lop, Date rop)
        {
            bool compare = (lop.Jour == rop.Jour && lop.Mois == rop.Mois && lop.Annee == rop.Annee);
            return compare;
        }

        public static bool operator != (Date lop, Date rop)
        {
            bool compare = (lop.Jour != rop.Jour || lop.Mois != rop.Mois || lop.Annee != rop.Annee);
            return compare;
        }
        
        public static Date operator + (Date lop, int jours)
        {
            int NouvJour = lop.Jour + jours;
            int NouvMois = lop.Mois;
            int NouvAn = lop.Annee;

            while(NouvJour > lop.DayByMonth[lop.Mois, lop.IsBissextile(lop.Annee)])
            {
                NouvJour -= lop.DayByMonth[lop.Mois, lop.IsBissextile(lop.Annee)];
                NouvMois++;
                if(NouvMois > 12)
                {
                    NouvMois -= 12;
                    NouvAn++;
                }
            }
            return new Date(NouvJour, NouvMois, NouvAn);
        }
    }
}
