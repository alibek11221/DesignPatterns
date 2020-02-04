using BuilderLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderLibrary.Builders
{
    public class SberBankBuilder : BankBuilder
    {
        public SberBankBuilder() => ba = new Bank("Сбербанк");

      
        public override void AddCreationDate()
        {
            DateTime date = new DateTime(1841, 11, 12);
            ba.CreatedOn = date;
        }

        public override void AddHeadManager()
        {
            string hm = "Греф";
            ba.HeadManager = hm;
        }
    }
}
