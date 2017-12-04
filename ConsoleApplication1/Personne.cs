using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Etudiant
    {
        private string Nom { get; set; }
        private string _Matricule;

        public string Matricule
        {
            get
            {
                return this._Matricule;
            }
            private set
            {
                if (value.ToUpper().StartsWith("LA")) this._Matricule = value;
                else throw new Exception("Matricule erroné");
            }
        }

        public Etudiant(string Nom, string Matricule)
        {
            this.Nom = Nom;
            this.Matricule = Matricule;
        }
    }
}
