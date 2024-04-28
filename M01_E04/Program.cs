using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace M01_E04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 4. Escreva um programa que apresente os números (8.456796, 9.8, 3.12345, 6) arredondados em três linhas 
             *  diferentes. sendo que na primeira linha aparecem todos arredondados a três casas decimais, na segunda a uma
             *  e na terceira a sem casa decimal.
            */

            Utility.SetUnicodeConsole();

            double valueDouble01 = 8.456796;
            double valueDouble02 = 9.8;
            double valueDouble03 = 3.12345;
            int valueInt01 = 6;

            Utility.WriteMessage($"Valores arredondados a 3 casas decimais:\n\tValor 1: {Math.Round(valueDouble01, 3)}\n\tValor 2: {Math.Round(valueDouble02, 3)}\n\tValor 3: {Math.Round(valueDouble03), 3}\n\tValor 3: {Math.Round(Convert.ToDouble(valueInt01)), 3}", "", "\n\n");
            Utility.WriteMessage($"Valores arredondados a 1 casa decimal:\n\tValor 1: {Math.Round(valueDouble01, 1)}\n\tValor 2: {Math.Round(valueDouble02, 1)}\n\tValor 3: {Math.Round(valueDouble03), 1}\n\tValor 3: {Math.Round(Convert.ToDouble(valueInt01)), 1}", "", "\n\n");
            Utility.WriteMessage($"Valores arredondados a 0 casas decimais:\n\tValor 1: {Math.Round(valueDouble01, 0)}\n\tValor 2: {Math.Round(valueDouble02, 0)}\n\tValor 3: {Math.Round(valueDouble03), 0}\n\tValor 3: {Math.Round(Convert.ToDouble(valueInt01)), 0}", "", "\n\n");

            Utility.TerminateConsole();
        }
    }
}
