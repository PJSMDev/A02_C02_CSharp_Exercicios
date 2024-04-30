using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace M01_E14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 14. Escrever um programa que converta um valor em segundos para horas, minutos e segundos.
            Utility.SetUnicodeConsole();

            int valueIni, hours, minutes, seconds, timeRemaining;

            Utility.WriteMessage("Tempo em segundos: ");
            valueIni = Convert.ToInt16(Console.ReadLine());

            hours = valueIni / 3600;

            timeRemaining = valueIni % 3600;
            minutes = timeRemaining / 60;

            seconds = timeRemaining % 60;

            Utility.WriteMessage($"{valueIni} Segundos = {hours} Horas + {minutes} Minutos + {seconds} Segundos");

            Utility.TerminateConsole();
        }
    }
}
