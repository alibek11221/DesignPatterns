using BuilderLibrary.Models;
using System;
using System.Collections.Generic;

namespace BuilderLibrary.Builders
{
    public interface IFluentBankBuilder
    {
        FluentBankBuilder ManagedBy(string headManager);
        FluentBankBuilder WasCreated(DateTime createdOn);
        FluentBankBuilder WithName(string name);
        Bank BuildBank();
    }
}