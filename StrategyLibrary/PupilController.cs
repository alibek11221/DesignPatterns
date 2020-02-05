using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyLibrary
{
    public class PupilController
    {
        private readonly IDataLoader<Pupil> dataLoader;

        public PupilController(IDataLoader<Pupil> dataLoader)
        {
            if (dataLoader == null)
                throw new ArgumentNullException(nameof(dataLoader));
            this.dataLoader = dataLoader;
        }

        public void GetPupils()
        {
            dataLoader.LoadData();
        }
    }
}
