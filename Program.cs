using System;

namespace MonthlySalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("enter Employee Type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");
            Console.Write("Enter employee type (1, 2, or 3): ");
            int employeeType = int.Parse(Console.ReadLine());
            int workingHours, workingDays, projectHandles, extras;
            double monthlySalary;
            switch (employeeType)
            {
                case 1:
                    Console.Write("Enter working hours: ");
                    workingHours = int.Parse(Console.ReadLine());
                    Console.Write("Enter number of working days: ");
                    workingDays = int.Parse(Console.ReadLine());
                    monthlySalary = CalculateSalaryHR(workingHours, workingDays);
                    break;
                case 2:
                    Console.Write("Enter working hours: ");
                    workingHours = int.Parse(Console.ReadLine());
                    Console.Write("Enter number of working days: ");
                    workingDays = int.Parse(Console.ReadLine());
                    Console.Write("Enter number of project handles: ");
                    projectHandles = int.Parse(Console.ReadLine());
                    monthlySalary = CalculateSalaryAdmin(workingHours, workingDays, projectHandles);
                    break;
                case 3:
                    Console.Write("Enter working hours: ");
                    workingHours = int.Parse(Console.ReadLine());
                    Console.Write("Enter number of working days: ");
                    workingDays = int.Parse(Console.ReadLine());
                    Console.Write("Enter number of project handles: ");
                    projectHandles = int.Parse(Console.ReadLine());
                    Console.Write("Enter number of extras: ");
                    extras = int.Parse(Console.ReadLine());
                    monthlySalary = CalculateSalarySoftwareDeveloper(workingHours, workingDays, projectHandles, extras);
                    break;
                default:
                    Console.WriteLine("Invalid employee type entered.");
                    return;
            }
            Console.WriteLine("Monthly Salary: $" + monthlySalary);
        }
        static double CalculateSalaryHR(int workingHours, int workingDays)
        {
            return (workingHours * workingDays * 100) + 3000;
        }

        static double CalculateSalaryAdmin(int workingHours, int workingDays, int projectHandles)
        {
            return (workingHours * workingDays * 100) + (projectHandles * 300) + 3000;
        }
        static double CalculateSalarySoftwareDeveloper(int workingHours, int workingDays, int projectHandles, int extras)
        {
            return (workingHours * workingDays * 100) + (projectHandles * 300) + (extras * 200) + 3000;
        }
    }
}