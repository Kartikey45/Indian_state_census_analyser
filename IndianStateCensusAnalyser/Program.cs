using System;
using System.IO;
using System.Collections.Generic;
using ChoETL;
using System.Linq;
using System.Text;

namespace IndianStateCensusAnalyser
{
    //Main class
    public class Program
    {
        //Main method
        public static void Main()
        {
            Console.WriteLine("Welcome to indian state census analyser problem");
            Analyser analyser = new Analyser();

            //sorting csv data
            analyser.CsvSort("C:/Users/User/source/repos/StateCensusDataCopy.csv");

            //converting csv data to json formate
            analyser.CsvToJSONconvert("C:/Users/User/source/repos/StateCensusDataCopy.csv", "C:/Users/User/source/repos/StateCensusDataCopy.json");
        }
    }
}
