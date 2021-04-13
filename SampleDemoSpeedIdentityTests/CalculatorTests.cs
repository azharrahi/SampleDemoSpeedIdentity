using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorSample;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleDemoSpeedIdentityTests
{
    [TestClass()]
    public class CalculatorTests
    {
        Calculator calculator = null;
        [TestInitialize]
        public void Initialize()
        {
            calculator = new Calculator();
        }

        [DataTestMethod]
        [DataRow(5, 120)]
        [DataRow(6, 720)]
        [DataRow(10, 3628800)]
        [TestMethod()]
        public void Factorial_Of_A_Number(int n, long expectedResult)
        {
            long result = calculator.Factorial(n);
            Assert.AreEqual(result, expectedResult);
        }

        [DataTestMethod]
        [DataRow(6, 3, 2)]
        [DataRow(13, 3, 4)]
        [TestMethod()]
        public void DivisionOfTwoVariables(int x, int y, int expectedResult)
        {
            int result = calculator.Divide(x, y);
            Assert.AreEqual(result, expectedResult);
        }

        [DataTestMethod]
        [DataRow(6, 3, 2)]
        [DataRow(12, 3, 4)]
        [DataRow(60, 3, 4, 5)]
        [TestMethod()]
        public void Multiply_Two_Or_More_Values(int expectedResult, params int[] numbers)
        {
            long result = calculator.Multiply(numbers);
            Assert.AreEqual(result, expectedResult);
        }

        [DataTestMethod]
        [DataRow(6, 216)]
        [DataRow(5, 125)]
        [DataRow(10, 1000)]
        [TestMethod()]
        public void Cube_Of_One_Variable(int x, long expectedResult)
        {
            long result = calculator.Cube(x);
            Assert.AreEqual(result, expectedResult);
        }

        [DataTestMethod]
        [DataRow(2, 4)]
        [DataRow(5, 25)]
        [TestMethod()]
        public void Square_Of_One_Variable(int x, long expectedResult)
        {
            long result = calculator.Square(x);
            Assert.AreEqual(result, expectedResult);
        }

        [DataTestMethod]
        [DataRow(4, 2, 216)]
        [DataRow(5, 5, 1000)]
        [TestMethod()]
        public void Cube_Of_Two_Variables(int x, int y, long expectedResult)
        {
            long result = calculator.Cube(x, y);
            Assert.AreEqual(result, expectedResult);
        }

        [DataTestMethod]
        [DataRow(4, 4, 64)]
        [DataRow(5, 5, 100)]
        [TestMethod()]
        public void Square_Of_Two_Variables(int x, int y, long expectedResult)
        {
            long result = calculator.Square(x, y);
            Assert.AreEqual(result, expectedResult);
        }

        [DataTestMethod]
        [DataRow(4, 4, 0)]
        [DataRow(25, 5, 20)]
        [TestMethod()]
        public void Subtract_Two_Numbers(int x, int y, long expectedResult)
        {
            long result = calculator.Subtract(x, y);
            Assert.AreEqual(result, expectedResult);
        }

        [DataTestMethod]
        [DataRow(8, 4, 4, 0)]
        [DataRow(50, 25, 5, 20)]
        [TestMethod()]
        public void Sum_Of_Two_Or_More_Numbers(int expectedResult, params int[] numbers)
        {
            long result = calculator.Sum(numbers);
            Assert.AreEqual(result, expectedResult);
        }

        [DataTestMethod]
        [DataRow(4, 4, 4, 1728)]
        [DataRow(5, 5, 5, 3375)]
        [TestMethod()]
        public void Cube_Of_Three_Variables(int x, int y, int z, long expectedResult)
        {
            long result = calculator.Cube(x, y, z);
            Assert.AreEqual(result, expectedResult);
        }

        [DataTestMethod]
        [DataRow(4, 4, 2, 100)]
        [DataRow(5, 5, 5, 225)]
        [TestMethod()]
        public void Square_Of_Three_Variables(int x, int y, int z, long expectedResult)
        {
            long result = calculator.Square(x, y, z);
            Assert.AreEqual(result, expectedResult);
        }
    }
}