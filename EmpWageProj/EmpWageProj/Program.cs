using System;

namespace EmpWageProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to Employee Wage Computation program on master branch");
            Console.WriteLine("========UC1=======");
            UC1 u1 = new UC1();
            u1.EmpCheck();
            Console.WriteLine("========UC2=======");
            UC2 u2 = new UC2();
            u2.EmpWage();
            Console.WriteLine("========UC3=======");
            UC3 uc3 = new UC3();
            int x = uc3.PartTimeWage();
            Console.WriteLine("Part time wage of an employee is " + x);
            Console.WriteLine("========UC4=======");
            UC4 uc4 = new UC4();
            uc4.SwitchUsage();
            Console.WriteLine("========UC5=======");
            UC5 u5 = new UC5();
            u5.WagePerMonth();
            Console.WriteLine("========UC6=======");
            UC6 u6 = new UC6();
            u6.WagePerMonthOrDays();

            Console.WriteLine("Checking for revert command");
        }
    }
}