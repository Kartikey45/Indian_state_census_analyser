using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyser
{
    //Main class
    public class Program
    {
        //Main method
        public static void Main()
        {
            CsvStates census = new CsvStates();
            Console.WriteLine(census.LoadCsvData("C:/Users/User/source/repos/StateCode.csv"));
            Console.ReadKey();        
        }
    }
}
