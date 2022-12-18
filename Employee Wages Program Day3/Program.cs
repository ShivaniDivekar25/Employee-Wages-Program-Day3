using System;

namespace Employee_Wages_Program_Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wages computation program!");
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            int IS_PRESENT = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWages = 0;
            if (empCheck == IS_PRESENT)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWages = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wages: " + empWages);
        }
    }
}