using BuilderLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderLibrary.Builders
{
    public class FluentBankBuilder : IFluentBankBuilder
    {
        private string _name;
        private DateTime _createdOn;
        private string _headManager;

        public FluentBankBuilder WithName(string name)
        {
            _name = name;
            return this;
        }
        public FluentBankBuilder WasCreated(DateTime createdOn)
        {
            _createdOn = createdOn;
            return this;
        }

        public FluentBankBuilder ManagedBy(string headManager)
        {
            _headManager = headManager;
            return this;
        }

        public Bank BuildBank()
        {
            return new Bank(_name)
            {
                CreatedOn = _createdOn,
                HeadManager = _headManager,
            };
        }

        public static implicit operator Bank(FluentBankBuilder bankBuilder)
        {
            return bankBuilder.BuildBank();
        }
    }
}
