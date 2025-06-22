using MangSoNguyen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMang
{
    public class TestUpdate
    {
        SinhVienService sinhVienService;
        [SetUp]
        public void Setup()
        {
            sinhVienService = new SinhVienService();
        }
        [Test]
        public void TestUpdatezero()
        {
           Assert.IsFalse(sinhVienService.Update(new SinhVien("0", "1", 1, 1, 1, "1")));
        }
        [Test]
        public void TestUpdateone()
        {
            Assert.IsTrue(sinhVienService.Update(new SinhVien("1", "Long", 1, 1, 1, "1")));
        }
        [Test]
        public void TestUpdateFor()
        {
            Assert.IsTrue(sinhVienService.Update(new SinhVien("4", "Long", 1, 1, 1, "1")));
        }
        [Test]
        public void TestUpdateFive()
        {
            Assert.IsFalse(sinhVienService.Update(new SinhVien("5", "Long", 1, 1, 1, "1")));
        }
        [Test]
        public void TestUpdateTen()
        {
            Assert.IsFalse(sinhVienService.Update(new SinhVien("2", null, 1, 1, 1, "1")));
        }
    }
}
