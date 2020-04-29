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
            Console.WriteLine("Welcome to US Census Analyser");

            //Instance variable created
            Analyser analyser = new Analyser();

            //Sorting data in Csv File
            analyser.SortingCSVFileInDescendingPopulationOrder("C:/Users/User/source/repos/USCensusData.csv");

            //Coverting Csv into JSON formate
            analyser.ConvertingCSVToJSON("C:/Users/User/source/repos/USCensusData.csv", "C:/Users/User/source/repos/USCensusData.json");

            Console.ReadKey();
        }
    }
}
