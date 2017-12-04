using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CompteBancaire
    {
        #region Membres de la classe
        private string Nom { get; set; }
        private string Prenom { get; set; }
        private string Numero { get; set; }
        private float Solde { get; set; }
        private Transaction1[] ListeTransactions { get; set; }
        private List<Transaction1> ListeTransactions1 { get; set; }
        private int NombreTransaction { get; set; }
        #endregion


        /*#region Propriété de la classe
        public string Nom
        {
            get
            {
                return _Nom;
            }
            set
            {
                _Nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _Prenom;
            }
            set
            {
                _Prenom = value;
            }
        }

        public string Numero
        {
            get
            {
                return _Numero;
            }
        }

        public float Solde
        {
            get
            {
                return _Solde;
            }
            set
            {
                _Solde = value;
            }
        }
        #endregion*/

        public CompteBancaire(String Nom, String Prenom, String Numero, float Solde = 0)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Numero = Numero;
            this.Solde = Solde;
            this.ListeTransactions = new Transaction1[255];
            this.ListeTransactions1 = new List<Transaction1>();
            this.NombreTransaction = 0;
        }

        public float Depot(float montant)
        {
            /* Méthode 1
             * Transaction tr = new Transaction(montant, DateTime.Now);
             * 
             * Méthode 2
             * Transaction1 tr1 = new Transaction1();
             * tr1.Montant = montant;
             * tr1.Date = DateTime.Now;
             *
             * Méthode 3
             */
            Transaction1 tr1bis = new Transaction1
            {
                Montant = montant,
                Date = DateTime.Now
            };
            this.ListeTransactions[this.NombreTransaction] = tr1bis;
            this.NombreTransaction++;
            this.ListeTransactions1.Add(tr1bis);
            this.Solde += montant;
            return this.Solde;
        }

        public float Retrait(float montant)
        {
            if(montant <= this.Solde)
            {
                Transaction1 tr1bis = new Transaction1
                {
                    Montant = montant,
                    Date = DateTime.Now
                };
                this.ListeTransactions[this.NombreTransaction] = tr1bis;
                this.NombreTransaction++;
                this.ListeTransactions1.Add(tr1bis);
                this.Solde -= montant;
                return this.Solde;
            }
            else
            {
                throw new Exception("Transaction impossible");
            }
        }
    }
}