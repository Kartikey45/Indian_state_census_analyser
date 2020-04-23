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

            //Read Csv file 
            string[] CsvData = File.ReadAllLines(CsvFilePath);

            var file = from CsvFile in CsvData
                       let data = CsvFile.Split(',')
                       select new
                       {
                           SrNo = data[0],
                           StateName = data[1],
                           TIN = data[2],
                           StateCode = data[3],
                       };

            //Iterate the records
            foreach (var fileData in file)
            {
                Console.WriteLine(fileData.SrNo + "|" + fileData.StateName + "|" + fileData.TIN + "|" + fileData.StateCode);
                count++;
            }

            //Display total records
            Console.Write("Total number of records are : " + count);
            return count;
        }
    }
}
