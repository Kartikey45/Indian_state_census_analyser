using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using LumenWorks.Framework.IO.Csv;

namespace IndianStateCensusAnalyser
{
    public class CsvReadAdapter
    {
        public object ReadCsvFile(string CsvFilePath)
        {
            int count = 0;
            using (CsvReader csv =
           new CsvReader(new StreamReader(CsvFilePath), true))
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
