using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyser
{
    //Interface 
    public interface CsvBuilder
    {
        public object LoadCsvData(string path);
        
    }
}
