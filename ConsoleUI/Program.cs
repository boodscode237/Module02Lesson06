using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueResult = "";
            do
            {
                Console.Write("What is your first name: ");
                string firstName = Console.ReadLine();

                Console.WriteLine($"Hello {firstName}");
                Console.Write("do you want to continue (yes/no): ");
                continueResult = Console.ReadLine();

            } while (continueResult.ToLower() == "yes");



            Console.Write("What is your age: ");
            string ageText = Console.ReadLine();
            bool isValidAge = int.TryParse(ageText, out int age);

            while (!isValidAge)
            {
                Console.WriteLine("That was not a valid age. Enter a valid age");
                Console.Write("What is your age: ");
                ageText = Console.ReadLine();
                isValidAge = int.TryParse(ageText, out age);
            }

            Console.WriteLine($"Your age in 10 years will be {age += 10}");
            Console.ReadLine();
        }
    }
}
