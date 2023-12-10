using BestCalculator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Calculate> history = new List<Calculate>();
            bool check = true;

            while (true)
            {
                Console.WriteLine("1.Calculate\n2.History\n3.Exit");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n == 1)
                {


                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    while (true)
                {

                    


                        Console.Write("FirstNumber : ");
                        double firstNumber = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the operation like +,-,*, / , % or ^:");
                        string operation = Console.ReadLine();
                        Console.Write("SecondNumber : ");
                        double secondNumber = Convert.ToDouble(Console.ReadLine());

                        Calculate calculate = new Calculate(name, firstNumber, operation, secondNumber);
                        double result = calculate.CalculateAllFunctions();
                        Console.WriteLine("Result : " + result);
                        history.Add(calculate);
                        Console.WriteLine("Do you want to continue? (y/n)");

                        if (Console.ReadLine() == "n")
                        {
                            break;
                        }

                    }
                    

                }
                else if (n == 2)
                {
                    Console.WriteLine("Calculation history:");
                    foreach (var entry in history)
                    {
                        Console.WriteLine($"{entry.Name}: {entry.FirstNumber} {entry.Function} {entry.SecondNumber} = {entry.CalculateAllFunctions()}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
