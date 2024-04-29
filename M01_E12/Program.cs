using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace M01_E12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 12. Escrever um programa que leia o preço base de um determinado produto e calcule o seu valor de venda ao 
             *  público (ou seja, valor acrescido da taxa de IVA a 23%).
            */
            Utility.SetUnicodeConsole();

            double priceBase, priceFinal, rateIVA = 1.23;

            Utility.WriteMessage("Preço base: ");
            priceBase = double.Parse(Console.ReadLine());

            priceFinal = priceBase * rateIVA;

            Utility.WriteMessage($"Preço base: {priceBase}\nPreço final: {priceFinal:F2}");

            Utility.TerminateConsole();
        }
    }
}
