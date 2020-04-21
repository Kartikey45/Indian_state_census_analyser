﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CsvHelper;


namespace IndianStateCensusAnalyser
{

    public class StateCensusAnalyser
    {
        
        //Deligate initialized
        public delegate object CsvFile(string filepath);

        //load state Census Csv data
        public object LoadCsvData(string filepath)
        {
            //variable initialized
            char delimeter = ',';
            int count = 0;

            Console.WriteLine("Welcome to Indian State Census Analyser Problem");

            if (Path.GetExtension(filepath) != ".csv")
            {
                throw (new CsvCustomException("Incorrect file Extension"));
            }
            if (filepath != "C:/Users/User/source/repos/StateCensusData.csv")
            {
                throw (new CsvCustomException("Incorrect file Path"));
            }

            else
            {

                string[] CsvData = File.ReadAllLines(filepath);
                
                //Iterate the records
                foreach (var fileData in CsvData)
                {
                    if ((!fileData.Contains(delimeter) || CsvData[0] != "State,Population,AreaInSqKm,DensityPerSqKm") ||
                        (!fileData.Contains(delimeter) && CsvData[0] != "State,Population,AreaInSqKm,DensityPerSqKm"))
                    {
                        throw (new CsvCustomException("Delimeter or Header is incorrect"));
                    }
                    count++;
                }

                //Display total records
                Console.Write("Total number of records are : " + count);
                return count;
            }
        }

        //Load State code Csv data 
        public object loadCsvStateCodeData(string filepath)
        {
            //variable initialized
            char delimeter = ',';
            int count = 0;

            Console.WriteLine("Welcome to Indian State Census Analyser Problem");

            if (Path.GetExtension(filepath) != ".csv")
            {
                throw (new CsvCustomException("Incorrect file Extension"));
            }
            if (filepath != "C:/Users/User/source/repos/StateCode.csv")
            {
                throw (new CsvCustomException("Incorrect file Path"));
            }

            else
            {

                string[] CsvData = File.ReadAllLines(filepath);

                //Iterate the records
                foreach (var fileData in CsvData)
                {
                    if ((!fileData.Contains(delimeter) || CsvData[0] != "SrNo,StateName,TIN,StateCode") ||
                        (!fileData.Contains(delimeter) && CsvData[0] != "SrNo,StateName,TIN,StateCode"))
                    {
                        throw (new CsvCustomException("Delimeter or Header is incorrect"));
                    }
                    count++;
                }

                //Display total records
                Console.Write("Total number of records are : " + count);
                return count;
            }
        }
    }
}
