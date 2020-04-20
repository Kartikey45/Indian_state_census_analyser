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
            CsvStates census = new CsvStates();
            CsvFile csv = new CsvFile(census.LoadCsvData);
            csv.Invoke("C:/Users/User/source/repos/StateCodeCopy.csv");
            Console.ReadKey();        
        }
    }
}
