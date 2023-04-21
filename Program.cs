using System;

namespace EmployeeWage01
{
    internal class Program
    {
        const int maxWorkingDays = 20;
        const int maxWorkoingHours = 100;
        const int empPerHourWage = 20;
        static void Main(string[] args)
        {
            int empPerDayHour = 0;
            int totalEmployeeWage = 0;
            int workingDays = 0;
            int workoingHours = 0;

            Console.WriteLine("Welcome To EmployeeWage Computation Program\n");
            Random rnd = new Random();
            while (workingDays < maxWorkingDays && workoingHours < maxWorkoingHours)
            {
                workingDays++;
                int checke = rnd.Next(0, 3);
                switch (checke)
                {
                    case 1:
                        empPerDayHour = 8;
                        break;
                    case 2:
                        empPerDayHour = 4;
                        break;
                    default:
                        empPerDayHour = 0;
                        break;
                }
                workoingHours += empPerDayHour;

                int empDailyWage = empPerDayHour * empPerHourWage;
                totalEmployeeWage += empDailyWage;
            }

            Console.WriteLine($"Employee Monthly Wage Is :{totalEmployeeWage}$\n" +
                              $"working Days in month :{workingDays}\n" +
                              $"working hours in month:{workoingHours}\n");
            Console.ReadLine();
        }
    }
}