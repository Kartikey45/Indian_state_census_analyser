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
            Console.WriteLine("Welcome to US Census Analyser");

            //Instance variable
            CsvUSCensusDAO csvUSCensusDAO = new CsvUSCensusDAO();

            //Load and display Us census data
            csvUSCensusDAO.LoadCensusData();

            Console.ReadKey();
        }
    }
}
