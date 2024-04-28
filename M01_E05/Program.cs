using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace M01_E05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5. Escrever um programa que apresente os números do exercício anterior em percentagem.
            Utility.SetUnicodeConsole();

            double valueDouble01 = 8.456796;
            double valueDouble02 = 9.8;
            double valueDouble03 = 3.12345;
            int valueInt01 = 6;

            Utility.WriteMessage($"Valor 1: {valueDouble01:F2}%\nValor 2: {valueDouble02:F2}%\nValor 3: {valueDouble03:F2}%\nValor 4: {valueInt01:F2}%", "", "\n");

            Utility.TerminateConsole();
        }
    }
}
