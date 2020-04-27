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
            USCensusData data = new USCensusData();
            CsvStateCensusDeligate deligate = new CsvStateCensusDeligate(data.LoadCsvData);
            deligate.Invoke();
            Console.ReadKey();
        }
    }
}
