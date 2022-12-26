using System;

namespace Employee_Wages_Program_Day3
{
    internal class Program      //Created class
    {
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;
       
        static void Main(string[] args)     //Calling methods in main method
        {
            Console.WriteLine("Welcome to employee wages computation program!");
            CalculateWages("Bridgelabz",30,25,70);
            CalculateWages("Deloitte",40,35,80);
            CalculateWages("Microsoft", 35, 45, 70);
            Console.ReadLine();
        }

        public static void CalculateWages(string company, int empRateHrs, int maxWorkingDays,int maxWorkingHrs)         //Creating method for wages
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
                empWage = empRateHrs * empHrs;
                totalEmpHrs = totalEmpHrs + empHrs;
                totalEmpWages = totalEmpHrs * empRateHrs;
               
            }
            Console.WriteLine("Total Employee wages for {0} {1} days:{2} and Hrs:{3}", company,(totalWorkingDays-1),totalEmpWages,(totalEmpHrs-empHrs));
        }
    }
}