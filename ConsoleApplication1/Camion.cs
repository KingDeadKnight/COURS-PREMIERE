using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApplication1
{
    class Camion : Vehicule{
        
        private int NbreEssieux;

        public Camion(string Marque, string Modele, int Cylindree, int Annee, int NbreEssieux) : base(Marque, Modele, Cylindree, Annee){
            this.NbreEssieux = NbreEssieux;
        }
    }
}