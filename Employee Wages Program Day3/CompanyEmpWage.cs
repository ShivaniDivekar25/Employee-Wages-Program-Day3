﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wages_Program_Day3
{
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHrs, maxWorkingDays, maxWorkingHrs,totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHrs, int maxWorkingDays, int maxWorkingHrs)
        {
            this.company = company;
            this.empRatePerHrs = empRatePerHrs;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }

        public void SetTotalWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public override string ToString()
        {
            return $"company:{company} RatePerHr:{empRatePerHrs} Days:{maxWorkingDays} Hrs:{maxWorkingHrs} totalWage:{totalEmpWage}";
        }
    }
}
