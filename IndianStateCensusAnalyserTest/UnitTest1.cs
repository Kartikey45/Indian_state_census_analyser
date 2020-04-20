using IndianStateCensusAnalyser;
using NUnit.Framework;
using System;
using static IndianStateCensusAnalyser.CsvStates;

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
            CsvFile csv = new CsvFile(analyser.LoadCsvData);
            object totalRecords = csv.Invoke("C:/Users/User/source/repos/StateCensusDataCopy.csv");
            Assert.AreEqual(30, totalRecords);
        }

        //TC 1.2 file path if incorrect returns a custom exception
        [Test]
        public void incorrectFilePath()
        {
            var analyser = new StateCensusAnalyser();
            CsvFile csv = new CsvFile(analyser.loadCsvData);
            var ex = Assert.Throws<CsvCustomException>(() => csv.Invoke("C:/Users/User/source/repos/IndianStateCensusAnalyser/StateCensusData.csv"));
            Assert.AreEqual("Incorrect file Path", ex.Message);
        }

        //TC 1.3 file extension if incorrect returns a custom extension
        [Test]
        public void incorrectFileExtension()
        {
            var analyser = new StateCensusAnalyser();
            CsvFile csv = new CsvFile(analyser.loadCsvData);
            var ex = Assert.Throws<CsvCustomException>(() => csv.Invoke("C:/Users/User/source/repos/StateCensusData.txt"));
            Assert.AreEqual("Incorrect file Extension", ex.Message);
        }

        //TC 1.4 Delimeter if incorrect returns a custom exception
        [Test]
        public void incorrectDelimeter()
        {
            var analyser = new StateCensusAnalyser();
            CsvFile csv = new CsvFile(analyser.loadCsvData);
            var ex = Assert.Throws<CsvCustomException>(() => csv.Invoke("C:/Users/User/source/repos/StateCensusData.csv"));
            Assert.AreEqual("Delimeter or Header is incorrect", ex.Message);
        }

        //TC 1.5 Header if incorrect returns a custom exception
        [Test]
        public void incorrectHeader()
        {
            var analyser = new StateCensusAnalyser();
            CsvFile csv = new CsvFile(analyser.loadCsvData);
            var ex = Assert.Throws<CsvCustomException>(() => csv.Invoke("C:/Users/User/source/repos/StateCensusData.csv"));
            Assert.AreEqual("Delimeter or Header is incorrect", ex.Message);
        }

        //TC 2.1 check to ensure the number of records matches
        [Test]
        public void recordMatchesForStateCode()
        {
            CsvStates analyser = new CsvStates();
            CsvFile csv = new CsvFile(analyser.LoadCsvData);
            object totalRecords = csv.Invoke("C:/Users/User/source/repos/StateCodeCopy.csv");
            Assert.AreEqual(38, totalRecords);
        }

        //TC 2.2 file path if incorrect returns a custom exception
        [Test]
        public void incorrectFilePathForStateCode()
        {
            var analyser = new StateCensusAnalyser();
            CsvFile csv = new CsvFile(analyser.loadCsvStateCodeData);
            var ex = Assert.Throws<CsvCustomException>(() => csv.Invoke("C:/Users/User/source/repos/IndianStateCensusAnalyser/StateCode.csv"));
            Assert.AreEqual("Incorrect file Path", ex.Message);
        }

        //TC 2.3 file extension if incorrect returns a custom extension
        [Test]
        public void incorrectFileExtensionForStateCode()
        {
            var analyser = new StateCensusAnalyser();
            CsvFile csv = new CsvFile(analyser.loadCsvStateCodeData);
            var ex = Assert.Throws<CsvCustomException>(() => csv.Invoke("C:/Users/User/source/repos/StateCode.txt"));
            Assert.AreEqual("Incorrect file Extension", ex.Message);
        }

        //TC 2.4 Delimeter if incorrect returns a custom exception
        [Test]
        public void incorrectDelimeterForStateCode()
        {
            var analyser = new StateCensusAnalyser();
            CsvFile csv = new CsvFile(analyser.loadCsvStateCodeData);
            var ex = Assert.Throws<CsvCustomException>(() => csv.Invoke("C:/Users/User/source/repos/StateCode.csv"));
            Assert.AreEqual("Delimeter or Header is incorrect", ex.Message);
        }

        //TC 2.5 Header if incorrect returns a custom exception
        [Test]
        public void incorrectHeaderForStateCode()
        {
            var analyser = new StateCensusAnalyser();
            CsvFile csv = new CsvFile(analyser.loadCsvStateCodeData);
            var ex = Assert.Throws<CsvCustomException>(() => csv.Invoke("C:/Users/User/source/repos/StateCode.csv"));
            Assert.AreEqual("Delimeter or Header is incorrect", ex.Message);
        }
    }
}