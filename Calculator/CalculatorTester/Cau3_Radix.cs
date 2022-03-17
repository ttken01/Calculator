using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class Cau3_Radix
    {
        Radix ra;
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRadix1()
        {
            ra = new Radix(-1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRadix2()
        {
            ra = new Radix(2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCoverEx1() 
        {
            ra = new Radix(2);
            ra.ConvertDecimalToAnother(1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCoverEx2() 
        {
            ra = new Radix(2);
            ra.ConvertDecimalToAnother(17);
        }

        [TestMethod]
        public void TestCoverToBinary() 
        {
            ra = new Radix(2);
           Assert.AreEqual(ra.ConvertDecimalToAnother(2), "10");
        }


        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @"D:\KTPM\Calculator\Calculator\CalculatorTester\Data\Cau3TestConvertData.csv", "Cau3TestConvertData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestCoverToHex()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            string text = TestContext.DataRow[1].ToString();
            ra = new Radix(a);
            Assert.AreEqual(ra.ConvertDecimalToAnother(16), text);
        }
    }
}
