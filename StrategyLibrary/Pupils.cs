using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyLibrary
{
    public class Pupil : DataModel
    {
        private int id;
        private string name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
