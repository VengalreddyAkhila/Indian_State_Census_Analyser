﻿using CsvHelper;
using IndianStateCensus.POCO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace IndianStateCensus
{
    public class CensusAnalyser
    {
       public enum Country
        {
            INDIA,US,BRAZIL
       }
        Dictionary<string, CensusDTO> dataMap;
        public Dictionary<string , CensusDTO> LoadCensusData(Country country,string csvFilePath,string dataHeaders)
        {
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }

        internal Dictionary<string, CensusDTO> LoadCensusData(string csvFilePath, string dataHeaders)
        {
            throw new NotImplementedException();
        }
    }
}