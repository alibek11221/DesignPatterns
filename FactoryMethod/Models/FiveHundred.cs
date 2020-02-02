using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Models
{
    public class FiveHundred : IBill
    {
        public int GetAmount()
        {
            return 500;
        }
    }
}
