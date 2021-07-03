using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateAdapter
{
    public class CensusAnalyserException: Exception
    {
        public enum ExceptionType
        {
            FILE_NOT_FOUND,INVALID_FILE_TYPE,INCORRECT_HEADER,INCORRECT_DELIMITER,NO_SUCH_COUNTRY
        }
        public ExceptionType etype;
        public CensusAnalyserException(string message, ExceptionType exceptionType):base(message)
        {
            this.etype = exceptionType;
        }
    }
}
