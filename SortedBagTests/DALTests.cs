using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortedBag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedBag.Tests
{
    [TestClass()]
    public class DALTests
    {
        [TestMethod()]
        public void AddIntegerTest()
        {
            var i = new DAL();
            i.AddInteger(4);

            Assert.AreEqual(1, i.All.Count);
        }

        [TestMethod()]
        public void AllIntegersTest()
        {
            var i = new DAL();
            i.AddInteger(5);

            Assert.AreEqual(1, i.All.Count);

        }

        [TestMethod()]
        public void DeleteIntegerTest()
        {
            var i = new DAL();
            i.AddInteger(1);
            i.AddInteger(1);

            i.DeleteInteger();
         
            Assert.AreEqual(1, i.All.Count);
        }

        [TestMethod()]
        public void CountIntegerTest()
        {
            var i = new DAL();
            
            i.AddInteger(1);
            i.CountInteger(i.All.Count);

            Assert.AreEqual(1, i.All.Count);

        }
    }
}