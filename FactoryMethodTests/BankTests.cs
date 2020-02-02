using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Models;

namespace FactoryMethod.Tests
{
    [TestClass()]
    public class BankTests
    {
        [TestMethod()]
        public void ExecuteCreationTest()
        {
            Bank bank = Bank.Init();
            IBill oneHundred = bank.ExecuteCreation(Bills.OneHundred);
            Assert.AreEqual(100, oneHundred.GetAmount());
        }
    }
}