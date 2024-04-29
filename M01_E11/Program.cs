using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace M01_E11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * 11. Escreva um programa que converta a temperatura lida em graus Fahrenheit para graus Celsius. 
             *  A fórmula é C = 5/9 *(f - 32)
            */
            Utility.SetUnicodeConsole();

            double fahrTemp, celsTemp;

            Utility.WriteMessage("Valor em Fahrenheit: ");
            fahrTemp = Convert.ToDouble(Console.ReadLine());

            celsTemp = (double)5 / 9 * (fahrTemp - 32);     // para evitar truncar o 5/9

            Utility.WriteMessage($"{fahrTemp} Fahrenheit <=> {celsTemp:F2} Celsius");

            Utility.TerminateConsole();
        }
    }
}
