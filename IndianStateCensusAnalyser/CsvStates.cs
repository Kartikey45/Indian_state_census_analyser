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
    public class CsvStates : CsvBuilder
    {
        //Variable Initialized
        string CsvFilePath;
        private string StateCensusFileHeader;
        private string StateCodeFileHeader;

        //Deligate initialized
        public delegate object CsvFile(string filepath, string StateCensusHeader, string StateCodeHeader);

        public object LoadCsvData(string filepath, string StateCensusHeader, string StateCodeHeader)
        {
            CsvFilePath = filepath;
            StateCensusFileHeader = StateCensusHeader;
            StateCodeFileHeader = StateCodeHeader;

            //variable initialize
            int count = 0;

            //Read .Csv file
            var reader = new StreamReader(File.OpenRead(CsvFilePath));

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
            Console.Write("Total number of records are : ");
            return count;
        }
    }
}
