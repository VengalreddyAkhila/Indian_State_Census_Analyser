using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensus.POCO
{
    public class CensusDTO
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public int tin;
        public string stateCode;
        public long population;
        public long area;
        public long density;
        public long housingUnits;
        public double totalArea;
        public double WaterArea;
        public double landArea;
        public double populationDensity;
        public double housingDensity;

        public CensusDTO(StateCodeDAO stateCodeDAO)
        {
            this.serialNumber = stateCodeDAO.serialNumber;
            this.stateName = stateCodeDAO.stateName;
            this.tin = stateCodeDAO.tin;
            this.stateCode = stateCodeDAO.stateCode;
        }
        public CensusDTO(CensusDataDAO censusDataDAO)
        {
            this.state = censusDataDAO.state;
            this.population = censusDataDAO.population;
            this.area = censusDataDAO.area;
            this.density = censusDataDAO.density;
        }
       /* public CensusDTO(USCensusDAO usCensusDAO)
        {
            this.stateCode = usCensusDAO.stateCode;
            this.stateName = usCensusDAO.stateName;
            this.population = usCensusDAO.Population;            
            this.housingUnits = usCensusDAO.housingUnits;
            this.totalArea = usCensusDAO.totalArea;
            this.WaterArea = usCensusDAO.WaterArea;
            this.landArea = usCensusDAO.landArea;
            this.populationDensity = usCensusDAO.populationDensity;
            this.housingDensity = usCensusDAO.housingDensity;

        }*/
    }
}