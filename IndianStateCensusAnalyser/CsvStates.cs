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
        //Initialize variable
        private string records;

        //Load Csv data 
        public object LoadCsvData(string path)
        {
            records = path;

            //variable initialize
            int count = 0;

            //Read .Csv file
            var reader = new StreamReader(File.OpenRead(records));

            List<string> listB = new List<string>();
            while (!reader.EndOfStream)
            {

                var line = reader.ReadLine();
                var values = line.Split(',');

                listB.Add(values[0]);
                listB.Add(values[1]);
                listB.Add(values[2]);
                listB.Add(values[3]);
                count++;
                Console.WriteLine(line);
            }

            //Display total records
            Console.Write("Total number of records are : " + count);
            return count; 
        }
    }
}
