// HW1b Grade

// Your Name:Melody Roberson
// Did you seek help ? If yes, specify the helper or web link here: N/A

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname;
            string lname;
            string idnum;

            double exam1;
            double exam2;
            double exam3;
            double hw;
            double classparticipation;

            string exam1AsString;
            string exam2AsString;
            string exam3AsString;
            string hwAsString;
            string classparticipationAsString;

            double finalgrade;

            Console.WriteLine("What is your first name?");
            fname = Console.ReadLine();
            Console.WriteLine("What is you last name?");
            lname = Console.ReadLine();
            Console.WriteLine("What is you student id?");
            idnum = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for exam 1?");
            exam1AsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for exam 2?");
            exam2AsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for exam 3?");
            exam3AsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for homeworks?");
            hwAsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for class participation?");
            classparticipationAsString = Console.ReadLine();

            exam1 = Convert.ToDouble(exam1AsString);
            exam2 = Convert.ToDouble(exam2AsString);
            exam3 = Convert.ToDouble(exam3AsString);
            hw = Convert.ToDouble(hwAsString);
            classparticipation = Convert.ToDouble(classparticipationAsString);

            finalgrade = ((exam1 * .15) + (exam2 * .25) + (exam3 * .25) + (hw * .20) + (classparticipation * .15))/100;

            Console.WriteLine($"{fname} {lname} ({idnum}), your final grade is {finalgrade.ToString("P")}.");

            Console.ReadKey();




        }
    }
}
