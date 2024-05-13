using Microsoft.VisualStudio.TestTools.UnitTesting;
using MOD12_1302220143;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD12_1302220143.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void CariNilaiPangkatTest()
        {
            int a = 2;
            int b = 2;
            int expected = 4;
            int actual = Form1.Equals;

            Assert.AreEqual(Form1.CariNilaiPangkat(a, b));
        }
        public void CariNilaiPangkatTest1()
        {
            int a = 12;
            int b = 12;
            int expected = -3;
            int actual = Form1.Equals;

            Assert.AreEqual(Form1.CariNilaiPangkat(a, b));
        }
    }
}