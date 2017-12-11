using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tp1Exercice3();
            //Tp1Exercice4();
            //Tp2Exercice1();
            //Tp2Exercice2();
            //Tp2Exercice3();
            //Tp2Exercice4();
            //Tp3Exercice1();
            //Tp3Exercice2();
            //Tp3Exercice3();
            //Tp4Exercice1();
            //Tp4Exercice2();
            //Tp4Exercice3();
            //TriABulle();
            //Tp4Exercice4();
            Date date = new Date(1, 2, 2010);
            Date date1 = date + 10;
        }

        public void Tp1Exercice4()
        {
            try {
                List<int> list = new List<int>();
                Console.Write("Introduisez le nombre a: ");
                list.Add(int.Parse(Console.ReadLine()));
                Console.Write("Introduisez le nombre b: ");
                list.Add(int.Parse(Console.ReadLine()));
                Console.Write("Introduisez le nombre c: ");
                list.Add(int.Parse(Console.ReadLine()));
                list.Sort();
                string res = "";
                foreach (int nb in list)
                {
                    res += nb + " ";
                }
                Console.WriteLine(res);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        public void Tp1Exercice3()
        {
            Console.Write("Quel est votre sexe ? (F/M) ");
            try
            {
                string sexe = Console.ReadLine();
                if (!(sexe == "F" || sexe == "M")) throw new Exception("Sexe inconnu");
                Console.Write("Quel est votre nom ? ");
                string nom = Console.ReadLine();
                Console.Write("Quel age avez vous ? ");
                int age = int.Parse(Console.ReadLine());
                switch (sexe)
                {
                    case "F":
                        if (age >= 18) Console.WriteLine("Bonjour Madame " + nom);
                        else Console.WriteLine("Bonjour Mademoiselle " + nom);
                        break;
                    case "M":
                        if (age >= 18) Console.WriteLine("Bonjour Monsieur " + nom);
                        else Console.WriteLine("Bonjour jeune homme " + nom);
                        break;
                }
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        public int Ask(string inconnu)
        {
            try
            {
                Console.Write("Introduisez le nombre " + inconnu + ": ");
                int a = int.Parse(Console.ReadLine());
                return a;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string CheckOp(string op)
        {
            if (op == "+" || op == "-" || op == "*" || op == "/" || op == "%") return op;
            throw new Exception("Opération inconnue");
        }

        public int Calcul(int a, int b, string op)
        {
            if (op == "+") return a + b;
            if (op == "-") return a - b;
            if (op == "*") return a * b;
            if (op == "/") return a / b;
            if (op == "%") return a % b;
            throw new Exception("Opération impossible");
        }

        public void Tp2Exercice1()
        {
            bool again = true;
            while (again)
            {
                try {
                    int a = Ask("a");

                    Console.Write("Introduisez l'opérateur: ");
                    string op = Console.ReadLine();
                    CheckOp(op);

                    int b = Ask("b");
                    Console.WriteLine("a " + op + " b = " + Calcul(a, b, op));
                    Console.Write("Voulez vous faire un autre calcul ? ");
                    if (Console.ReadLine() != "oui") again = false;
                    
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.Write("Voulez vous faire un autre calcul ? ");
                    if (Console.ReadLine() != "oui") again = false;
                }
            }
            Console.ReadLine();
        }

        public void Tp2Exercice2()
        {
            try
            {
                Console.Write("Introduisez la date: ");
                int date = int.Parse(Console.ReadLine());
                if (date < 0 && date > 31)
                {
                    throw new Exception("Date invalide");
                }
                Console.Write("Introduisez le mois: ");
                int mois = int.Parse(Console.ReadLine());
                if (mois > 12 && mois < 0)
                {
                    throw new Exception("Mois invalide");
                }
                String[] listemois = new String[] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
                Console.WriteLine(date + " " + listemois[mois - 1]);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        public void Tp2Exercice3()
        {
            bool ok = true;
            while (ok)
            {
                Console.Write("Introduisez la note: ");
                int note = int.Parse(Console.ReadLine());
                ok = false;
                if (note >= 0 && note < 50)
                {
                    Console.WriteLine("I");
                }
                if (note >= 50 && note < 60)
                {
                    Console.WriteLine("S");
                }
                if (note >= 60 && note < 80)
                {
                    Console.WriteLine("D");
                }
                if (note >= 80 && note < 90)
                {
                    Console.WriteLine("GD");
                }
                if (note >= 90 && note <= 100)
                {
                    Console.WriteLine("PGD");
                }
                else
                {
                    ok = true;
                    Console.WriteLine("Introduisez une note entre 0 et 100");
                }
            }
            Console.ReadLine();
        }

        public void Tp2Exercice4()
        {
            Console.WriteLine("Introduisez le nombre de personnes: ");
            int perso = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduisez la formation: ");
            string forma = Console.ReadLine();
            switch (forma)
            {
                case "Outlook":
                    Console.WriteLine("Le montant est de "+perso*250);
                    break;
                case "Photoshop":
                    Console.WriteLine("Le montant est de "+perso*3*300);
                    break;
                case "PHP":
                    Console.WriteLine("Le montant est de "+perso*3*350);
                    break;
                default:
                    Console.WriteLine("Formation inexistance");
                    break;
            }
            Console.ReadLine();
        }

        public void Tp3Exercice1()
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                while (true)
                {
                    string op = Console.ReadLine();
                    if (op == "=") break;
                    CheckOp(op);
                    int b = int.Parse(Console.ReadLine());
                    a = Calcul(a, b, op);
                }
                Console.WriteLine(a);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
                Console.ReadLine();
            }
        }

        public void Tp3Exercice2()
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int compteur = 1;
                while (true)
                {
                    int b = int.Parse(Console.ReadLine());
                    if (b == 0) break;
                    a += b;
                    compteur++;
                }
                Console.WriteLine("Somme: " + a);
                Console.WriteLine("Moyenne: " + a / compteur);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                Console.ReadLine();
            }
        }

        public int ConvertTimeToCentSec(String time)
        {
            string[] timea = time.Split(':');
            int sec = (int.Parse(timea[0])*60) + int.Parse(timea[1]);
            int centsec = (sec * 100) + int.Parse(timea[2]);
            return centsec;
        }

        public String ConvertCentToTimesec(int centsec)
        {
            int sec = centsec / 100;
            centsec = centsec % 100;
            int min = sec / 60;
            sec = sec % 60;
            return "" + min + ":" + sec + ":" + centsec;
        }

        public void Tp3Exercice3()
        {
            try
            {
                Regex regex = new Regex(@"^(([0-6]\d)|(\d)):(([0-6]\d)|(\d)):(0(\d){2}|(\d){2})$");
                Console.WriteLine("Entrez un temps du type: (x)x:xx:(0)xx");
                string a = Console.ReadLine();
                if (!regex.IsMatch(a)) throw new Exception("Le format de temps ne correspond pas");
                List<int> centsec = new List<int>();
                centsec.Add(ConvertTimeToCentSec(a));
                
                while (true)
                {
                    string b = Console.ReadLine();
                    if (b == "0") break;
                    if (!regex.IsMatch(b)) throw new Exception("Le format de temps ne correspond pas");
                    string[] timeb = b.Split(':');
                    centsec.Add(ConvertTimeToCentSec(b));
                    centsec.Sort();
                    Console.WriteLine("Plus petit temps: " + ConvertCentToTimesec(centsec[0]));
                    Console.WriteLine("Plus grand temps: " + ConvertCentToTimesec(centsec[centsec.Count - 1]));
                    Console.WriteLine("Moyenne des temps: " + ConvertCentToTimesec((int)centsec.Average()));
                }
                Console.WriteLine("Plus petit temps: " + ConvertCentToTimesec(centsec[0]));
                Console.WriteLine("Plus grand temps: " + ConvertCentToTimesec(centsec[centsec.Count - 1]));
                Console.WriteLine("Moyenne des temps: " + ConvertCentToTimesec((int)centsec.Average()));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                Console.ReadLine();
            }
        }

        public void Tp4Exercice1()
        {
            try
            {
                Console.WriteLine("Inserez un nombre: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(new string('*', i));
                }
                Console.Read();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }

        public void Tp4Exercice2()
        {
            try
            {
                Console.WriteLine("Inserez un nombre: ");
                int n = int.Parse(Console.ReadLine());
                int x = n + n - 1;
                int tmp = (x - 1) / 2;
                for (int i = 1; i <= n; i++, tmp--)
                {
                    Console.WriteLine(new string(' ', tmp) + new string('*', i + i - 1) + new string(' ', tmp));
                }
                Console.Read();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }

        public void Tp4Exercice3()
        {
            try
            {
                Console.WriteLine("Inserez une liste (chaque élément séparé par un virgule, sans espace): ");
                string a = Console.ReadLine();
                if (a.Contains(" ")) throw new FormatException();
                string[] taba = a.Split(',');
                Console.WriteLine("Inserez une autre liste (chaque élément séparé par un virgule, sans espace, de même taille que la précedente): ");
                a = Console.ReadLine();
                if (a.Contains(" ")) throw new FormatException();
                string[] tabb = a.Split(',');
                if (taba.Length != tabb.Length) throw new FormatException();
                for(int i = 0; i <= taba.Length - 1; i++)
                {
                    taba[i] = (int.Parse(taba[i]) + int.Parse(tabb[i])).ToString();
                }
                Console.WriteLine(string.Join(",", taba));
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }

        public void Tp4Exercice4()
        {
            try {
                Dictionary<string, int> article = new Dictionary<string, int>();
                article.Add("Frites", 1);
                article.Add("Grande Frites", 2);
                article.Add("Bicky", 3);
                article.Add("Bicky 3 Sauces", 4);
                article.Add("Mexicanos", 3);
                article.Add("Mexicanos 3 Sauces", 4);
                article.Add("Fricadelle", 2);
                article.Add("Fricadelle XL", 3);
                article.Add("Coca", 2);
                article.Add("Fanta", 2);
                foreach (KeyValuePair<string, int> kvp in article)
                {
                    Console.WriteLine(kvp.Key + ": " + kvp.Value + " euros");
                }
                while (true) {
                    Console.WriteLine("1.Modifier prix article\n2.Modifier type article\n3.Afficher prix d’un article(en indiquant le nom de cet article ou le numéro)\n4.Effacer un article\n5.Afficher la liste Article/Prix\n6.Quitter");
                    string a = Console.ReadLine();
                    string key;
                    int price;
                    switch (a)
                    {
                        case "1":
                            Console.WriteLine("Entrez l'article à modifier: ");
                            key = Console.ReadLine();
                            if(!article.ContainsKey(key)) throw new Exception("Element introuvable");
                            Console.WriteLine("Entrez le nouveau prix: ");
                            price = int.Parse(Console.ReadLine());
                            article[key] = price;
                            Console.WriteLine("L'article a été modifié");
                            break;
                        case "2":
                            Console.WriteLine("Entrez l'article à modifier: ");
                            key = Console.ReadLine();
                            if (!article.ContainsKey(key)) throw new Exception("Element introuvable");
                            Console.WriteLine("Entrez le nouveau type: ");
                            string newKey = Console.ReadLine();
                            price = article[key];
                            article.Remove(key);
                            article.Add(newKey, price);
                            Console.WriteLine("Le type a été modifié");
                            break;
                        case "3":
                            Console.WriteLine("Entrez l'article à afficher: ");
                            key = Console.ReadLine();
                            if (!article.ContainsKey(key)) throw new Exception("Element introuvable");
                            Console.WriteLine("Prix :" + article[key]);
                            break;
                        case "4":
                            Console.WriteLine("Entrez l'article à supprimer: ");
                            key = Console.ReadLine();
                            if (article.ContainsKey(key))
                            {
                                article.Remove(key);
                                Console.WriteLine("L'article a été supprimé");
                                break;
                            }
                            else throw new Exception("Element introuvable");
                        case "5":
                            foreach (KeyValuePair<string, int> kvp in article)
                            {
                                Console.WriteLine(kvp.Key + ": " + kvp.Value + " euros");
                            }
                            break;
                        case "6":
                            Console.WriteLine("A bientôt !");
                            Console.Read();
                            return;
                        default:
                            throw new Exception("Option introuvable");
                    }
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }

        public int CalculSurfaceRectangle(int longueur, int largeur)
        {
            return longueur * largeur;
        }

        public bool DetermineMajorité(int annee)
        {
            int age = CalculAge(annee);
            if (age >= 18) return true;
            return false;
        }

        public int CalculAge(int annee)
        {
            return 2017 - annee;
        }

        public bool CheckIsIn(int[] tab, int a)
        {
            for(int i = 0; i < tab.Length; i++)
            {
                if(tab[i] == a)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetIndex(int[] tab, int a)
        {
            int index = -1;
            for(int i = 0; i < tab.Length; i++)
            {
                if(tab[i] == a)
                {
                    index = i;
                }
            }
            if(index == -1)
            {
                throw new Exception("Element introuvable");
            }
            else
            {
                return index;
            }
        }

        public void InsertInTab(int[] tab, int index, int a)
        {
            Console.WriteLine(string.Join(",", tab));
            List<int> temp = tab.ToList();
            temp.Insert(index, a);
            Console.WriteLine(string.Join(",", temp.ToArray()));
        }

        public int[] Swap(int[] tab, int indexA, int indexB)
        {
            int temp = tab[indexB];
            tab[indexB] = tab[indexA];
            tab[indexA] = temp;
            return tab;
        }

        public int[] GrowTab(int[] tab, int size)
        {
            int[] res = new int[size];
            for(int i = 0; i < size - 1; i++)
            {
                if(i < tab.Length)
                {
                    res[i] = tab[i];
                }
                else
                {
                    Console.WriteLine("Entrez une valeur:");
                    res[i] = int.Parse(Console.ReadLine());
                }
            }
            return res;
        }

        public void GiveBigAndSmall(int[] tab)
        {
            int[] temp = TriABulle(tab);
            Console.WriteLine("Plus Grand : " + temp[temp.Length - 1]);
            Console.WriteLine("Son indice est : " + GetIndex(tab, temp[temp.Length - 1]));
            Console.WriteLine("Plus Petit : " + temp[0]);
            Console.WriteLine("Son indice est : " + GetIndex(tab, temp[0]));
        }

        public bool CheckBissectile(int annee)
        {
            if (annee % 400 == 0) return true;
            if (annee % 100 == 0) return false;
            if (annee % 4 == 0) return true;
            return false;
        }

        public bool CheckDate(int jour, int mois, int annee)
        {
            switch (mois)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (jour <= 31) return true;
                    return false;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (jour <= 30) return true;
                    return false;
                case 2:
                    if (CheckBissectile(annee))
                    {
                        if (jour <= 29) return true;
                        return false;
                    }
                    if (jour <= 28) return true;
                    return false;
                default:
                    return false;
            }
        }
        
        public int DaysLived(int jour, int mois, int annee)
        {
            if(CheckDate(jour, mois, annee))
            {
                DateTime date = DateTime.Today;
                DateTime naissance = new DateTime(annee, mois, jour);
                return (date - naissance).Days;
            }
            throw new Exception("Date incorrecte !");
        }

        public double SinTaylor(double x)
        {
            double res = x;
            int n = 1;
            int tmp;
            int sign = -1;
            double terme = x;
            double precision = 0.001;
            while(Math.Abs(terme) > precision)
            {
                tmp = (2 * n) + 1;
                terme = (terme * x * x) / (tmp * (tmp - 1));
                res += (sign * terme);
                sign *= -1;
                n++;
            }
            return res;
        }

        public double CosTaylor(double x)
        {
            double res = 1;
            int n = 1;
            int tmp;
            int sign = -1;
            double precision = 0.001;
            double terme = x;
            while(Math.Abs(terme) > precision)
            {
                tmp = 2 * n;
                terme = Math.Pow(x, tmp) / (tmp * (tmp - 1));
                res += (sign * terme);
                sign *= -1;
                n++;
            }
            return res;
        }

        public int[] TriABulle(int[] t)
        {
            try
            {
                bool res = false;
                while (!res)
                {
                    res = true;
                    for (int i = 0; i < t.Length - 1; i++)
                    {
                        if (t[i] > t[i + 1])
                        {
                            Swap(t, i, i + 1);
                            res = false;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            return t;
        }
    }
}
