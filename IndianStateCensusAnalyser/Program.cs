using System;
using System.Collections.Generic;
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
            CsvStates Census = new CsvStates();
            object record = Census.LoadCsvData("C:/Users/User/source/repos/StateCodeCopy.csv", "State,Population,AreaInSqKm,DensityPerSqKm", "SrNo,StateName,TIN,StateCode");
            Console.WriteLine(record);
            Console.ReadKey();
        }
    }
}
