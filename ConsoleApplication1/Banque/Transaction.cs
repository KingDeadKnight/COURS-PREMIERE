using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Banque
{
    class Transaction
    {
        public float Montant;
        public DateTime Date;

        public Transaction(float Montant, DateTime Date)
        {
            this.Montant = Montant;
            this.Date = Date;
        }
    }

    class Transaction1
    {
        public float Montant { get; set; }
        public DateTime Date { get; set; }
    }
}
