using System;
using System.Collections.Generic;

namespace LesTableauxExo4
{
    class Program
    {        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //À l’aide d’une boucle, demander à l’utilisateur les nombres qu’il souhaite multiplier.
            //Les stocker dans une liste.
            //Calculer le résultat de la multiplication et l’afficher en rappelant tous les nombres.  

            List<int> numbers = new List<int> ();
            //Console.WriteLine("liste  : ");

            int start = 0;
            int number = 1;
            int product = 1;

            Console.WriteLine("Entrez un premier nombre  : ");
            string number1 = Convert.ToInt32(Console.ReadLine);

            Console.WriteLine("Entrez un second nombre  : ");

            Console.WriteLine("Souhaitez-vous entrer un autre nombre ? \n Oui OU Non : ");

            for (int i = 1; i < numbers.Count; i++)
            {
                product = start * number;
                Console.WriteLine($"calcul avec le résultat précédent {i} :  {start} * {numbers} = {product}");
                start = product;
            }
            Console.WriteLine($"résulat {product}");

        }
}
}
