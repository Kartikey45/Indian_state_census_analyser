using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndianStateCensusAnalyser
{
    public class CSVBuilderClass
    {
        private string path;
        private string[] records;

        public CSVBuilderClass()
        {
        }

        public CSVBuilderClass(string _path)
        {
            path = _path;
        }

        public string[] Records
        {
            get
            {
                records = File.ReadAllLines(path);
                return records;
            }
        }
    }
}
