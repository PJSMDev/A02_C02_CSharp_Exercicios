using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace M01_E10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10. Escreva um programa que converta dólares americanos para euros (a taxa de câmbio é de 1,1579 USD para 1€).
            Utility.SetUnicodeConsole();

            double dollarValue, euroValue, convertRate = 1.1579;

            Utility.WriteMessage("Valor (USD): ");
            dollarValue = double.Parse(Console.ReadLine());

            euroValue = dollarValue / convertRate;

            Utility.WriteMessage($"{dollarValue}USD <=> {euroValue:F2}€");

            Utility.TerminateConsole();
        }
    }
}
