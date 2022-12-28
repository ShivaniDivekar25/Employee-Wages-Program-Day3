using System;

namespace Employee_Wages_Program_Day3
{
    class CompanyWage     //Created class
    {
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;
        public string company;
        public int empRatePerHrs, maxWorkingDays, maxWorkingHrs;

        public CompanyWage(string company, int empRatePerHrs, int maxWorkingDays, int maxWorkingHrs)
        {
            this.company = company;
            this.empRatePerHrs = empRatePerHrs;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }

        static void Main(string[] args)     //Calling methods in main method
        {
            Console.WriteLine("Welcome to employee wages computation program!");
            CompanyWage BridgeLabz = new CompanyWage("Bridgelabz", 30, 25, 70);
            BridgeLabz.CalculateWages();
            CompanyWage Delloite = new CompanyWage("Deloitte", 40, 35, 80);
            Delloite.CalculateWages();
            CompanyWage Microsoft = new CompanyWage("Microsoft", 35, 45, 70);
            Microsoft.CalculateWages();
        }

        public void CalculateWages()         //Creating method for wages
        {
            int empHrs = 0, empWage = 0, totalEmpHrs = 0, totalWorkingDays = 0, totalEmpWages = 0;          //Initializing value
            Random random5 = new Random();                                                                          

            while (totalEmpHrs < maxWorkingHrs && totalWorkingDays < maxWorkingDays)            //While loop for required condition and computation
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
                empWage = empRatePerHrs * empHrs;
                totalEmpHrs = totalEmpHrs + empHrs;
                totalEmpWages = totalEmpHrs * empRatePerHrs;
               
            }
            Console.WriteLine("Total Employee wages for {0} {1} days:{2} and Hrs:{3}", company,(totalWorkingDays-1),totalEmpWages,(totalEmpHrs-empHrs));
        }
    }
}