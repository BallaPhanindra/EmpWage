﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProj
{
    internal class UC3
    {
        public int PartTimeWage()
        {
            int partTimeHours = 8;
            int wagePerHour = 20;
            int n = partTimeHours * wagePerHour;
            return n;
        }

    }
}