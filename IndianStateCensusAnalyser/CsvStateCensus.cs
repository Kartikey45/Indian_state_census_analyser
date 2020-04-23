using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;

namespace IndianStateCensusAnalyser
{
    // Load .Csv data
    public class CsvStateCensus : CsvBuilder
    {
        string CsvFilePath;
        private string StateCensusFileHeader;
        private string StateCodeFileHeader;

        //Deligate initialized
        public delegate object CsvFile(string filepath, string StateCensusHeader, string StateCodeHeader);

        public object LoadCsvData(string filepath, string StateCensusHeader, string StateCodeHeader)
        {
            //Variable Initialized
            CsvFilePath = filepath;
            StateCensusFileHeader = StateCensusHeader;
            StateCodeFileHeader = StateCodeHeader;

            //variable initialize
            int count = 0;
            Console.WriteLine("Welcome to Indian State Census Analyser Problem");
            
            //Read .Csv file
            var reader = new StreamReader(File.OpenRead(CsvFilePath));

            List<string> listA = new List<string>();
            while (!reader.EndOfStream)
            {

                var line = reader.ReadLine();
                var values = line.Split(',');

                listA.Add(values[0]);
                listA.Add(values[1]);
                listA.Add(values[2]);
                listA.Add(values[3]);
                count++;
                Console.WriteLine(line);
            }

            //Display total records
            Console.Write("Total number of records are : ");
            return count;
        }
    }
}
