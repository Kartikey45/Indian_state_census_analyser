using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoETL;

namespace IndianStateCensusAnalyser
{
    public class Analyser
    {
        //Csv to JSON convert
        public void CsvToJSONconvert(string CsvFilePath, string JSONfilePath)
        {
            StringBuilder stringBuilder = new StringBuilder();
            using (var p = ChoCSVReader.LoadText(CsvFilePath)
                .WithFirstLineHeader()
                )
            {
                using (var w = new ChoJSONWriter(stringBuilder))
                    w.Write(p);
            }
            Console.WriteLine(stringBuilder.ToString());
            File.WriteAllText(JSONfilePath,stringBuilder.ToString());
        }

        //Sorting Csv file
        public void CsvSort(string CsvFilePath)
        {
            string[] lines = File.ReadAllLines(CsvFilePath);
            //Skip Header
            var data = lines.Skip(1);
            IEnumerable<string> query = from line in data let x = line.Split(',') orderby x[0] select line;
            File.WriteAllLines(CsvFilePath, lines.Take(1).Concat(query.ToArray()));
        }
    }
}
