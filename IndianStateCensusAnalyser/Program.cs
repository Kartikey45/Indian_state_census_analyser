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
            /*
            Console.WriteLine("Welcome To India States Census Analyser...!");
            Analyser stateCensus = new Analyser();

            //Sorting CSV Data
            stateCensus.SortingCSVFile(@"C:/Users/User/source/repos/StateCodeCopy.csv");

            //Converting CSV To JSON
            stateCensus.ConvertingCSVToJSON(@"C:/Users/User/source/repos/StateCodeCopy.csv", @"StateCodeCopy.json");
            */

            CsvStateCensus census = new CsvStateCensus();
            census.LoadCsvData();
            Console.ReadKey();
        }
    }
}
