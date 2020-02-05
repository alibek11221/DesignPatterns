using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace StrategyLibrary
{
    public class FileDataLoad<T> : IDataLoader<T> where T : DataModel
    {
        private readonly string filePath;
        public FileDataLoad(string filePath)
        {
            if (filePath == null)
                throw new ArgumentNullException(nameof(filePath));
            this.filePath = filePath;
        }
        private T GetData() 
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (StreamReader reader = new StreamReader(filePath))
            {
                
            }
        }
        public T LoadData()
        {
            throw new NotImplementedException();
        }
    }
}
