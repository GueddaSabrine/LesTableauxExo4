using System;
using System.Collections.Generic;
using System.Linq;

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



            List<int> numbers = new List<int>();
            int number, result;
            string resp = "o";

            while (resp == "o")
            {
                Console.WriteLine("ajouter un nombre à multiplier : ");
                number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(number);

                Console.WriteLine("voulez-vous ajouter un autre nombre à multipier ? O/N");
                resp = Console.ReadLine().ToLowerInvariant();

            }

            result = numbers.Aggregate(1, (x, y) => x * y);
            Console.WriteLine("le résultat est {0}", result);

            string usednb = string.Join("*", numbers);
            Console.WriteLine(usednb);















            /* List<int> numbers = new List<int> ();


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
             Console.WriteLine($"résulat {product}");*/

        }
}
}
