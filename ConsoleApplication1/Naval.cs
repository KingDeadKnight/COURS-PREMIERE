using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Naval
    {

        int[,] grille;
        int nb_touche;
        Random r;

        public Naval()
        {
            this.r = new Random();
            this.grille = new int[10, 10];
            this.nb_touche = 0;
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    grille[x, y] = 0;
                }
            }
        }

        public void place(int a, int b)
        {
            if(a < 10 && b < 10)
            {
                this.grille[a, b] = 1;
            }
        }

        public void place_all(int nb)
        {
            for (int i = 0; i < nb; i++)
            {
                int randX = r.Next(0, 9);
                int randY = r.Next(0, 9);
                this.place(randX, randY);
            }
        }

        public bool tir(int a, int b)
        {
            if(a < 10 && b < 10)
            {
                if(this.grille[a, b] == 1)
                {
                    this.grille[a, b] = 3;
                    this.nb_touche++;
                    return true;
                }
                if(this.grille[a,b] == 0)
                {
                    this.grille[a, b] = 2;
                    return false;
                }
            }
            return false;
        }

        public int affiche()
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    switch(this.grille[x, y])
                    {
                        case 0:
                        case 1:
                            Console.Write("-");
                            break;
                        case 2:
                            Console.Write("x");
                            break;
                        case 3:
                            Console.Write("*");
                            break;
                    }
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("- : Eau");
            Console.WriteLine("x : Coup dans l'eau");
            Console.WriteLine("* : Touché");
            return this.nb_touche;
        }

        public int affiche_all()
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    switch (this.grille[x, y])
                    {
                        case 0:
                            Console.Write("-");
                            break;
                        case 1:
                            Console.Write("B");
                            break;
                        case 2:
                            Console.Write("x");
                            break;
                        case 3:
                            Console.Write("*");
                            break;
                    }
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("- : Eau");
            Console.WriteLine("B : Bateau");
            Console.WriteLine("x : Coup dans l'eau");
            Console.WriteLine("* : Touché");
            return this.nb_touche;
        }
    }
}
