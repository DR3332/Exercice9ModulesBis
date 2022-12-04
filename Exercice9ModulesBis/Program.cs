using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice9ModulesBis
{
    class Program
    {
        static void abs(int n)
        {
            
            if (n < 0)
            {
                 Console.WriteLine("Voici la valeur absolu de " + n + " : " + -n);
            }
            else
            {
                Console.WriteLine("Voici la valeur absolu de " + n + " : " + n);
            }
        }

        static void Main(string[] args)
        {
            /* Le programme doit permettre de saisir un entier et d’afficher sa valeur absolue en utilisant la fonction
            ci-dessus. La fonction précédente doit être transformée en procédure et le programme doit exploiter la procédure
            (tout en faisant la même chose). */

            Console.WriteLine("Veuillez saisir une valeur : ");

            abs(int.Parse(Console.ReadLine()));
            Console.WriteLine("Je dis absolument n'imp pour avoir une modification");
            Console.ReadLine();



        }
    }
}
