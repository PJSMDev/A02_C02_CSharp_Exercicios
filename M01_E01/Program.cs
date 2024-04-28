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
