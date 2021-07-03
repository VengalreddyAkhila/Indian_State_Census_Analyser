using IndianStateAdapter;
using IndianStateCensus.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensus 
{
    public class CSVAdapterFactory
    {
        public Dictionary<string , CensusDTO>LoadCsvData(CensusAnalyser.Country country,string csvFilePath,string dataHeaders)
        {
            switch(country)
            {
                case (CensusAnalyser.Country.INDIA):
                    return new IndianStateAdapter.IndianCensusAdapter().LoadCensusData(csvFilePath, dataHeaders);
                //case (CensusAnalyser.Country.US):
                //    return new USCensusAdaptor().LoadUSCensusData(csvFilePath, dataHeaders);
                default:
                    throw new CensusAnalyserException("no such country", CensusAnalyserException.ExceptionType.NO_SUCH_COUNTRY);
            }
        }
    }
}
