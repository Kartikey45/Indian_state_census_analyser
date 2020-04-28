using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser
{
    // Load .Csv data
    public class CsvStateCensus 
    {
        public object StateCensusData(string filePath)
        {
            string[] data = File.ReadAllLines(filePath);
            CsvReadAdapter csvReadAdapter = new CsvReadAdapter();
            csvReadAdapter.ReadCsvFile(filePath);
            return data.Length;
        }
    }
}

