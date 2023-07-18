using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuThanhTu.Csharp.P1.P004.Excercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Starting application
            Console.WriteLine("Csharp.P1.P004.Excercise1");
            //This message guide user to enter a number
            Console.Write("Enter x = ");
            //Read value that use entered then convert it to number
            decimal xDecimal = Convert.ToDecimal(Console.ReadLine());
            //Call method to evaluate of a polynomial
            decimal output = EvaluatePolynomial(xDecimal);
            //Print result
            Console.WriteLine("Result y = {0}", output);
            Console.ReadLine();
        }
        private static decimal EvaluatePolynomial(decimal xDecimal)
        {
            //method to evaluate of a polynomial
         
            decimal[] polynomial = { 2, -6, 2, -1 };
            decimal result = polynomial[0];
            for (int i = 1; i < polynomial.Length; i++)
            {
                result = result * xDecimal + polynomial[i];
            }
            return result;
           
        }
    }
}
