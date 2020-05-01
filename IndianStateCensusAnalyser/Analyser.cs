using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using LumenWorks.Framework.IO.Csv;
using ChoETL;
using Newtonsoft.Json.Linq;

namespace IndianStateCensusAnalyser
{
    //Sorting and Converting into JSON formate
    public class Analyser
    {
        //Read Data
        public int ReadFile(string path)
        {
            string[] data = File.ReadAllLines(path);
            return data.Length;
        }

        // Sorting CSV Data
        public void SortingCSVFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            //Skip Header
            var data = lines.Skip(1);

            IEnumerable<string> query = from line in data let x = line.Split(',') orderby x[1] descending select line;
            File.WriteAllLines(path, lines.Take(1).Concat(query.ToArray()));
        }

        //check starting data and ending data of JSON data
        public string CheckData(string path, string key, int StateName)
        {
            string data = File.ReadAllText(path);
            var jsonData = JArray.Parse(data);
            //Staring Data
            if (StateName == 0)
            {
                // Return Starting Data
                return jsonData[0][key].ToString();
            }
            //Ending Data
            if (StateName == 1)
            {
                // Return Ending Data
                return jsonData[jsonData.Count - 1][key].ToString();
            }
            // Return Null
            return null;
        }

        //Sorting Csv data of US Census in order to most Population to least 
        public void SortingCSVFileInDescendingPopulationOrder(string path)
        {
            string[] lines = File.ReadAllLines(path, Encoding.Default);

            var data = lines.Skip(1);
            var sorted = data.Select(line => new
            {
                SortKey = Int32.Parse(line.Split(',')[2]),
                Line = line
            }
            ).OrderByDescending(x => x.SortKey).Select(x => x.Line);
            File.WriteAllLines(path, lines.Take(1).Concat(sorted), Encoding.Default);
        }

        //Sorting Csv data of US Census in order to most Population densisty to least 
        public void SortingCSVFileInDescendingPopulationDesnsityOrder(string path)
        {
            string[] lines = File.ReadAllLines(path, Encoding.Default);

            var data = lines.Skip(1);
            var sorted = data.Select(line => new
            {
                SortKey = double.Parse(line.Split(',')[7]),
                Line = line
            }
            ).OrderByDescending(x => x.SortKey).Select(x => x.Line);
            File.WriteAllLines(path, lines.Take(1).Concat(sorted), Encoding.Default);
        }

        //Sorting Csv data of US Census in order to most Total area to least 
        public void SortingCSVFileInDescendingTotalAreaOrder(string path)
        {
            string[] lines = File.ReadAllLines(path, Encoding.Default);

            var data = lines.Skip(1);
            var sorted = data.Select(line => new
            {
                SortKey = double.Parse(line.Split(',')[4]),
                Line = line
            }
            ).OrderByDescending(x => x.SortKey).Select(x => x.Line);
            File.WriteAllLines(path, lines.Take(1).Concat(sorted), Encoding.Default);
        }

        //Coverting CSV To JSON
        public void ConvertingCSVToJSON(string path, string destination)
        {
            //Read CSV Data
            string csv = File.ReadAllText(path);

            StringBuilder builder = new StringBuilder();
            using (var p = ChoCSVReader.LoadText(csv).WithFirstLineHeader())
            {
                var w = new ChoJSONWriter(builder);
                w.Write(p);
            }

            //Data Storing In Destination Path(File) 
            File.WriteAllText(destination, builder.ToString());
        }
    }
}
