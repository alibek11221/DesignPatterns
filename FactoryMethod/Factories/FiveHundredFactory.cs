using FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factories
{
    public class FiveHundredFactory : BillFactory
    {
        public override IBill Create() => new FiveHundred();
    }
}
