using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyser
{
    public class CsvCustomException : Exception
    {
        public CsvCustomException(string message) : base(message)
        {

        }
    }
}
