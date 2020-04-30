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
            ReadCensusData csvReadAdapter = new ReadCensusData();
            csvReadAdapter.ReadCsvFile();
            return data.Length;
        }
    }
}

