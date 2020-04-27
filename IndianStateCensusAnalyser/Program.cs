using System;
using System.IO;
using System.Collections.Generic;
using ChoETL;
using System.Linq;
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
            Analyser analyser = new Analyser();
            analyser.SortingCSVFileForMostPopulousDensityState("C:/Users/User/source/repos/StateCensusDataCopy.Csv");
            analyser.ConvertingCSVToJSON("C:/Users/User/source/repos/StateCensusDataCopy.csv", "C:/Users/User/source/repos/StateCensusDataUC6.json");
        }
    }
}
