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
            CsvStates census = new CsvStates();
            CsvStateCodeDeligate deligate = new CsvStateCodeDeligate(census.LoadCsvData);
            deligate.Invoke();
            Console.ReadKey();
        }
    }
}
