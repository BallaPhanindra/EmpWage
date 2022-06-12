using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class UC2
    {
        public void EmpWage()
        {
            int IS_FULLTIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            int empHours = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck=random.Next(0,2);

            if(empCheck== IS_FULLTIME)
            {
                empHours = 8;
            }
            else
            {
                empHours = 4;
            }
            empWage=EMP_RATE_PER_HOUR* empHours;
            Console.WriteLine("Emp Wage :"+empWage);
        }
    }
}
