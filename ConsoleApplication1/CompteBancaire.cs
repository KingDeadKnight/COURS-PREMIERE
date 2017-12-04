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
        private string _Nom;
        private string _Prenom;
        private string _Numero;
        private float _Solde;
        #endregion

        
        #region Propriété de la classe
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
        #endregion

        public CompteBancaire(String Nom, String Prenom, String Numero, float Solde = 0)
        {
            _Nom = Nom;
            _Prenom = Prenom;
            _Numero = Numero;
            _Solde = Solde;
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
            _Solde += montant;
            return _Solde;
        }

        public float Retrait(float montant)
        {
            if(montant <= _Solde)
            {
                Transaction1 tr1bis = new Transaction1
                {
                    Montant = montant,
                    Date = DateTime.Now
                };
                _Solde -= montant;
                return _Solde;
            }
            else
            {
                throw new Exception("Transaction impossible");
            }
        }
    }
}