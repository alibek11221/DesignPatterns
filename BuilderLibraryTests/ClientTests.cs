using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuilderLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using BuilderLibrary.Builders;
using BuilderLibrary.Models;

namespace BuilderLibrary.Tests
{
    [TestClass()]
    public class ClientTests
    {
        Client client = new Client();
        Bank mock = new Bank("name")
        {
            CreatedOn = DateTime.Now,
            HeadManager = "HM",
        };
        [TestMethod()]
        public void BuildByFluentTest()
        {
            IFluentBankBuilder builder = new FluentBankBuilder();
            Bank bank = client.BuildByFluent(builder, "name", DateTime.Now, "head");
            Assert.AreEqual(mock.SerialNumber, bank.SerialNumber);
        }

        [TestMethod()]
        public void BuildByFluentImplicitTest()
        {
            IFluentBankBuilder builder = new FluentBankBuilder();
            Bank bank = client.BuildByFluentImplicit(builder, "name", DateTime.Now, "head");
            Assert.AreEqual(mock.SerialNumber, bank.SerialNumber);
        }

        [TestMethod()]
        public void BuildByComplexTest()
        {
            BankBuilder builder = new SberBankBuilder();
            BankBuilderDirector director = new BankBuilderDirector();
            Bank sber = client.BuildByComplex(builder, director);
            Assert.AreEqual($"Сбербанк_{DateTime.Now.ToString("MMddyyyy-HHmm")}", sber.SerialNumber);
        }
    }
}