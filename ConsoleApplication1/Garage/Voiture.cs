using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Garage
{
    class Voiture : Vehicule
    {
        private int NbrePlaces;

        public Voiture(string Marque, string Modele, int Cylindree, int Annee, int NbrePlaces) : base(Marque, Modele, Cylindree, Annee)
        {
            this.NbrePlaces = NbrePlaces;
        }

        public override string ToString()
        {
            return "Voiture";
        }
    }
}
