using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace M01_E13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 13. Escrever um programa leia o valor base e o iva de um produto e que calcule o valor final do produto.
            Utility.SetUnicodeConsole();

            double valueIni, taxRate, valueTaxed;

            Utility.WriteMessage("Valor inicial: ");
            valueIni = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("IVA (%): ");
            taxRate = Convert.ToDouble(Console.ReadLine());

            valueTaxed = valueIni + valueIni * taxRate / 100;

            Utility.WriteMessage($"Valor inicial: {valueIni}\nIVA: {taxRate}%\nValor taxado: {valueTaxed}");

            Utility.TerminateConsole();
        }
    }
}
