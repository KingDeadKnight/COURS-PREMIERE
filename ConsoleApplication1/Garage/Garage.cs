using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Garage
{
    class Garage
    {

        private Vehicule[] tab;
        public List<Vehicule> LstVehicules;

        public Garage(int taille)
        {
            this.LstVehicules = new List<Vehicule>();
            this.tab = new Vehicule[taille];
        }
    }
}
