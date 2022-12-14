using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalculatriceTU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;
                Exception monException = new Exception("Veuillez entrer un nombre valide");

                Console.Clear();
                Console.WriteLine("---------------\nCalculatrice TU\n---------------");

                try
                {
                    Console.Write("Entrez le premier numéro: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Entrez le second numéro: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Entrez une option:\n\t+ : addition\n\t- : soustraction \n\t* : multiplication\n\t/ : division");
                    Console.Write("Entrez une option:");

                    switch (Console.ReadLine())
                    {
                        case "+":
                            result = num1 + num2;
                            Console.WriteLine($"Votre résultat: {num1} + {num2} = " + result);
                            break;
                        case "-":
                            result = num1 - num2;
                            Console.WriteLine($"Votre résultat: {num1} - {num2} = " + result);
                            break;
                        case "*":
                            result = num1 * num2;
                            Console.WriteLine($"Votre résultat: {num1} * {num2} = " + result);
                            break;
                        case "/":
                            result = num1 / num2;
                            Console.WriteLine($"Votre résultat: {num1} / {num2} = " + result);
                            break;
                        default:
                            Console.WriteLine("Option invalide");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine(monException);
                }
                Console.WriteLine("Voulez-vous continuer ? (O = oui, N = non): ");

            } while (Console.ReadLine().ToUpper() == "O");

            Console.Clear();
            Console.WriteLine("Bye, l'application se fermera dans 2 secondes");
            Thread.Sleep(2000);
            Environment.Exit(0);
            Console.ReadKey();

        }
    }
}
