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
            CsvStateCensus analyser = new CsvStateCensus();
            int totalRecords = analyser.LoadCsvData("C:/Users/User/source/repos/StateCensusDataCopy.csv");
            Assert.AreEqual(30, totalRecords);
        }
        
        //TC 1.2 file path if incorrect returns a custom exception
        [Test]
        public void incorrectFilePath()
        {
            var analyser = new StateCensusAnalyser();
            var ex = Assert.Throws<CsvCustomException>(() => new StateCensusAnalyser().loadCsvData("C:/Users/User/source/repos/IndianStateCensusAnalyser/StateCensusData.csv"));
            Assert.AreEqual("Entered incorrect file Path", ex.Message);
        }

        //TC 1.3 file extension if incorrect returns a custom extension
        [Test]
        public void incorrectFileExtension()
        {
            var analyser = new StateCensusAnalyser();
            var ex = Assert.Throws<CsvCustomException>(() => new StateCensusAnalyser().loadCsvData("C:/Users/User/source/repos/StateCensusData.txt"));
            Assert.AreEqual("Incorrect file Extension", ex.Message);
        }

        //TC 1.4 Delimeter if incorrect returns a custom exception
        [Test]
        public void incorrectDelimeter()
        {
            var analyser = new StateCensusAnalyser();
            var ex = Assert.Throws<CsvCustomException>(() => new StateCensusAnalyser().loadCsvData("C:/Users/User/source/repos/StateCensusData.csv"));
            Assert.AreEqual("Delimeter is incorrect", ex.Message);
        }
    }
}