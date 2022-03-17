using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestPower0()
        {
            double x, ketQua;
            x = 3;
            ketQua = 1;
            int n = 0;
            Assert.AreEqual(Cau1.Power(x, n), ketQua);
        }

        [TestMethod]
        public void TestPower1()
        {
            double x, ketQua;
            x = 3;
            ketQua = 3;
            int n = 1;
            Assert.AreEqual(Cau1.Power(x, n), ketQua);
        }

        [TestMethod]
        public void TestPower2()
        {
            double x, ketQua;
            x = 3;
            ketQua = Math.Pow(3,-1);
            int n = -1;
            Assert.AreEqual(Cau1.Power(x, n), ketQua);
        }

        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @"D:\KTPM\Calculator\Calculator\CalculatorTester\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());
            Calculation c = new Calculation(a, b);
            double actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }
    }
}
