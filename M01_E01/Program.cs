using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace M01_E01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Apresentar a área de um retângulo a partir de dois valores (altura e largura) introduzidos pelo utilizador. 

            Utility.SetUnicodeConsole();

            double height, length, areaRec;

            Utility.WriteMessage("Altura: ");
            height = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("Largura: ");
            length = Convert.ToDouble(Console.ReadLine());

            areaRec = height * length;

            Utility.WriteMessage($"Area: {height} * {length} = {areaRec}");

            Utility.TerminateConsole();
        }
    }
}
