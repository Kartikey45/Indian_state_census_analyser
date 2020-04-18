using IndianStateCensusAnalyser;
using NUnit.Framework;
using System;

namespace IndianStateCensusAnalyserTest
{
    //Test class
    public class CensusAnalyserTests
    {
        //TC 1.1 check to ensure the number of records matches
        [Test]
        public void recordMatches()
        {
            StateCensusAnalyser analyser = new StateCensusAnalyser();
            int totalRecords = analyser.loadCsvData("C:/Users/User/source/repos/StateCensusData.csv");
            Assert.AreEqual(30, totalRecords);
        }

        //TC 1.2 Csv file if incorrect returns a custom exception
        [Test]
        public void incorrectFile()
        {
            var analyser = new StateCensusAnalyser();
            var ex = Assert.Throws<CsvCustomException>(() => new StateCensusAnalyser().loadCsvData("C:/Users/User/source/repos/StateCensusData"));
            Assert.AreEqual("Entered incorrect file name", ex.Message);
        }
    }
}