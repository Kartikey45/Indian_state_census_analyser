using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using LumenWorks.Framework.IO.Csv;

namespace IndianStateCensusAnalyser
{
    public class ReadCensusData
    {
        public object ReadCsvFile()
        {
            IndianCensusDTO csvPath = new IndianCensusDTO("C:/Users/User/source/repos/StateCensusDataCopy.csv", "C:/Users/User/source/repos/StateCodeCopy.csv");
            string path = csvPath.StateCensusPath;

            int count = 0;
            using (CsvReader csv =
           new CsvReader(new StreamReader(path), true))
            {
                int fieldCount = csv.FieldCount;

                string[] headers = csv.GetFieldHeaders();
                while (csv.ReadNextRecord())
                {
                    for (int i = 0; i < fieldCount; i++)
                        Console.Write(string.Format("{0} = {1};",
                                      headers[i], csv[i]));
                    Console.WriteLine();
                    count++;
                }
            }
            return count;
        }
    }
}
