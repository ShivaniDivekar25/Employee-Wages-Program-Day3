using System;
using System.Text;

namespace Employee_Wages_Program_Day3
{
    class CompanyWageBuilder:IComapanyWageBuilder     //Created class
    {
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;
        //CompanyEmpWage[] companies;       //Using array
        //int numbOfCompanies = 0;
        List<CompanyEmpWage> list;          //Using collection
        Dictionary<string, CompanyEmpWage> dic;         //Using Dictionary
        public CompanyWageBuilder()
        {
            //companies = new CompanyEmpWage[5];
            list = new List<CompanyEmpWage>();
            dic = new Dictionary<string, CompanyEmpWage>();
        }

        public void AddComapnyDetailsIntoArray(string company, int empRatePerHrs, int maxWorkingDays, int maxWorkingHrs)
        {
            CompanyEmpWage comp = new CompanyEmpWage(company, empRatePerHrs, maxWorkingDays, maxWorkingHrs);
            //companies[numbOfCompanies] = comp;
            //numbOfCompanies++;
            list.Add(comp);
            dic.Add(company, comp);
        }

        public int GetTotalWageBasedOnCompany(string companyName)
        {
            return dic[companyName].totalEmpWage;
        }

        public void IterateOverCompany()
        {
            for (int i = 0; i < list.Count; i++)
            {
                int totalEmpWage = CalculateWages(list[i]);
                list[i].SetTotalWage(totalEmpWage);
                Console.WriteLine(list[i].ToString());
            }
        }
        static void Main(string[] args)     //Calling methods in main method
        {
            Console.WriteLine("Welcome to employee wages computation program!");
            CompanyWageBuilder builder = new CompanyWageBuilder();
            builder.AddComapnyDetailsIntoArray("Bridgelabz", 30, 25, 70);
            builder.AddComapnyDetailsIntoArray("Deloitte", 40, 35, 80);
            builder.AddComapnyDetailsIntoArray("Microsoft", 35, 45, 70);
            builder.IterateOverCompany();
            Console.WriteLine("Get total wages using companyName " + builder.GetTotalWageBasedOnCompany("Deloitte"));
        }

        public int CalculateWages(CompanyEmpWage companyDetails)         //Creating method for wages
        { 
            int empHrs = 0, empWage = 0, totalEmpHrs = 0, totalWorkingDays = 0, totalEmpWages = 0;          //Initializing value
            Random random5 = new Random();

            while (totalEmpHrs < companyDetails.maxWorkingHrs && totalWorkingDays < companyDetails.maxWorkingDays)            //While loop for required condition and computation
            {
                totalWorkingDays++;
                int empCheck = random5.Next(0, 3);
                switch (empCheck)
                {
                     case IS_PARTTIME:
                         empHrs = 4;
                         break;
                     case IS_FULLTIME:
                         empHrs = 8;
                         break;
                     default:
                         empHrs = 0;
                         break;
                }
                empWage = companyDetails.empRatePerHrs * empHrs;
                totalEmpHrs = totalEmpHrs + empHrs;
                totalEmpWages = totalEmpHrs * companyDetails.empRatePerHrs;

            }
                //Console.WriteLine("Total Employee wages for {0} {1} days:{2} and Hrs:{3}", companyDetails.company, (totalWorkingDays-1),totalEmpWages,(totalEmpHrs-empHrs));
                return totalEmpWages;
       
        }
    }
}