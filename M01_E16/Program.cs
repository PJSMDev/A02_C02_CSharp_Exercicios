using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace M01_E16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 6. Escrever um programa que calcule a despesa média diária que um turista despendeu numa viagem de quatro 
             *   dias ao Porto, sabendo que cada dia gastou mais 20% do que no dia anterior. O valor da despesa deverá ser 
             *   apresentado sem casas decimais
            */
            Utility.SetUnicodeConsole();

            double initialExp, totalExp, avgExp;

            Utility.WriteMessage("Despesa inicial: ");
            initialExp = Convert.ToDouble(Console.ReadLine());

            totalExp = initialExp;

            for (int i = 1; i < 4; i++)     // Começa no 2º dia
            {
                initialExp *= 1.20;
                totalExp += initialExp;
            }

            // Calculando a despesa média diária
            avgExp = totalExp / 4;

            // Exibindo o resultado sem casas decimais
            Utility.WriteMessage($"Despesa média diária: {Convert.ToInt16(avgExp)}", "", "\n");

            Utility.TerminateConsole();
        }
    }
}
