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
        private string record;

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

        public string Record
        {
            get
            {
                record = File.ReadAllText(path);
                return record;
            }
        }
    }
}
