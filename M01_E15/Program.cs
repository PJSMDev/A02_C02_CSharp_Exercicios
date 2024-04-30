using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace M01_E15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 15. Escrever um programa que apresente ao utilizador a sua idade daqui a vinte anos.
            Utility.SetUnicodeConsole();

            int age, agePlus20;

            Utility.WriteMessage("Idade atual (anos): ");
            age = Convert.ToInt16(Console.ReadLine());

            if (age >= 0)
            {
                agePlus20 = age + 20;
                Utility.WriteMessage($"Idade atual: {age}\nIdade daqui a 20 anos: {agePlus20}");
            }
            else
            {
                Utility.WriteMessage("Idade incorreta!", "", "");
            }
            
            Utility.TerminateConsole();
        }
    }
}
