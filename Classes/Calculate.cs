using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestCalculator.Classes
{
    public class Calculate: User
    {
        

        public Calculate(string name,double firstNumber,string function, double secondNumber)
        {


            Name = name;
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Function = function;

            
        }

        
        
        public  double CalculateAllFunctions()
        {
            double result = 0;
            switch (this.Function)
            {
                case "+":
                    result = Addition(this.FirstNumber, this.SecondNumber);
                    break;
                case "-":
                    result = Subtraction(this.FirstNumber, this.SecondNumber);
                    break;
                case "/":
                    result = Division(this.FirstNumber, this.SecondNumber);
                    break;
                case "*":
                    result = Multiplication(this.FirstNumber, this.SecondNumber);
                    break;
                case "^":
                    result = DegreeOfNumber(this.FirstNumber, this.SecondNumber);
                    break;
                default:
                    result = 0;
                    break;

            }


            /*Console.WriteLine($"result: {this.FirstNumber} {this.Function} {this.SecondNumber} = {result}");
            users.Add($"{this.Name} : {this.FirstNumber} {this.Function} {this.SecondNumber} = {result}");
            *//*this.Result = result;*/

            return result;
        }

        /*public void SaveHistory(string name, double firstNumber, string function, double secondNumber, double result)
        {
            users.Add(new User { Name = name, FirstNumber = firstNumber, Function = function, SecondNumber = secondNumber, Result = result });
        }*/

        public double DegreeOfNumber(double firstNumber, double secondNumber)
        {
            double result = Math.Pow(firstNumber, secondNumber);
            return result;
        }

        private double Addition(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
        private double Subtraction(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        private double Division(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
        private double Multiplication(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
