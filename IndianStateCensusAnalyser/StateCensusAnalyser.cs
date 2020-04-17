using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;


namespace IndianStateCensusAnalyser
{
    // Main class
    public class StateCensusAnalyser
    {
        //load .csv data
        public int loadCsvData(string filepath)
        {
            //variable initialize
            int count = 0;

            Console.WriteLine("Welcome to Indian State Census Analyser Problem");
            var CsvData = File.ReadAllLines(filepath);

            var file = from CsvFile in CsvData
                            let data = CsvFile.Split(',')
                            select new
                            {
                                State = data[0],
                                Population = data[1],
                                AreaInSqKm = data[2],
                                DensityPerSqKm = data[3]
                            };

            //Iterate the records
            foreach (var fileData in file)
            {
                Console.WriteLine(fileData.State + "|" + fileData.Population + "|" + fileData.AreaInSqKm + "|" + fileData.DensityPerSqKm );
                count++;
            }
            
            //Display total records
            Console.Write("Total number of records are : " );
            return count;
        }   
    }
}
