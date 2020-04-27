using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;

namespace IndianStateCensusAnalyser
{
    public class StateCensusAnalyser : CsvBuilderInterface
    {
        //Variable Initialized
        private string CsvFilePath;
        private string StateCensusFileHeader;
        private string StateCodeFileHeader;

        //Deligate initialized
        public delegate object StateCensusAnalyserDelegate(string filepath, string StateCensusHeader, string StateCodeHeader);

        //load state Census Csv data
        public object LoadCsvData(string filepath, string StateCensusHeader, string StateCodeHeader)
        {
            //variable initialized
            CsvFilePath = filepath;
            StateCensusFileHeader = StateCensusHeader;
            StateCodeFileHeader = StateCodeHeader;
            char delimeter = ',';
            int count = 0;

            Console.WriteLine("Welcome to Indian State Census Analyser Problem");

            if (Path.GetExtension(CsvFilePath) != ".csv")
            {
                throw (new CsvCustomException("Incorrect file Extension"));
            }
            if (CsvFilePath != "C:/Users/User/source/repos/StateCensusData.csv" &&
                                                        CsvFilePath != "C:/Users/User/source/repos/StateCode.csv")
            {
                throw (new CsvCustomException("Incorrect file Path"));
            }

            else
            {

                string[] CsvData = File.ReadAllLines(CsvFilePath);
                
                //Iterate the records
                foreach (var fileData in CsvData)
                {
                    if (
                        ((!fileData.Contains(delimeter) || CsvData[0] != StateCensusFileHeader) ||
                        (!fileData.Contains(delimeter) && CsvData[0] != StateCensusFileHeader)) &&
                            ((!fileData.Contains(delimeter) || CsvData[0] != StateCodeFileHeader) ||
                            (!fileData.Contains(delimeter) && CsvData[0] != StateCodeFileHeader)) 
                            )
                    {
                        throw (new CsvCustomException("Delimeter or Header is incorrect"));
                    }
                    count++;
                }

                //Display total records
                Console.Write("Total number of records are : " + count);
                return count;
            }
        }
        public object LoadCsvData()
        {
            return null;
        }
    }
}
