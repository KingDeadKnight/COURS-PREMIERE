using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pile<T>
    {

        public T[] tab;
        public int nbrElements;

        public Pile(int nbrElements = 0)
        {
            this.nbrElements = nbrElements;
            this.tab = new T[nbrElements];
        }

        public void Ajouter(T i)
        {
            this.nbrElements++;
            T[] temp = new T[this.nbrElements];
            Array.Copy(this.tab, temp, this.nbrElements-1);
            temp[nbrElements - 1] = i;
            this.tab = temp;
        }

        public void Remove()
        {
            this.nbrElements--;
            T[] temp = new T[this.nbrElements];
            Array.Copy(this.tab, temp, this.nbrElements);
        }
        
    }
}
