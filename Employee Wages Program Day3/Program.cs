using System;

namespace Employee_Wages_Program_Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wages computation program!");
            int empHrs = 0;
            int empWages = 0;
            int totalWages = 0;
            int NUM_OF_WORKING_DAYS = 20, EMP_RATE_PER_HRS = 20;

            for ( int Day = 1; Day <= NUM_OF_WORKING_DAYS; Day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
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

                empWages = empHrs * EMP_RATE_PER_HRS;
                totalWages = totalWages + empWages;
            }
            Console.WriteLine("Total monthly wages of an employee is: " + totalWages);
        }
    }
}