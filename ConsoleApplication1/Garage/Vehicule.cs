using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Garage
{
    abstract class Vehicule //Utilité: Ne pas pouvoir l'instancier
    {
        public string Marque; //Accessible par un objet
        private string Modele; //Non accessible par un objet ni par les classes derivées
        private int Cylindree;
        protected int Annee; //Non accessible par un objet mais accessible par les classes dérivées

        public Vehicule(string Marque, string Modele, int Cylindree, int Annee)
        {
            this.Marque = Marque;
            this.Modele = Modele;
            this.Cylindree = Cylindree;
            this.Annee = Annee;
        }

        public override string ToString()
        {
            string res = this.Marque + " " + this.Modele + " de " + this.Annee + " avec " + this.Cylindree + "CV";
            return res;
        }

        //public abstract int GetAnnee(); Ne demande pas de corps, mais doit être défini dans les classes dérivées
    }
}
