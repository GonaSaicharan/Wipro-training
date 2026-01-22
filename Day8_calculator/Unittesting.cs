using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;
using System;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTesting
    {
        
        [TestMethod]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
        
            Calculator calc = new Calculator();
            double a = 10;
            double b = 5;

        
            double result = calc.Add(a, b);

        
            Assert.AreEqual(15, result);
        }

        
        [TestMethod]
        public void Subtract_TwoNumbers_ReturnsCorrectDifference()
        {
        
            Calculator calc = new Calculator();
            double a = 10;
            double b = 5;

        
            double result = calc.Subtract(a, b);

        
            Assert.AreEqual(5, result);
        }

        
        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsCorrectProduct()
        {
        
            Calculator calc = new Calculator();
            double a = 4;
            double b = 5;

        
            double result = calc.Multiply(a, b);

        
            Assert.AreEqual(20, result);
        }

        
        [TestMethod]
        public void Divide_TwoNumbers_ReturnsCorrectQuotient()
        {
        
            Calculator calc = new Calculator();
            double a = 20;
            double b = 4;

        
            double result = calc.Divide(a, b);

        
            Assert.AreEqual(5, result);
        }

        
        [TestMethod]
        public void Divide_ByZero_ThrowsException()
        {
            
            Calculator calc = new Calculator();
            double a = 10;
            double b = 0;

            
            Assert.ThrowsException<DivideByZeroException>(() => calc.Divide(a, b));
        }
    }
}
