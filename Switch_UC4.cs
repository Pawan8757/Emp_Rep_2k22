using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReport
{
    public class EmpSwitch
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;


        public static void CheckUsingSwitchCase()
        {
           
           
            Random random = new Random();
            int number = random.Next(3);
            int empHrs = 0;

            switch (number)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;

                case IS_FULL_TIME:
                    empHrs = 8;
                    break;

                default:
                    empHrs = 0;
                    break;
            }
           int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("empWage is " + empWage);
        }
            
    }
}

