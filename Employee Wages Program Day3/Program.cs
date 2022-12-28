using System;

namespace Employee_Wages_Program_Day3
{
    class CompanyWageBuilder     //Created class
    {
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;
        CompanyEmpWage[] companies;
        int numbOfCompanies = 0;

        public CompanyWageBuilder()
        {
            companies = new CompanyEmpWage[5];
        }

        public void AddComapnyDetailsIntoArray(string company, int empRatePerHrs, int maxWorkingDays, int maxWorkingHrs)
        {
            CompanyEmpWage comp = new CompanyEmpWage(company, empRatePerHrs, maxWorkingDays, maxWorkingHrs);
            companies[numbOfCompanies] = comp;
            numbOfCompanies++;
        }

        public void IterateOverCompany()
        {
            for(int i=0; i< numbOfCompanies; i++)
            {
                int totalEmpWage = CalculateWages(companies[i]);
                companies[i].SetTotalWage(totalEmpWage);
                Console.WriteLine(companies[i].ToString());
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
           /*CompanyWage BridgeLabz = new CompanyWage("Bridgelabz", 30, 25, 70);
            BridgeLabz.CalculateWages();
            CompanyWage Delloite = new CompanyWage("Deloitte", 40, 35, 80);
            Delloite.CalculateWages();
            CompanyWage Microsoft = new CompanyWage("Microsoft", 35, 45, 70);
            Microsoft.CalculateWages();*/
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