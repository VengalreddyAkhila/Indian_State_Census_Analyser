using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensus.POCO
{
    public class StateCodeDAO
    {
        public int serialNumber;
        public string stateName;
        public int tin;
        public string stateCode;
        private string v1;
        private string v2;
        private string v3;
        private string v4;

        public StateCodeDAO(int serialNumber,string stateName,int tin,string stateCode)
        {
            this.serialNumber = Convert.ToInt32(serialNumber);
            this.stateName = stateName;
            this.tin = Convert.ToInt32(tin);
            this.stateCode = stateCode;
        }

        public StateCodeDAO(string v1, string v2, string v3, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }
    }
}
