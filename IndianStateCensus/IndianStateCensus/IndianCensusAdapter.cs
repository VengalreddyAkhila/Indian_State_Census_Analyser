using CensusAnalyser;
using IndianStateCensus.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndianStateAdapter
{
    public class IndianCensusAdapter:CensusAdaptor 
    {
        string[] censusData;
        Dictionary<string, CensusDTO> dataMap;
        public Dictionary<string,CensusDTO>LoadCensusData(string csvFilePath,string dataHeaders)
        {
            dataMap = new Dictionary<string, CensusDTO>();
            censusData = GetCensusData(csvFilePath, dataHeaders);
            foreach (string data in censusData.Skip(1))
            {
                if (!data.Contains(","))
                {
                    throw new CensusAnalyserException("file contain wrong delimiter", CensusAnalyserException.ExceptionType.INCORRECT_DELIMITER);
                }

                string[] column = dataHeaders.Split(",");
                if (csvFilePath.Contains("indianstatecode.csv"))
                    dataMap.Add(column[1], new CensusDTO(new StateCodeDAO(column[0], column[1], column[2], column[3])));
                if (csvFilePath.Contains("indianstatecensusdata.csv"))
                    dataMap.Add(column[0], new CensusDTO(new CensusDataDAO(column[0], column[1], column[2], column[3])));
            }
            return dataMap.ToDictionary(p => p.Key, p => p.Value);
        }
        
    }
}
