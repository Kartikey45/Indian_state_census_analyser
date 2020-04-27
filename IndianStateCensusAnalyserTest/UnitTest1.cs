using IndianStateCensusAnalyser;
using NUnit.Framework;
using System;
using static IndianStateCensusAnalyser.CsvStateCensus;
using static IndianStateCensusAnalyser.CsvStates;
using static IndianStateCensusAnalyser.StateCensusAnalyser;

namespace IndianStateCensusAnalyserTest
{
    //Test class
    public class CensusAnalyserTests
    {
        public string CsvStateCensusHeader = "State,Population,AreaInSqKm,DensityPerSqKm";
        public string CsvStateCodeHeader = "SrNo,StateName,TIN,StateCode";

        //TC 1.1 check to ensure the number of records matches
        [Test]
        public void recordMatches()
        {
            CsvStateCensus analyser = new CsvStateCensus();
            CsvStateCensusDeligate deligate = new CsvStateCensusDeligate(analyser.LoadCsvData);
            object totalRecords = deligate.Invoke();
            Assert.AreEqual(30, totalRecords);
        }

        //TC 1.2 file path if incorrect returns a custom exception
        [Test]
        public void incorrectFilePath()
        {
            var analyser = new StateCensusAnalyser();
            StateCensusAnalyserDelegate deligate = new StateCensusAnalyserDelegate(analyser.LoadCsvData);
            var ex = Assert.Throws<CsvCustomException>(() => deligate.Invoke("C:/Users/User/source/repos/IndianStateCensusAnalyser/StateCensusData.csv", CsvStateCensusHeader, CsvStateCodeHeader));
            Assert.AreEqual("Incorrect file Path", ex.Message);
        }

        //TC 1.3 file extension if incorrect returns a custom extension
        [Test]
        public void incorrectFileExtension()
        {
            var analyser = new StateCensusAnalyser();
            StateCensusAnalyserDelegate deligate = new StateCensusAnalyserDelegate(analyser.LoadCsvData);
            var ex = Assert.Throws<CsvCustomException>(() => deligate.Invoke("C:/Users/User/source/repos/StateCensusData.txt", CsvStateCensusHeader, CsvStateCodeHeader));
            Assert.AreEqual("Incorrect file Extension", ex.Message);
        }

        //TC 1.4 Delimeter if incorrect returns a custom exception
        [Test]
        public void incorrectDelimeter()
        {
            var analyser = new StateCensusAnalyser();
            StateCensusAnalyserDelegate deligate = new StateCensusAnalyserDelegate(analyser.LoadCsvData);
            var ex = Assert.Throws<CsvCustomException>(() => deligate.Invoke("C:/Users/User/source/repos/StateCensusData.csv", CsvStateCensusHeader, CsvStateCodeHeader));
            Assert.AreEqual("Delimeter or Header is incorrect", ex.Message);
        }

        //TC 1.5 Header if incorrect returns a custom exception
        [Test]
        public void incorrectHeader()
        {
            var analyser = new StateCensusAnalyser();
            StateCensusAnalyserDelegate deligate = new StateCensusAnalyserDelegate(analyser.LoadCsvData);
            var ex = Assert.Throws<CsvCustomException>(() => deligate.Invoke("C:/Users/User/source/repos/StateCensusData.csv", CsvStateCensusHeader, CsvStateCodeHeader));
            Assert.AreEqual("Delimeter or Header is incorrect", ex.Message);
        }

        //TC 2.1 check to ensure the number of records matches
        [Test]
        public void recordMatchesForStateCode()
        {
            CsvStates analyser = new CsvStates();
            CsvStateCodeDeligate deligate = new CsvStateCodeDeligate(analyser.LoadCsvData);
            object totalRecords = deligate.Invoke();
            Assert.AreEqual(38, totalRecords);
        }

