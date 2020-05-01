using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyser
{
    public class IndianCensusDTO
    {
        private string StateCensusFilePath;
        private string StateCodeFilePath;
        private string USCensusFilePath;
        public IndianCensusDTO(string stateCensusFilePath, string stateCodeFilePath)
        {
            StateCensusFilePath = stateCensusFilePath;
            StateCodeFilePath = stateCodeFilePath;
        }

        public string StateCensusPath
        {
            get
            {
                return StateCensusFilePath;
            }
        }

        public string StateCodePath
        {
            get
            {
                return StateCodeFilePath;
            }
        }
    }
}
