using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Garage
{
    class Camion : Vehicule
    {

        private int NbreEssieux;
        public int ChargeUtile;

        public Camion(string Marque, string Modele, int Cylindree, int Annee, int NbreEssieux, int ChargeUtile) : base(Marque, Modele, Cylindree, Annee)
        {
            this.NbreEssieux = NbreEssieux;
            this.ChargeUtile = ChargeUtile;
        }

        public override string ToString()
        {
            return "Camion";
        }
    }
}
