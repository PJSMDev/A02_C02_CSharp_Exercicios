using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace M01_E08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  8. Escrever uma mensagem que peça ao utilizador o primeiro nome e o apelido e apresente o seguinte resultado:
             *   <nome> <apelido>, acabou de ganhar o 1º prémio. Parabéns!
            */

            Utility.SetUnicodeConsole();

            string firstName, lastName;
            string prize;

            Utility.WriteMessage("Primeiro nome: ");
            firstName = Console.ReadLine();

            Utility.WriteMessage("Apelido: ", "\n");
            lastName = Console.ReadLine();

            prize = $"{firstName} {lastName}, acabou de ganhar o 1º prémio. Parabéns!";
            Utility.WriteMessage(prize, "\n");

            Utility.TerminateConsole();
        }
    }
}
