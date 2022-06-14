using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProj
{
    internal class UC4
    {
        public void SwitchUsage()
        {
            Random r = new Random();
            int n = r.Next(0, 3);
            switch (n)
            {
                case 0:
                    Console.WriteLine("The Employee is absent");
                    break;
                case 1:
                    Console.WriteLine("The Employee is present");
                    int wagePerHoour = 20;
                    int fullDayHours = 8;
                    int dailyEmpWage = wagePerHoour * fullDayHours;
                    Console.WriteLine("Daily Emp Wage is :" + dailyEmpWage);

                    int partTimeHours = 4;
                    dailyEmpWage = wagePerHoour * partTimeHours;
                    Console.WriteLine("Wage for Part Time Employee is :" + dailyEmpWage);
                    break;
                default:
                    Console.WriteLine("Wrong details");
                    break;

            }
        }
    }
}