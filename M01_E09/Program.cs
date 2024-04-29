using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace M01_E09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9. Criar uma apliação do tipo consola para receber do utilizador dois valores inteiros e devolver a média aritmética.

            Utility.SetUnicodeConsole();

            int value01, value02;
            double averageValue;

            Utility.WriteMessage("Insira o primeiro valor: ");
            value01 = Convert.ToInt16(Console.ReadLine());

            Utility.WriteMessage("Insira o segundo valor: ");
            value02 = Convert.ToInt16(Console.ReadLine());

            averageValue = ((double)value01 + value02) / 2;
            Utility.WriteMessage($"Valores: ({value01},{value02})\nMédia: {averageValue}");

            Utility.TerminateConsole();
        }
    }
}
