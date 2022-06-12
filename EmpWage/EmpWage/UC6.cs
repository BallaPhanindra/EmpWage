using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class UC6
    {
        public const int isFullTime = 2;
        public const int isPartTime = 1;
        public const int isAbsent = 0;

        public void WagePerMonthOrDays()
        {
            Random rand = new Random();
            int num = rand.Next(0, 3);
            Console.WriteLine("Employee attendance " + num);
            int partTimeHour = 4;
            int fullTimeHour = 8;
            int wagePerHour = 20;
            int numberOfWorkingDays = 20;
        

            int totalWage = 0;
            int totalHours = 0;
                    for (int i = 0; i < numberOfWorkingDays; i++)
                    {

                        switch (num)
                        {
                            case isPartTime:
                                totalWage = totalWage + wagePerHour * partTimeHour;
                                totalHours = totalHours + partTimeHour;
                                break;
                            case isFullTime:
                                totalWage = totalWage + wagePerHour * fullTimeHour;
                                totalHours = totalHours + partTimeHour;
                                break;
                            default:
                                totalWage = totalWage + isAbsent;
                                totalHours = totalHours + partTimeHour;
                                break;
                        }
                    }
                
                    Console.WriteLine("Wage per Month is : " + totalWage);
        }
    }
}