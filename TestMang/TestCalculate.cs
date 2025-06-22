using MangSoNguyen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMang
{
    public  class TestCalculate
    {
        Calculate calculate;
        [SetUp]
        public void Setup()
        {
            calculate = new Calculate();
        }
        [Test]
        public void TestZero()
        {
            Assert.AreEqual(0, calculate.Sum([0, 0, 0, 0]));
        }
        [Test]
        public void TestaZero()
        {
            Assert.AreEqual(0, calculate.Sum([0, 0, 1, -1]));
        }
        [Test]
        public void Testnegative()
        {
            Assert.AreEqual(-3, calculate.Sum([0, -1, -1, -1]));
        }
        [Test]
        public void TestPositive()
        {
            Assert.AreEqual(3, calculate.Sum([0, 1, 1, 1]));
        }
        [Test]
        public void TestNormal()
        {
            Assert.AreEqual(10, calculate.Sum([1, 2, 3, 4]));
        }
    }
}
