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
            object totalRecords = analyser.LoadCsvData();
            Assert.AreEqual(30, totalRecords);
        }

        //TC 1.2 file path if incorrect returns a custom exception
        [Test]
        public void incorrectFilePath()
        {
            var analyser = new StateCensusAnalyser();
            var ex = Assert.Throws<CsvCustomException>(() => new StateCensusAnalyser().LoadCsvData("C:/Users/User/source/repos/IndianStateCensusAnalyser/StateCensusData.csv", "State,Population,AreaInSqKm,DensityPerSqKm", "SrNo,StateName,TIN,StateCode"));
            Assert.AreEqual("Incorrect file Path", ex.Message);
        }

        //TC 1.3 file extension if incorrect returns a custom extension
        [Test]
        public void incorrectFileExtension()
        {
            var analyser = new StateCensusAnalyser();
            var ex = Assert.Throws<CsvCustomException>(() => new StateCensusAnalyser().LoadCsvData("C:/Users/User/source/repos/StateCensusData.txt", "State,Population,AreaInSqKm,DensityPerSqKm", "SrNo,StateName,TIN,StateCode"));
            Assert.AreEqual("Incorrect file Extension", ex.Message);
        }

        //TC 1.4 Delimeter if incorrect returns a custom exception
        [Test]
        public void incorrectDelimeter()
        {
            var analyser = new StateCensusAnalyser();
            var ex = Assert.Throws<CsvCustomException>(() => new StateCensusAnalyser().LoadCsvData("C:/Users/User/source/repos/StateCensusData.csv", "State,Population,AreaInSqKm,DensityPerSqKm", "SrNo,StateName,TIN,StateCode"));
            Assert.AreEqual("Delimeter or Header is incorrect", ex.Message);
        }

        //TC 1.5 Header if incorrect returns a custom exception
        [Test]
        public void incorrectHeader()
        {
            var analyser = new StateCensusAnalyser();
            var ex = Assert.Throws<CsvCustomException>(() => new StateCensusAnalyser().LoadCsvData("C:/Users/User/source/repos/StateCensusData.csv", "State,Population,AreaInSqKm,DensityPerSqKm", "SrNo,StateName,TIN,StateCode"));
            Assert.AreEqual("Delimeter or Header is incorrect", ex.Message);
        }

        //TC 2.1 check to ensure the number of records matches
        [Test]
        public void recordMatchesForStateCode()
        {
            CsvStates analyser = new CsvStates();
            object totalRecords = analyser.LoadCsvData("C:/Users/User/source/repos/StateCodeCopy.csv");
            Assert.AreEqual(38, totalRecords);
        }

        //TC 2.2 file path if incorrect returns a custom exception
        [Test]
        public void incorrectFilePathForStateCode()
        {
            var analyser = new StateCensusAnalyser();
            var ex = Assert.Throws<CsvCustomException>(() => new StateCensusAnalyser().LoadCsvData("C:/Users/User/source/repos/IndianStateCensusAnalyser/StateCode.csv", "State,Population,AreaInSqKm,DensityPerSqKm", "SrNo,StateName,TIN,StateCode"));
            Assert.AreEqual("Incorrect file Path", ex.Message);
        }

        //TC 2.3 file extension if incorrect returns a custom extension
        [Test]
        public void incorrectFileExtensionForStateCode()
        {
            var analyser = new StateCensusAnalyser();
            var ex = Assert.Throws<CsvCustomException>(() => new StateCensusAnalyser().LoadCsvData("C:/Users/User/source/repos/StateCode.txt", "State,Population,AreaInSqKm,DensityPerSqKm", "SrNo,StateName,TIN,StateCode"));
            Assert.AreEqual("Incorrect file Extension", ex.Message);
        }

        //TC 2.4 Delimeter if incorrect returns a custom exception
        [Test]
        public void incorrectDelimeterForStateCode()
        {
            var analyser = new StateCensusAnalyser();
            var ex = Assert.Throws<CsvCustomException>(() => new StateCensusAnalyser().LoadCsvData("C:/Users/User/source/repos/StateCode.csv", "State,Population,AreaInSqKm,DensityPerSqKm", "SrNo,StateName,TIN,StateCode"));
            Assert.AreEqual("Delimeter or Header is incorrect", ex.Message);
        }

        //TC 2.5 Header if incorrect returns a custom exception
        [Test]
        public void incorrectHeaderForStateCode()
        {
            var analyser = new StateCensusAnalyser();
            var ex = Assert.Throws<CsvCustomException>(() => new StateCensusAnalyser().LoadCsvData("C:/Users/User/source/repos/StateCode.csv", "State,Population,AreaInSqKm,DensityPerSqKm", "SrNo,StateName,TIN,StateCode"));
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
    }
}