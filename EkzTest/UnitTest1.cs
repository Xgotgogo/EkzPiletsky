using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using EkzPiletsky;

namespace EkzTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 10;
            int expected = 4;

            Input result = new Input();
            int actual = result.ResultTest(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
