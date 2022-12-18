using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatriceTU
{
    public class Calcules
    {
        public double Calculer(double num1 = 0, double num2 = 0, string operation = "", double result = 0)
        {

            //do
            //{
            //double num1 = 0;
            //double num2 = 0;
            //double result = 0;


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
            return result;

        }
    }
}
