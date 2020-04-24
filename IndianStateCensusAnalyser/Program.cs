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
            

            
            //Print Welcome To India States Census Analyser
            Console.WriteLine("Welcome To India States Census Analyser...!");
            Analyser stateCensus = new Analyser();
            //Sorting CSV Data
            stateCensus.SortingCSVFile(@"C:/Users/User/source/repos/StateCensusDataCopy.csv");
            //Converting CSV To JSON
            stateCensus.ConvertingCSVToJSON(@"C:/Users/User/source/repos/StateCensusDataCopy.csv", @"StateCensusDataCopy.json");
            
        }
    }
}
