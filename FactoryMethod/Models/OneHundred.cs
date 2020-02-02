using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Models
{
    public class OneHundred : IBill
    {
        public int GetAmount()
        {
            return 100;
        }
    }
}
