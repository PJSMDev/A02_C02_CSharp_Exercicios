using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace M01_E17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 17. Num determinado stand de automóveis, os vendedores ganham um salário mensal base X, uma comissão de Y 
             * euros por cada automóvel que vendem e uma percentagem P sobre o valor das vendas V que efetuarem. Escreva 
             * um programa que calcule e imprima o salário que um vendedor vai auferir este mês
            */

            Utility.SetUnicodeConsole();

            double baseSalary, comissionPerCar, bonusOverCarsSold, totalSales, comissionOverSales, bonusOverTotalSales, finalSalary;
            int carsSold;

            Utility.WriteMessage("Salário base (€): ");
            baseSalary = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("Comissão por carro vendido (€): ");
            comissionPerCar = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("Número de carros vendidos: ");
            carsSold = Convert.ToInt16(Console.ReadLine());

            bonusOverCarsSold = comissionPerCar * carsSold;

            Utility.WriteMessage("Total de vendas (€): ");
            totalSales = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("Comissão sobre o total de vendas(%): ");
            comissionOverSales = Convert.ToDouble(Console.ReadLine()) / 100;

            bonusOverTotalSales = totalSales * comissionOverSales;

            finalSalary = baseSalary + bonusOverCarsSold + bonusOverTotalSales;

            Utility.WriteMessage($"Salário base = {baseSalary}€", "", "\n");
            Utility.WriteMessage($"Bónus sobre carros vendidos: {comissionPerCar} * {carsSold} = {bonusOverCarsSold}€", "", "\n");
            Utility.WriteMessage($"Bónus sobre total de vendas: {totalSales} * {comissionOverSales} = {bonusOverTotalSales}€", "", "\n");
            Utility.WriteMessage($"Salário final: {finalSalary}", "", "\n");

            Utility.TerminateConsole();
        }
    }
}
