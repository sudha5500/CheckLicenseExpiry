using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateExpiry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateExpiry.Tests
{
    [TestClass()]
    public class CheckExpiryTests
    {
        [TestMethod()]
        public void CalculateExpiryDateTest()
        {
            // this is for just one test case with current date as input
            CheckExpiry checkExpiry = new CheckExpiry();
            DateTime mockDate = DateTime.Now;
            DateTime licenseExpDate = checkExpiry.CalculateExpiryDate(mockDate);
            Assert.AreEqual(licenseExpDate.ToShortDateString(),"3/10/2024");
        }
    }
}