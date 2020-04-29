using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IndianStateCensusAnalyser
{
    //Concrete class of DAO pattern
    public class CsvUSCensusDAO : CsvUSCensusDAOInterface
    {
        public object LoadCensusData()
        {
            //Load file path from the source DAO class 
            CsvDataSourceDAO csvDataSource = new CsvDataSourceDAO("C:/Users/User/source/repos/USCensusData.csv");
            string path = csvDataSource.Record;

            //Initialize variable 
            int count = 0;

            //instance variabe created
            CsvUSCensusData csv = new CsvUSCensusData();

            //Read and load csv data from file 
            List<CsvUSCensusData> values = File.ReadAllLines(path)
                                            .Select(v => csv.FromCsv(v)).ToList();

            //Iterate elements from csv file
            foreach (var element in values)
            {
                Console.WriteLine(element.stateId + "|" + element.state + "|" + element.population + "|"
                                    + element.housingUnits + "|" + element.totalArea + "|" + element.waterArea + "|" + element.landArea
                                    + "|" + element.populationDensity + "|" + element.housingDensity);
                count++;
            }

            //display total number of records
            Console.WriteLine("Total number of records : " + count);

            //returns total number of records in csv file
            return count;
        }
    }
}
