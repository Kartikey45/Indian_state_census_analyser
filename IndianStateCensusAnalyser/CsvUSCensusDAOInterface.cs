using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IndianStateCensusAnalyser
{
    //Interface class
    public interface CsvUSCensusDAOInterface
    {
        //abstract method
        public object LoadCensusData();
    }
}
