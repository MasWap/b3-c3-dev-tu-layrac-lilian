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

            double num1 = 0;
            double num2 = 0;
            string operation = "";
            double result = 0;
            Exception monException = new Exception("Veuillez entrer un nombre valide");

            try
            {
                Console.WriteLine("---------------\nCalculatrice TU\n---------------");
            Console.Write("Entrez le premier numéro: ");

            num1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Entrez le second numéro: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entrez une option:\n\t+ : addition\n\t- : soustraction \n\t* : multiplication\n\t/ : division");
            Console.Write("Entrez une option:");


            operation = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine(monException);
            }

            Calcules c = new Calcules();
            result = c.Calculer(num1, num2, operation);

            Console.Write("Votre resultat est: " + result);
            Console.ReadLine();
        }
    }
}
