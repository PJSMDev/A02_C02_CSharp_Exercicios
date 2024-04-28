using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace M01_E06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  6. Escrever um programa que leia do utilizador 3 números e os apresente dois resultados diferentes: 
             *  › Na 1ª linha, os números estão alinhados à esquerda, com duas casas decimais e cada um com 20 
             * casas.
             * › Na 1ª linha, os números estão alinhados à direita, com uma casa decimal e cada um com 20 
             * casas.  
            */

            Utility.SetUnicodeConsole();

            double[] numbers = new double[3];

            Utility.WriteMessage("Insira 3 números:", "", "\n");

            for (int i = 0; i < numbers.Length; i++)
            {
                Utility.WriteMessage($"Número {i + 1}: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            Utility.WriteMessage("Alinhados <-, 20 casas numéricas e 2 casas decimais", "", "\n");

            foreach (double item01 in numbers)
            {
                Utility.WriteMessage($"{item01,-20:F2}", "\t", "\n");
            }

            Utility.WriteMessage("Alinhados ->, 20 casas numéricas e 1 casa decimal", "", "\n");

            foreach (double item02 in numbers)
            {
                Utility.WriteMessage($"{item02,20:F2}", "\t", "\n");
            }

            Utility.TerminateConsole();
        }
    }
}
