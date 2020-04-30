using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;

namespace IndianStateCensusAnalyser
{
    //load .Csv data of State Code 
    public class CsvStates 
    {
        public object StateCodeData(string filePath)
        {
            string[] data = File.ReadAllLines(filePath);
            ReadCensusData csvReadAdapter = new ReadCensusData();
            csvReadAdapter.ReadCsvFile();
            return data.Length;
        }
    }
}
