using System;
using Calc;
namespace CalculatorApp // Note: actual namespace depends on the project name.
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calc.Calculator.Add(1,2));
        }
        
    }
}