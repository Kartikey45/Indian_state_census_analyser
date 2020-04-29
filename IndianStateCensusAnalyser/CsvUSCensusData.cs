using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;

namespace IndianStateCensusAnalyser
{
    public class CsvUSCensusData 
    {
        //Variable Initialize
        private string StateId;
        private string State;
        private string Population;
        private string HousingUnits;
        private string TotalArea;
        private string WaterArea;
        private string LandArea;
        private string PopulationDensity;
        private string HousingDensity;

        //Created Get and set method to access private variable 
        public string stateId
        {
            get { return StateId ; }
            set { StateId = value ; }
        }

        public string state
        {
            get { return State; }
            set { State = value; }
        }

        public string population
        {
            get { return Population; }
            set { Population = value; }
        }

        public string housingUnits
        {
            get { return HousingUnits; }
            set { HousingUnits = value; }
        }

        public string totalArea
        {
            get { return TotalArea; }
            set { TotalArea = value; }
        }

        public string waterArea
        {
            get { return WaterArea; }
            set { WaterArea = value; }
        }

        public string landArea
        {
            get { return LandArea; }
            set { landArea = value; }
        }
        
        public string populationDensity
        {
            get { return PopulationDensity; }
            set { PopulationDensity = value; }
        }

        public string housingDensity
        {
            get { return HousingDensity; }
            set { HousingDensity = value; }
        }

        //Declare columns and headers of Census data.
        public CsvUSCensusData FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            CsvUSCensusData csvUSCensusData = new CsvUSCensusData();
            csvUSCensusData.StateId = Convert.ToString(values[0]);
            csvUSCensusData.State = Convert.ToString(values[1]);
            csvUSCensusData.Population = Convert.ToString(values[2]);
            csvUSCensusData.HousingUnits = Convert.ToString(values[3]);
            csvUSCensusData.TotalArea = Convert.ToString(values[4]);
            csvUSCensusData.WaterArea = Convert.ToString(values[5]);
            csvUSCensusData.LandArea = Convert.ToString(values[6]);
            csvUSCensusData.PopulationDensity = Convert.ToString(values[7]);
            csvUSCensusData.HousingDensity = Convert.ToString(values[8]);
            return csvUSCensusData;
        }
    }
}
