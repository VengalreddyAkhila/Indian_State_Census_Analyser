using IndianStateAdapter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CensusAnalyser
{
    public abstract class CensusAdaptor
    {
        protected string[] GetCensusData(string csvFilePath,string dataHeaders)
        {
            string[] censusData;
            if(!File.Exists(csvFilePath))
            {
                throw new CensusAnalyserException("file not found", CensusAnalyserException.ExceptionType.FILE_NOT_FOUND);
            }
            if(Path.GetExtension(csvFilePath) != "csv")
            {
                throw new CensusAnalyserException("Invalid file type", CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE);
            }
            censusData = File.ReadAllLines(csvFilePath);
            if(censusData[0] != dataHeaders)
            {
                throw new CensusAnalyserException("incorrect header in data", CensusAnalyserException.ExceptionType.INCORRECT_HEADER);
            }
            return censusData;
        }
    }
}
