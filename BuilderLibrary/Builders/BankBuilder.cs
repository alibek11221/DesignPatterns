using BuilderLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderLibrary.Builders
{
    public abstract class BankBuilder
    {
        public abstract void AddCreationDate();
        public abstract void AddHeadManager();

        protected Bank ba;
    }
}
