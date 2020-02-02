using FactoryMethod.Factories;
using FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Bank
    {
        private readonly Dictionary<Bills, BillFactory> _factories;

        private Bank()
        {
            _factories = new Dictionary<Bills, BillFactory>();
            foreach (Bills bill in Enum.GetValues(typeof(Bills)))
            {
                var factory = (BillFactory)Activator
                    .CreateInstance(Type.GetType("FactoryMethod.Factories." + Enum.GetName(typeof(Bills), bill) + "Factory"));
                _factories.Add(bill, factory);
            }
        }
        public static Bank Init() => new Bank();
        public IBill ExecuteCreation(Bills bill) => _factories[bill].Create();
    }
}
