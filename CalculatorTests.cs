using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgramacionOrientadaObjetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOrientadaObjetos.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Add(2, 2) == 4);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Subtract(2, 2) == 0);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Multiply(2, 2) == 4);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Divide(2, 2) == 1);
        }
    }
}