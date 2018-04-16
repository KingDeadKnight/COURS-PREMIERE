using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pile<T>
    {

        private T[] tab;
        private int nbrElements;

        public Pile(int nbrElements = 0)
        {
            this.nbrElements = nbrElements;
            this.tab = new T[nbrElements];
        }

        public int Count
        {
            get
            {
                return this.tab.Length;
            }

        }

        public void Push(T i)
        {
            this.nbrElements++;
            T[] temp = new T[this.nbrElements];
            Array.Copy(this.tab, temp, this.nbrElements-1);
            temp[nbrElements - 1] = i;
            this.tab = temp;
        }

        public void Pop()
        {
            if(this.nbrElements == 0)
            {
                throw new Exception("Pile vide");
            }
            this.nbrElements--;
            T[] temp = new T[this.nbrElements];
            Array.Copy(this.tab, temp, this.nbrElements);
        }
    
        public void Clear()
        {
            this.tab = new T[0];
            this.nbrElements = 0;
        }
        
    }
}
