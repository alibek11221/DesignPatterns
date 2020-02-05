using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyLibrary
{
    public interface IDataLoader<T> where T : DataModel
    {
        T LoadData();
    }
}
