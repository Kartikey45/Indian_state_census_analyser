using IndianStateCensusAnalyser;
using NUnit.Framework;

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
    }
}