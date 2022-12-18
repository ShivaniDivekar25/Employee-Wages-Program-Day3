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
            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}