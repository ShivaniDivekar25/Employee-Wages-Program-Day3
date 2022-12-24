using System;

namespace Employee_Wages_Program_Day3
{
    internal class Program
    {
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;
        public const int EMP_RATE_PER_HRS = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_RATE_IN_MONTH = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wages computation program!");
            CalculateWages();
            Console.ReadLine();
        }

        public static void CalculateWages()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            Random random5 = new Random();

            while (totalEmpHrs < MAX_RATE_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
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

                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs: " + empHrs);
            }
            int totalEmpWages = totalEmpHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Total Employee wages:" + totalEmpWages);
        }
    }
}