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
        private IEnumerable<T> GetData() 
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream reader = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(reader) is IEnumerable<T> output)
                {
                    return output;
                }
                else
                {
                    return null;
                }
            }
        }
        public IEnumerable<T> LoadData()
        {
            return GetData();
        }
    }
}
