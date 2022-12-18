using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatriceTU
{
    public class Calcules
    {

        //Fonction permettant de calculer
        public double Calculer(double num1 = 0, double num2 = 0, string operation = "", double result = 0)
        {

            //Permet d'éffectuer le calcule en fonction du paramètre donné (+,-,*,/)
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;

            }
            //Retourne le resultat attendu
            return result;

        }
    }
}
