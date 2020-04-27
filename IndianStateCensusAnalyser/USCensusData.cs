using System;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;

namespace IndianStateCensusAnalyser
{
    public class USCensusData : CsvBuilderInterface
    {
        //deligate initialize
        public delegate object CsvStateCensusDeligate();

        public object LoadCsvData()
        {
            //variable initialize
            int count = 0;

            Console.WriteLine("Welcome to Indian State Census Analyser Problem");
            var CsvData = File.ReadAllLines(@"C:/Users/User/source/repos/USCensusData.csv");

            var file = from CsvFile in CsvData
                       let data = CsvFile.Split(',')
                       select new
                       {
                           StateId = data[0],
                           State = data[1],
                           Population = data[2],
                           HousingUnits = data[3],
                           TotalArea = data[4],
                           WaterArea = data[5],
                           LandArea = data[6],
                           PopulationDensity = data[7],
                           HousingDensity = data[8]
                       };

            //Iterate the records
            foreach (var fileData in file)
            {
                Console.WriteLine(fileData.StateId + "|" + fileData.State + "|" + fileData.Population + "|" + fileData.HousingUnits + "|" + fileData.TotalArea + "|" + fileData.WaterArea + "|" + fileData.LandArea + "|" + fileData.PopulationDensity + "|" + fileData.HousingDensity);
                count++;
            }

            //Display total records
            Console.Write("Total number of records are : " + count);
            return count;
        }

        public object LoadCsvData(string path, string header1, string header2)
        {
            throw new NotImplementedException();
        }
    }
}
