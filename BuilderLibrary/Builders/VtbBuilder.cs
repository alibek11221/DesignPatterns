using BuilderLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderLibrary.Builders
{
    public class VtbBuilder : BankBuilder
    {
        public VtbBuilder()
        {
            ba = new Bank("ВТБ");
        }
       
        public override void AddCreationDate()
        {
            var date = new DateTime(1990, 2, 8);
            ba.CreatedOn = date;
        }

        public override void AddHeadManager()
        {
            string hm = "Ширвани";
            ba.HeadManager = hm;
        }
    }
}
