using System;

namespace Employee_Wages_Program_Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wages computation program!");
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            int empHrs = 0, empWages = 0, EMP_RATE_PER_HRS = 20;
            switch(empCheck)
            { 
                case 1:
                    empHrs = 8;
                    Console.WriteLine("Employee is present and doing Fulltime");
                    break;
                case 2:
                    empHrs = 4;
                    Console.WriteLine("Employee is present and doing Parttime");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }
            empWages = empHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Employee wages:" + empWages);
        }
    }
}