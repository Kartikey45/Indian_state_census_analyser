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
            Console.WriteLine(analyser.loadCsvData("C:/Users/User/source/repos/StateCensusData.csv"));
            Console.ReadKey();
        }
    }
}
