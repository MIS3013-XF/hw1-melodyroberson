// HW1a Sales Total

// Your Name: Melody Roberson
// Did you seek help ? If yes, specify the helper or web link here: N/A

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer1;
            double amount1;
            double price1;

            string amount1AsString;
            string price1AsString;

            double subtotal1;
            double salestax1;
            double total1;

            const double taxrate = 0.085;

            Console.WriteLine("What is the product name of the item you are purchasing?");
            answer1 = Console.ReadLine();
            Console.WriteLine($"How many {answer1}s do you want to buy?");
            amount1AsString = Console.ReadLine();
            Console.WriteLine($"What is the price for each {answer1}?");
            price1AsString = Console.ReadLine();

            amount1 = Convert.ToDouble(amount1AsString);
            price1 = Convert.ToDouble(price1AsString);

            subtotal1 = amount1 * price1;

            Console.WriteLine("\n\tYour subtotal for your bill is " + subtotal1.ToString("C") + ".");

            salestax1 = subtotal1 * taxrate;

            Console.WriteLine("\tYour sales tax for your bill is " + salestax1.ToString("C") + ".");

            total1 = subtotal1 + salestax1;

            Console.WriteLine("\tYour total for your bill is " + total1.ToString("C") + ".");

            Console.ReadKey();









        }
    }
}
