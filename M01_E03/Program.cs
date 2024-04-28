using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace M01_E03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 3. Escrever um programa que apresente no ecrã o resultado das expressões: 
             *  › 15+2
             *  › 15/2
             *  › Resto da divisão de 15 por 2
            */

            Utility.SetUnicodeConsole();

            int resultInt = 15 + 2;
            double resultDouble = 15 / 2;
            double resultModule = 15 % 2;

            Utility.WriteMessage($"{resultInt}", "", "\n");
            Utility.WriteMessage($"{resultDouble}", "", "\n");
            Utility.WriteMessage($"{resultModule}", "", "\n");

            Utility.TerminateConsole();
        }
    }
}
