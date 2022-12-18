using System;

namespace Employee_Wages_Program_Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wages computation program!");
            int empHrs = 0, totalEmpHrs=0, totalWorkingDays = 0; 
            int NUM_OF_WORKING_DAYS = 20, EMP_RATE_PER_HRS = 20, MAX_RATE_IN_MONTH = 100; 
            while (totalEmpHrs < MAX_RATE_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                totalWorkingDays++;
                switch (empCheck)
                {
                    case 1:
                        empHrs = 4;
                        break;
                    case 2:
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