using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static CalculatriceTU.Calcules;

namespace CalculatriceTU
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            //Instanciation des variables
            double num1 = 0;
            double num2 = 0;
            string operation = "";
            double result = 0;

            //Exception en cas d'erreur de frappe lors de l'ajout des nombres à calculer
            Exception monException = new Exception("Veuillez entrer un nombre valide");

            try
            {
            Console.WriteLine("---------------\nCalculatrice TU\n---------------");

            //Permet de remplir la variable num1
            Console.Write("Entrez le premier numéro: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            //Permet de remplir la variable num1
            Console.Write("Entrez le second numéro: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            //Permet de remplir l'operateur souhaité
            Console.WriteLine("Entrez une option:\n\t+ : addition\n\t- : soustraction \n\t* : multiplication\n\t/ : division");
            Console.Write("Entrez une option:");

            
            operation = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine(monException);
            }

            //Exécute la fonction Calculer avec les paramètre mis remplis ci-dessus
            Calcules c = new Calcules();
            result = c.Calculer(num1, num2, operation);

            //Affichage du resultat
            Console.Write("Votre resultat est: " + result);
            Console.ReadLine();
        }
    }
}
