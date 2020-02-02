using FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factories
{
    public abstract class BillFactory
    {
        public abstract IBill Create();
    }
}
