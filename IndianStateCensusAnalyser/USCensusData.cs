using System;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;

namespace IndianStateCensusAnalyser
{
    public class USCensusData 
    {
        public object uSData(string filePath)
        {
            string[] data = File.ReadAllLines(filePath);
            CsvReadAdapter csvReadAdapter = new CsvReadAdapter();
            csvReadAdapter.ReadCsvFile(filePath);
            return data.Length;
        }
    }
}