        //TC 2.2 file path if incorrect returns a custom exception
        [Test]
        public void incorrectFilePathForStateCode()
        {
            var analyser = new StateCensusAnalyser();
            StateCensusAnalyserDelegate deligate = new StateCensusAnalyserDelegate(analyser.LoadCsvData);
            var ex = Assert.Throws<CsvCustomException>(() => deligate.Invoke("C:/Users/User/source/repos/IndianStateCensusAnalyser/StateCode.csv", CsvStateCensusHeader, CsvStateCodeHeader));
            Assert.AreEqual("Incorrect file Path", ex.Message);
        }

        //TC 2.3 file extension if incorrect returns a custom extension
        [Test]
        public void incorrectFileExtensionForStateCode()
        {
            var analyser = new StateCensusAnalyser();
            StateCensusAnalyserDelegate deligate = new StateCensusAnalyserDelegate(analyser.LoadCsvData);
            var ex = Assert.Throws<CsvCustomException>(() => deligate.Invoke("C:/Users/User/source/repos/StateCode.txt", CsvStateCensusHeader, CsvStateCodeHeader));
            Assert.AreEqual("Incorrect file Extension", ex.Message);
        }

        //TC 2.4 Delimeter if incorrect returns a custom exception
        [Test]
        public void incorrectDelimeterForStateCode()
        {
            var analyser = new StateCensusAnalyser();
            StateCensusAnalyserDelegate deligate = new StateCensusAnalyserDelegate(analyser.LoadCsvData);
            var ex = Assert.Throws<CsvCustomException>(() => deligate.Invoke("C:/Users/User/source/repos/StateCode.csv", CsvStateCensusHeader, CsvStateCodeHeader));
            Assert.AreEqual("Delimeter or Header is incorrect", ex.Message);
        }

        //TC 2.5 Header if incorrect returns a custom exception
        [Test]
        public void incorrectHeaderForStateCode()
        {
            var analyser = new StateCensusAnalyser();
            StateCensusAnalyserDelegate deligate = new StateCensusAnalyserDelegate(analyser.LoadCsvData);
            var ex = Assert.Throws<CsvCustomException>(() => deligate.Invoke("C:/Users/User/source/repos/StateCode.csv", CsvStateCensusHeader, CsvStateCodeHeader));
            Assert.AreEqual("Delimeter or Header is incorrect", ex.Message);
        }

        //Test cases to check start and end data of state census JSON data
        [Test]
        public void checkStartOfStateCensus()
        {
            Analyser analyser = new Analyser();
            string checkResult = analyser.CheckData("C:/Users/User/source/repos/StateCensusDataCopy.json","State",0);
            Assert.AreEqual("Andhra Pradesh",checkResult);
        }

        [Test]
        public void checkEndOfStateCensus()
        {
            Analyser analyser = new Analyser();
            string checkResult = analyser.CheckData("C:/Users/User/source/repos/StateCensusDataCopy.json","State",1);
            Assert.AreEqual("West Bengal",checkResult);
        }

        //Test cases to check start and end data of state code JSON data
        [Test]
        public void checkStartOfStateCode()
        {
            Analyser analyser = new Analyser();
            string checkResult = analyser.CheckData("C:/Users/User/source/repos/StateCodeCopy.json","StateCode", 0);
            Assert.AreEqual("AD",checkResult);
        }

        [Test]
        public void checkEndOfStateCode()
        {
            Analyser analyser = new Analyser();
            string checkResult = analyser.CheckData("C:/Users/User/source/repos/StateCodeCopy.json", "StateCode", 1);
            Assert.AreEqual("WB", checkResult);
        }

        //Test cases to check start and end data of state census JSON data of UC 5
        [Test]
        public void checkStartOfStateCensusUc5()
        {
            Analyser analyser = new Analyser();
            string checkResult = analyser.CheckData("C:/Users/User/source/repos/StateCensusDataUC5.json", "Population", 0);
            Assert.AreEqual("91347736", checkResult);
        }

        [Test]
        public void checkEndOfStateCensusUc5()
        {
            Analyser analyser = new Analyser();
            string checkResult = analyser.CheckData("C:/Users/User/source/repos/StateCensusDataUC5.json", "Population", 1);
            Assert.AreEqual("10116752", checkResult);
        }

        
    }
}