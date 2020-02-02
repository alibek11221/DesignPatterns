using FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factories
{
    public class OneHundredFactory : BillFactory
    {
        public override IBill Create() => new OneHundred();
    }
}
