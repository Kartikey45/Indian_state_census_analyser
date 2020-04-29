using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyser
{
    public class CsvDataSourceDAO
    {
        private String FilePath;

        public CsvDataSourceDAO(String filePath)
        {
            FilePath = filePath;
        }

        public string Record
        {
            get
            {
                return FilePath;
            }
        }
    }
}
