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
        CSVBuilderClass builderClass = new CSVBuilderClass("C:/Users/User/source/repos/StateCensusDataCopy.csv");
        public object LoadCsvData()
        {
            string[] records = builderClass.Records;

            //Varibale
            int values = 0;

            //Use Dictionary For Maping
            Dictionary<int, Dictionary<string, string>> keyValuePairs = new Dictionary<int, Dictionary<string, string>>();

            string[] headerKey = records[0].Split(",");
            Dictionary<string, string> valuePairs = null;///Map
            for (int index = 1; index < records.Length; index++)
            {
                string[] value = records[index].Split(",");
                valuePairs = new Dictionary<string, string>();
                for (int index1 = 0; index1 < value.Length; index1++)
                {
                    valuePairs.Add(headerKey[index1], value[index1]);
                }
                keyValuePairs.Add(values, valuePairs);
                values++;
            }
            foreach (var index in keyValuePairs)
            {
                Console.WriteLine(index.Key);
                foreach (var index1 in index.Value)
                {
                    Console.WriteLine(index1.Key + " , " + index1.Value);
                }
            }
            return records.Length;
        }
    }
}

