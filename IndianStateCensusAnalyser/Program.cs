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
            StateCensusAnalyser analyser = new StateCensusAnalyser();
            try
            {
                analyser.loadCsvData("C:/Users/User/source/repos/StateCensusData.csv");
            }
            catch(CsvCustomException ex)
            {
                Console.WriteLine("CsvCustomException : {0}", ex.Message);
            }
            Console.ReadKey();
        }
    }
}
