using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorSample
{
    /// <summary>
    /// ICalculator provides interface to write mathematical operations.
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// Sum method must be implemented for taking sum of numbers
        /// </summary>
        /// <param name="numbers">Accept dynamic array of int</param>
        /// <returns>long value</returns>
        long Sum(params int[] numbers);

        /// <summary>
        /// Subtract method must be implemented for taking subtraction of numbers
        /// </summary>
        /// <param name="numbers">Accept dynamic array of int</param>
        /// <returns>long value</returns>
        long Subtract(params int[] numbers);

        /// <summary>
        /// Multiply method must be implemented for taking multiplication of numbers
        /// </summary>
        /// <param name="numbers">Accept dynamic array of int</param>
        /// <returns>long value</returns>
        long Multiply(params int[] numbers);

        /// <summary>
        /// Divide method must be implemented for taking division of numbers
        /// </summary>
        /// <param name="numbers">Accept two int arguments</param>
        /// <returns>int value</returns>
        int Divide(int x, int y);

        /// <summary>
        /// Factorial method must be implemented for taking factorial of a number
        /// </summary>
        /// <param name="numbers">Accept one int argument</param>
        /// <returns>long value</returns>
        long Factorial(int n);

        /// <summary>
        /// Square method must be implemented for taking square of a number
        /// </summary>
        /// <param name="numbers">Accept one int argument</param>
        /// <returns>long value</returns>
        long Square(int x);

        /// <summary>
        /// Cube method must be implemented for taking cube of a number
        /// </summary>
        /// <param name="numbers">Accept one int argument</param>
        /// <returns>long value</returns>
        long Cube(int x);

        /// <summary>
        /// Square method must be implemented for taking square of two variables. Mathematically it should be square of a + b
        /// </summary>
        /// <param name="numbers">Accept two int arguments</param>
        /// <returns>long value</returns>
        long Square(int x, int y);

        /// <summary>
        /// Cube method must be implemented for taking cube of two variables. Mathematically it should be cube of a + b
        /// </summary>
        /// <param name="numbers">Accept two int arguments</param>
        /// <returns>long value</returns>
        long Cube(int x, int y);

        /// <summary>
        /// Square method must be implemented for taking square of three variables. Mathematically it should be square of a + b + c
        /// </summary>
        /// <param name="numbers">Accept three int arguments</param>
        /// <returns>long value</returns>
        long Square(int x, int y, int z);

        /// <summary>
        /// Cube method must be implemented for taking cube of three variables. Mathematically it should be cube of a + b + c
        /// </summary>
        /// <param name="numbers">Accept three int arguments</param>
        /// <returns>long value</returns>
        long Cube(int x, int y, int z);
    }
}
