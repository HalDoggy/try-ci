using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        [TestMethod()]
        public void DoTest()
        {
            Subtraction subtraction = new Subtraction();
            Assert.AreEqual(5 - 1, subtraction.Do(5, 1));
        }

        [TestMethod()]
        public void DoAddTest()
        {
            Add add = new Add();
            Assert.AreEqual(5 + 5, add.Do(5, 5));
        }
    }
}