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
            CsvReadAdapter csvReadAdapter = new CsvReadAdapter();
            csvReadAdapter.ReadCsvFile(filePath);
            return data.Length;
        }
    }
}
