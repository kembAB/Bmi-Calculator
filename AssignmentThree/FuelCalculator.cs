using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    class FuelCalculator
    {
        private double fuelcurrent;
        private double fuelPrevious;
        private double fueltanked;
        private double fuelperliter;
        //private double unitprice;
        const double kmToMileFactor = 0.621371192;


        public FuelCalculator()
        {
            fuelcurrent = 0.0;
            fuelPrevious = 0.0;
            fueltanked = 0.0;
            fuelperliter = 0.0;
            
        }
        public void setfuelcurrent(double fuelcurrent)
        {
            this.fuelcurrent = fuelcurrent;

        }
        public double Getfuelcurrent()
        {
            return fuelcurrent;
        }
        //end
        public void setfuelPrevious(double fuelPrevious)
        {
            this.fuelPrevious = fuelPrevious;
        }
        public double GetfuelPrevious()
        {
            return fuelPrevious;
        }
        public void setfueltanked(double fueltanked)
        {
            this.fueltanked = fueltanked;
        }
        public double Getfueltankedt()
        {
            return fueltanked;
        }
        public void setfuelperliter(double fuelperliter)
        {
            if (fuelperliter >= 0)
                this.fuelperliter = fuelperliter;
        }
        public double Getfuelperliter()
        {
            return fuelperliter;
        }

        public double CalculateLitPerKm()
        {
            
            double km = fuelcurrent - fuelPrevious;
            double litPerkm = fueltanked / km;
            return litPerkm;
        }
        public double CalculateKmPerLit()
        {
            
            double km = fuelcurrent - fuelPrevious;
            double kmperlit = km / fueltanked;
            return kmperlit;
        }
        public double CalculatelitPerMetricMile()
        {
            
            double litpermetricmile = CalculateLitPerKm() / kmToMileFactor;
            return litpermetricmile;
        }
        public double CalculateSwedishMile()
        {
            
            double literPerSwedMile = CalculateLitPerKm() * 10;

            return literPerSwedMile;
        }
        public double CalculateCostPerKm()
        {
            
          
            
            double costperkm = fuelperliter * CalculateLitPerKm();
            return costperkm;
        }

    }

}
