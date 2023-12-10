# BestCalculator
#### You can do this functions between two numbers
- Additon
- Subraction
- Division
- Multiplication
- DegreeOfNumber
- Percentage

  **Types** :
  ```cs
    int
    double
    string
    list
  ```

  
### Methods
**Addition method** :
  ```cs
private double Addition(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
  ```
**Subtraction method** :
  ```cs
private double Subtraction(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
  ```
**Multiplication method** :
  ```cs
private double Multiplication(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
  ```
**Division method** :
  ```cs
private double Division(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
  ```
**Degree of Number method**:
  ```cs
public double DegreeOfNumber(double firstNumber, double secondNumber)
        {
            double result = Math.Pow(firstNumber, secondNumber);
            return result;
        }
  ```
***CalculationAllFunctions** :
```cs
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
```
