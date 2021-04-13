using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorSample
{
    public class Calculator : ICalculator
    {
        /// <summary>
        /// Returns the cube of two variables - Mathematically it is denoted as cube of (x + y)
        /// x and y can be same or different integer values e.g. x = 2, y = 3 and its cube will be 125
        /// </summary>
        /// <param name="x">int first value</param>
        /// <param name="y">int second value</param>
        /// <returns>long value</returns>
        public long Cube(int x, int y)
        {
            Binomial binomial = new Binomial();
            return binomial.Cube(x, y);
        }

        /// <summary>
        /// Returns square of two variables - Mathematically it is denoted as sqaure of (x + y)
        /// x and y can be same or different integer values e.g. x = 2, y = 3 and its square will be 25
        /// </summary>
        /// <param name="x">int first value</param>
        /// <param name="y">int second value</param>
        /// <returns>long value</returns>
        public long Square(int x, int y)
        {
            Binomial binomial = new Binomial();
            return binomial.Square(x, y);
        }

        /// <summary>
        /// Returns cube of one variable - Mathematically it is denoted as cube of a
        /// e.g. x = 2 and its cube will be 8
        /// </summary>
        /// <param name="x">int first value</param>
        /// <param name="y">int 2nd value</param>
        /// <returns>long value</returns>
        public long Cube(int x)
        {
            return x * x * x;
        }

        /// <summary>
        /// Returns division of two variables - Mathematically it is denoted as a / 2
        /// e.g. x = 4 and y = 2 and its division will be 2
        /// </summary>
        /// <param name="x">int first value</param>
        /// <param name="y">int 2nd value</param>
        /// <returns>long value</returns>
        public int Divide(int x, int y)
        {
            return x / y;
        }

        /// <summary>
        /// Calculate the factorial of a number
        /// </summary>
        /// <param name="n">int number</param>
        /// <returns>long</returns>
        public long Factorial(int n)
        {
            long result = 1;

            if (n > 1)
                result = n * Factorial(n - 1);

            return result;
        }

        /// <summary>
        /// Multiply n numbers of input
        /// </summary>
        /// <param name="numbers">dynamic array of int</param>
        /// <returns>long value</returns>
        public long Multiply(params int[] numbers)
        {
            long result = 1;
            for (int i = 0; i < numbers.Length; i++)
                result *= numbers[i];

            return result;
        }

        /// <summary>
        /// Calculate square of a number
        /// </summary>
        /// <param name="x">int value</param>
        /// <returns>long value</returns>
        public long Square(int x)
        {
            return x * x;
        }

        /// <summary>
        /// Subtract two numbers
        /// </summary>
        /// <param name="numbers">dynamic array of int</param>
        /// <returns>long</returns>
        public long Subtract(params int[] numbers)
        {
            long result = 0;

            if (numbers.Length > 0)
                result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
                result -= numbers[i];

            return result;
        }

        /// <summary>
        /// Add two or more numbers
        /// </summary>
        /// <param name="numbers">dynamic array of integers</param>
        /// <returns>long value</returns>
        public long Sum(params int[] numbers)
        {
            long result = 0;
            for (int i = 0; i < numbers.Length; i++)
                result += numbers[i];

            return result;
        }

        /// <summary>
        /// Returns cube of three numbers - Mathematically it is denoted as cube of (x + y + z)
        /// x, y and z can be same or different integer values e.g. x = 2, y = 3, z = 5 and its cube will be 1000
        /// </summary>
        /// <param name="x">int value</param>
        /// <param name="y">int value</param>
        /// <param name="z">int value</param>
        /// <returns>long value</returns>
        public long Cube(int x, int y, int z)
        {
            Trinomial trinomial = new Trinomial();
            return trinomial.Cube(x, y, z);
        }

        /// <summary>
        /// Returns square of three numbers - Mathematically it is denoted as square of (x + y + z)
        /// x, y and z can be same or different integer values e.g. x = 2, y = 3, z = 5 and its square will be 100
        /// </summary>
        /// <param name="x">int value</param>
        /// <param name="y">int value</param>
        /// <param name="z">int value</param>
        /// <returns>long value</returns>

        public long Square(int x, int y, int z)
        {
            Trinomial trinomial = new Trinomial();
            return trinomial.Square(x, y, z);
        }
    }
}
