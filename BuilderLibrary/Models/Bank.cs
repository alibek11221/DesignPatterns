using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderLibrary.Models
{
    public class Bank
    {
        private readonly string _name;

        public Bank(string name)
        {
            _name = name;
        }
        public string SerialNumber => $"{_name}_{DateTime.Now.ToString("MMddyyyy-HHmm")}";
        public DateTime CreatedOn { get; set; }
        public string HeadManager { get; set; }
    }
}
