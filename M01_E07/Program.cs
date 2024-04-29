using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace M01_E07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7. Escrever um programa que apresente no ecrã a parte inteira de um número introduzido pelo utilizador.
            Utility.SetUnicodeConsole();

            double number;
            int numberInt;

            Utility.WriteMessage("Insere um número: ", "", "\n");
            number = (Convert.ToDouble(Console.ReadLine()));

            numberInt = (int)number;

            Utility.WriteMessage($"Número: {number}\n\t-> Parte inteira do número: {numberInt}", "", "\n");

            Utility.TerminateConsole();
        }
    }
}
