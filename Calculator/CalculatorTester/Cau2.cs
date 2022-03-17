using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class Cau2
    {
        Polynomial poly;
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPolynomial1()
        {
            List<int> a = new List<int>() {0,1,2};
            poly = new Polynomial(3,a);   
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPolynomial2() 
        {
            List<int> a = new List<int>() { 0, 1, 2 };
            poly = new Polynomial(2, a);   
        }

        [TestMethod]
        public void TestCal1() 
        {
            List<int> a = new List<int>() { 0, 1, 2 };
            poly = new Polynomial(2, a);
            //a[i] * x^i : 1*2^1+2*2*2 => result = 10
            Assert.AreEqual(poly.Cal(2), 10);
        }
        [TestMethod]
        public void TestCal2()
        {
            List<int> a = new List<int>() { 0, 1, 2 };
            poly = new Polynomial(2, a);
            //a[i] * x^i : 1*2^1+2*2*2 => result = 10
            Assert.AreEqual(poly.Cal(2), 6);
        }
    }


}
