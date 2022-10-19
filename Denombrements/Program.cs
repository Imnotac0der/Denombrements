/**
 * titre : Dénombrements
 * description : L'application permet de réaliser 3 calculs mathématiques : permutation, arrangement et combinaison
 * auteur : silia
 * date création : 19/10/2022
 * date dernière modification : 19/10/2022
 */
using System;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclartion
            int c = 1;

            // Choix de l'utilisateur
            Console.WriteLine("Permutation ...................... 1");
            Console.WriteLine("Arrangement ...................... 2");
            Console.WriteLine("Combinaison ...................... 3");
            Console.WriteLine("Quitter .......................... 0");
            Console.Write("Choix :                            ");
            c = int.Parse(Console.ReadLine());
            while (c != 0)
            {
                // Switch
                switch (c)
                {
                    // Exit
                    case 0:
                        Environment.Exit(0);
                        break;

                    // Permutation
                    case 1:
                        Console.Write("nombre total d'éléments à gérer = ");
                        int n = int.Parse(Console.ReadLine());
                        long r = 1;
                        for (int k = 1; k <= n; k++)
                            r *= k;
                        Console.WriteLine(n + "! = " + r);
                        break;

                    // Arrangement
                    case 2:
                        Console.Write("nombre total d'éléments à gérer = ");
                        int t = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int m = int.Parse(Console.ReadLine());
                        long s = 1;
                        for (int k = (t - m + 1); k <= t; k++)
                            s *= k;
                        Console.WriteLine("A(" + t + "/" + m + ") = " + s);
                        break;

                    // Combinaison
                    case 3:
                        Console.Write("nombre total d'éléments à gérer = ");
                        int w = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int o = int.Parse(Console.ReadLine());
                        // calcul de r1
                        long r1 = 1;
                        for (int k = (w - o + 1); k <= w; k++)
                            r1 *= k;
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= o; k++)
                            r2 *= k;
                        Console.WriteLine("C(" + w + "/" + o + ") = " + (r1 / r2));
                        break;
                }

                // Choix de l'utilisateur
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
