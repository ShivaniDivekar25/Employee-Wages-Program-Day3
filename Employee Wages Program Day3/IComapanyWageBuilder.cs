using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wages_Program_Day3
{
    internal interface IComapanyWageBuilder
    {
        int GetTotalWageBasedOnCompany(string componyName);
        void AddComapnyDetailsIntoArray(string company, int empRatePerHrs, int maxWorkingDays, int maxWorkingHrs);
    }
}
