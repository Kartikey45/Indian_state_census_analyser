using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyser
{
    //Interface 
    public interface CsvBuilderInterface
    {
        public object LoadCsvData(string path, string header1, string header2);
    }
}
