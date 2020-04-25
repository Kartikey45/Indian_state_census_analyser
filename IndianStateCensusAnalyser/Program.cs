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
            
            CsvStates census = new CsvStates();
            census.LoadCsvData();
            Console.ReadKey();
        }
    }
}
