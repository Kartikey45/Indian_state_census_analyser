using System;
using System.Collections.Generic;
using System.Text;
using static IndianStateCensusAnalyser.CsvStates;

namespace IndianStateCensusAnalyser
{
    //Main class
    public class Program
    {
        //Main method
        public static void Main()
        {
            CsvStates StateCode = new CsvStates();
            CsvFile csv = new CsvFile(StateCode.LoadCsvData);
            csv.Invoke("C:/Users/User/source/repos/StateCodeCopy.csv");
            Console.ReadKey();     
            

            CsvStateCensus StateCensus = new CsvStateCensus();
            CsvFile CSV = new CsvFile(StateCensus.LoadCsvData);
            CSV.Invoke("C:/Users/User/source/repos/StateCensusDataCopy.csv");
            Console.ReadKey();
        }
    }
}
