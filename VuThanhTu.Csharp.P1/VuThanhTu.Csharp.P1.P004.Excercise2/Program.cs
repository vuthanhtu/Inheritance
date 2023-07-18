using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuThanhTu.Csharp.P1.P004.Excercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Starting application
            Console.WriteLine("Csharp.P1.P004.Excercise2");
            //initial polynomial
            var polynomial = InitialPolynimial();
            //This message to guide user to enter a number
            Console.Write("Enter x = ");
            // Read value that use entered then convert it to number
            decimal xDecimal = Convert.ToDecimal(Console.ReadLine());
            // Call Horner’s method.
            decimal output = EvaluatePolynomial(polynomial, xDecimal);

            // Print the result
            Console.Write("Result y = {0}", output);

            // Pause console window to see result
            Console.ReadLine();
        }
        public static decimal[] InitialPolynimial()
        {
            //method initial polynomial
            string[] input = Console.ReadLine().Split(' ');
            decimal[] polynimial = new decimal[input.Length];
            for(int i = 0; i < input.Length; i++)
            {
                polynimial[i] = decimal.Parse(input[i]);
            }
            return polynimial;
        }
        private static decimal EvaluatePolynomial(decimal[] polynomial, decimal xDecimal)
        {
            //Horner’s method.
            decimal result = polynomial[0];
            for(int i = 1; i < polynomial.Length; i++)
            {
                result = result * xDecimal + polynomial[i];
            }
            return result;
        }
    }
}
