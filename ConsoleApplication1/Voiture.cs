using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApplication1
{
    class Voiture : Vehicule{

        private int NbrePlaces;

        public Voiture(string Marque, string Modele, int Cylindree, int Annee, int NbrePlaces) : base(Marque, Modele, Cylindree, Annee){
            this.NbrePlaces = NbrePlaces;
        }

    }

}