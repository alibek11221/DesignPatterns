using BuilderLibrary.Builders;
using BuilderLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderLibrary
{
    public class Client
    {
        public Bank BuildByFluent(IFluentBankBuilder builder, string name, DateTime wasCreated, string hm)
        {
            Bank output = builder
                .WithName(name)
                .WasCreated(wasCreated)
                .ManagedBy(hm)
                .BuildBank();
            return output;
            
        }
        public Bank BuildByFluentImplicit(IFluentBankBuilder builder, string name, DateTime wasCreated, string hm)
        {
            Bank implicitOutput = builder
                .WithName(name)
                .WasCreated(wasCreated)
                .ManagedBy(hm);
            return implicitOutput;
        }
        public Bank BuildByComplex(BankBuilder builder, BankBuilderDirector director)
        {
            builder = new SberBankBuilder();
            director.Construct(builder);
            return builder.Bank;
        }
    }
}
