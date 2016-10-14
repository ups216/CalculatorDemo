using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorDemo;

namespace CalculatorDemo.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Calculator_Add_Input2And2ShouldReture4_Success()
        {
            Calculator sut = new Calculator();
            int expected = 4;
            int num1 = 2;
            int num2 = 2;
            int result = sut.Add(num1, num2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculator_Mul_Input2And2ShouldReture4_Success()
        {
            Calculator sut = new Calculator();
            int exepcted = 4;
            int num1 = 2;
            int num2 = 2;
            int result = sut.Mul(num1, num2);
            Assert.AreEqual(exepcted, result);
        }

        [TestMethod]
        public void Calculator_Mul_Input2And3ShouldReture6_Success()
        {
            Calculator sut = new Calculator();
            int exepcted = 6;
            int num1 = 2;
            int num2 = 3;
            int result = sut.Mul(num1, num2);
            Assert.AreEqual(exepcted, result);
        }

        [TestMethod]
        public void Calculator_Divid_Input6And2ShouldReture3_Success()
        {
            Calculator sut = new Calculator();
            int exepected = 3;
            int num1 = 6;
            int num2 = 2;
            int result = sut.Divid(num1, num2);
            Assert.AreEqual(exepected, result);
        }

        [TestMethod]
        public void Calcualtor_IsNativePrivete_InputNagtiveNumber_ShouldBeTrue()
        {
            PrivateObject sut = new PrivateObject(typeof(Calculator));
            bool result = (bool)sut.Invoke("IsNagtive", -1);
            Assert.IsTrue(result);
        }
    }
}
