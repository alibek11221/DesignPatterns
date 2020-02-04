using BuilderLibrary.Builders;
using BuilderLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderLibrary
{
    public class Client
    {
        public void BuildByFluent(FluentBankBuilder builder, string name, DateTime wasCreated, string hm)
        {
            Bank bankWithBuildMethod = builder
                .WithName(name)
                .WasCreated(wasCreated)
                .ManagedBy(hm)
                .BuildBank();

            
        }
        public void BuildByFluentImplicit(FluentBankBuilder builder, string name, DateTime wasCreated, string hm)
        {
            Bank bankImplicit = builder
                .WithName(name)
                .WasCreated(wasCreated)
                .ManagedBy(hm);
        }
        public void BuildByComplex(BankBuilder builder, BankBuilderDirector director)
        {
            builder = new SberBankBuilder();
            director.Construct(builder);
        }
    }
}
