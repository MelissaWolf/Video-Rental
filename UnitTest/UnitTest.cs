using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_Rental;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        DBLink Link = new DBLink();

        [TestMethod]
        public void TestMethod1() //Checking DB Connection
        {
            string Check1 = Link.DBLinkCheck();

            Assert.AreEqual(Check1, "VideoRental");
        }

        [TestMethod]
        public void TestMethod2() //Checking all Costs are ether $2 or $5
        {
            int priceCheck = Link.priceRangeCheck();

            Assert.IsTrue(priceCheck == 0);
        }
    }
}