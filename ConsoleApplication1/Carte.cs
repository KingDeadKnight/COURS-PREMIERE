using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Carte
    {

        //public string[] C { get; private set; }
        //public int NB { get; set; }
        //public string[] Package { get; private set; }

        //public Random random = new Random();

        //public Carte(bool empty = false)
        //{
        //    if (empty)
        //    {
        //        this.C = new string[52];
        //        this.Package = this.C;
        //        this.NB = 0;
        //        return;
        //    }
        //    else
        //    {
        //        this.C = new string[] { "1K", "2K", "3K", "4K", "5K", "6K", "7K", "8K", "9K", "10K", "11K", "12K", "13K", "1C", "2C", "3C", "4C", "5C", "6C", "7C", "8C", "9C", "10C", "11C", "12C", "13C", "1T", "2T", "3T", "4T", "5T", "6T", "7T", "8T", "9T", "10T", "11T", "12T", "13T", "1P", "2P", "3P", "4P", "5P", "6P", "7P", "8P", "9P", "10P", "11P", "12P", "13P" };
        //        this.Package = this.C;
        //        this.NB = 52;
        //        return;
        //    }
        //}



        //public void Show(int i)
        //{
        //    Console.WriteLine(this.Package[i]);
        //}

        //public void ShowAll()
        //{
        //    Console.WriteLine(string.Join(",", this.Package));
        //}

        //public void ShowNumber()
        //{
        //    Console.WriteLine(this.NB);
        //}

        //private void Swap2(int first, int second)
        //{
        //    string temp = this.Package[first];
        //    this.Package[first] = this.Package[second];
        //    this.Package[second] = temp;
        //}

        //public void SwapRandom()
        //{
        //    int r1 = random.Next(0, 52);
        //    int r2 = random.Next(0, 52);
        //    Swap2(r1, r2);
        //}

        //public void Blend(int cb)
        //{
        //    for(int i = 0; i < cb; i++)
        //    {
        //        SwapRandom();
        //    }
        //}

        //public void Add()
        //{
        //    if(this.Package.Length < 52)
        //    {
        //        string[] temp = this.C.Except(this.Package).ToArray();
        //        List<string> temp1 = this.Package.ToList();
        //        int r1 = this.random.Next(0, temp.Length-1);
        //        temp1.Add(temp[r1]);
        //        this.Package = temp1.ToArray();
        //        this.NB++;
        //    }
        //}

        //public void Remove()
        //{
        //    if (this.Package.Length > 0)
        //    {
        //        List<string> temp = this.Package.ToList();
        //        temp.RemoveAt(Package.Length - 1);
        //        this.Package = temp.ToArray();
        //        this.NB--;
        //    }
        //}

        int[,] c;
        public int nb;
        Random r = new Random();
        public Carte()
        {
            c = new int[52, 2];
            for (int i = 0; i < 52; i++)
            {
                c[i, 0] = (i % 13) + 1;
                c[i, 1] = (i / 13);
            }
            nb = 52;
        }
        public Carte(int taille)
        {
            c = new int[52, 2];
            for (int i = 0; i < taille; i++)
            {
                c[i, 0] = (i % 13) + 1;
                c[i, 1] = (i / 13);
            }
            nb = taille;
        }
        public void affiche(int i)
        {
            if (c[i, 0] < 10) Console.Write(c[i, 0]);
            else
            {
                switch (c[i, 0])
                {
                    case 10:
                        Console.Write('T');
                        break;

                    case 11:
                        Console.Write('J');
                        break;
                    case 12:
                        Console.Write('Q');
                        break;
                    case 13:
                        Console.Write('K');
                        break;

                }
            }
            switch (c[i, 1])
            {
                case 0:
                    Console.Write('C');
                    break;
                case 1:
                    Console.Write('K');
                    break;
                case 2:
                    Console.Write('P');
                    break;
                case 3:
                    Console.Write('T');
                    break;

            }
            Console.Write(' ');
        }

        public void affiche_all()
        {
            for (int i = 0; i < nb; i++)
            {
                this.affiche(i);
            }
            Console.WriteLine();

        }

        private void swap2(int a, int b)
        {

            int temp_valeur = c[a, 0]; int temp_couleur = c[a, 1];
            c[a, 0] = c[b, 0]; c[a, 1] = c[b, 1];
            c[b, 0] = temp_valeur; c[b, 1] = temp_couleur;

        }
        public void swap_random()
        {
            //Random r = new Random();
            int r1 = r.Next(0, nb);
            int r2 = r.Next(0, nb);
            //Console.Write(r1 + " " + r2 + " " + " |");
            this.swap2(r1, r2);
        }
        public void melange(int cb)
        {
            for (int i = 0; i < cb; i++)
            {
                this.swap_random();
            }
        }
        public bool ajoute(int val, int coul)
        {
            if (nb > 51) return false;
            else
            {
                c[nb, 0] = val;
                c[nb, 1] = coul;
                nb++;
                return true;
            }

        }
        public bool retire(ref int val, ref int coul)
        {
            if (nb > 0)
            {
                val = c[0, 0];
                coul = c[0, 1];
                for (int i = 0; i < nb - 1; i++)
                {
                    c[i, 0] = c[i + 1, 0];
                    c[i, 1] = c[i + 1, 1];

                }
                nb--;
                return true;
            }
            else return false;

        }
    }
}
