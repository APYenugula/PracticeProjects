using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace UnitTesting.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        Addition a=new Addition();
        [TestMethod()]
        public void addTest()
        {
            int c=a.add(15, 3);
            int expected = 18;
            Assert.AreEqual(c,expected);
        }
    }
}