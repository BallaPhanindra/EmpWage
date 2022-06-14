using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProj
{
    internal class UC2
    {
        public void EmpWage()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 0;

            int emphrs = 0;
            int empWage=0;

            Random r = new Random();
            int empCheck = r.Next(0, 2);

            if (empCheck == IS_FULL_TIME)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empWage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage is :"+empWage);

        }
    }
}