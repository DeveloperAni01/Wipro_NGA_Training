using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorConsoleApp;
using System;

namespace CalculatorConsoleApp.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private calculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new calculator();
        }

        [TestMethod]
        public void Add_Test()
        {
            double result = calculator.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Divide_ByZero_Test()
        {
            Assert.ThrowsException<DivideByZeroException>(() =>
                calculator.Divide(10, 0));
        }
    }
}