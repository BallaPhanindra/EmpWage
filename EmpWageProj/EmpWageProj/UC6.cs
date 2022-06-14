using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProj
{
    internal class UC6
    {
        public const int IS_PART_TIME = 0;
        public const int IS_FULL_TYPE = 1;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int Num_OF_WORKING_HOURS = 2;
        public const int MAX_HOURS_IN_MONTH = 10;

        public void WagePerMonthOrDays()
        {
            int empHrs = 0;
            int totalEmpHours = 0;
            int totalWorkingDays = 0;

            while (totalEmpHours <= MAX_HOURS_IN_MONTH && totalWorkingDays <= Num_OF_WORKING_HOURS)
            {
                totalWorkingDays = 0;
                Random r = new Random();
                int empCheck = r.Next(0, 3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TYPE:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHours += empHrs;
                Console.WriteLine("Days " + totalWorkingDays + " Emp Hours " + empHrs);
            }
            int totalEmpWage = totalEmpHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total EmpWage is "+ totalEmpWage);
        }
    }
}
