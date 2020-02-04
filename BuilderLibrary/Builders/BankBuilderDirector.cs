using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderLibrary.Builders
{
    public class BankBuilderDirector
    {
        public void Construct(BankBuilder builder)
        {
            builder.AddCreationDate();
            builder.AddHeadManager();
        }
    }
}
