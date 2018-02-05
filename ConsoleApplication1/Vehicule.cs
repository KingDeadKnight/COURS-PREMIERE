using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApplication1
{
    class Vehicule
    {
        
        private string Marque;
        private string Modele;
        private int Cylindree;
        private int Annee;

        public Vehicule(string Marque, string Modele, int Cylindree, int Annee){
            this.Marque = Marque;
            this.Modele = Modele;
            this.Cylindree = Cylindree;
            this.Annee = Annee;
        }
        
    }
}