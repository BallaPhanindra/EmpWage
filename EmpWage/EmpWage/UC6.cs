using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class UC6
    {
        public const int IS_FULLTIME = 2;
        public const int IS_PARTTIME = 1;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int  NUMBER_OF_WORKING_DAYS= 2;
        public const int MAX_HOURS_IN_MONTH = 10;

        public void WagePerMonthOrDays()
        {


            int empHours = 0, totalEmpHours = 0, totalWorkingDays = 0;

            while (totalEmpHours <= MAX_HOURS_IN_MONTH && totalWorkingDays < NUMBER_OF_WORKING_DAYS)
            {
                totalWorkingDays++;

                Random rand = new Random();
                int num = rand.Next(0, 3);
                Console.WriteLine("Employee attendance " + num);

                switch (num)
                {
                    case IS_PARTTIME:
                        empHours = 4;
                        break;
                    case IS_FULLTIME:
                        empHours = 8;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                totalEmpHours += empHours;

                Console.WriteLine(" Total Days: " + totalWorkingDays + " emp Hours:  " + empHours);
            }

            int totalWage = totalEmpHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage is :" + totalWage);
        }
    }
}