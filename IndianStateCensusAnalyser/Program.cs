using System;
using System.IO;
using System.Collections.Generic;
using ChoETL;
using System.Linq;
using System.Text;
using static IndianStateCensusAnalyser.USCensusData;

namespace IndianStateCensusAnalyser
{
    //Main class
    public class Program
    {
        //Main method
        public static void Main()
        {
            Console.WriteLine("Welcome to Indian State Census Analyser");

            //Read Us Census data
            USCensusData uSCensusData = new USCensusData();
            uSCensusData.uSData("C:/Users/User/source/repos/USCensusData.csv");

            //Read State Census data
            CsvStateCensus csvStateCensus = new CsvStateCensus();
            csvStateCensus.StateCensusData("C:/Users/User/source/repos/StateCensusDataCopy.csv");

            //Read State code data
            CsvStates csvStates = new CsvStates();
            csvStates.StateCodeData("C:/Users/User/source/repos/StateCodeCopy.csv");

            Console.ReadKey();
        }
    }
}
