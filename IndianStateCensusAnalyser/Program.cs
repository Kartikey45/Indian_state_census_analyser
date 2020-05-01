using System;
using System.IO;
using System.Collections.Generic;
using ChoETL;
using System.Linq;
using System.Text;
using static IndianStateCensusAnalyser.CsvUSCensusData;

namespace IndianStateCensusAnalyser
{
    //Main class
    public class Program
    {
        //Main method
        public static void Main()
        {
            Console.WriteLine("Welcome to Indian Census");

            Analyser analyser = new Analyser();

            //US specific JSON formate from most populous to least
            analyser.SortingCSVFileInDescendingPopulationOrder("C:/Users/User/source/repos/USCensusData.csv");
            analyser.ConvertingCSVToJSON("C:/Users/User/source/repos/USCensusData.csv", "C:/Users/User/source/repos/IndianStateCensusAnalyser/USCensusDataPopulation.json");

            //US specific JSON formate from most population densisty to least
            analyser.SortingCSVFileInDescendingPopulationDesnsityOrder("C:/Users/User/source/repos/USCensusData.csv");
            analyser.ConvertingCSVToJSON("C:/Users/User/source/repos/USCensusData.csv", "C:/Users/User/source/repos/IndianStateCensusAnalyser/USCensusDataPopulationDensity.json");

            //US specific JSON formate from most Total Area to least
            analyser.SortingCSVFileInDescendingTotalAreaOrder("C:/Users/User/source/repos/USCensusData.csv");
            analyser.ConvertingCSVToJSON("C:/Users/User/source/repos/USCensusData.csv", "C:/Users/User/source/repos/IndianStateCensusAnalyser/USCensusDataTotalArea.json");
            
            Console.ReadKey();
        }
    }
}
