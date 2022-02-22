using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReport
{
    public class EmpDailyPartTimeWage
    {
        public static void CheckWages()
        {
            int PartTime = 1;
            int FullTime = 2;
            int Emp_Wage_Hour = 20;
            int EmpHrs = 0;

            Random random = new Random();   
            int num = random.Next(3);
            
            if(num==PartTime)
            {
                EmpHrs = 4;

            }
            else if(num==FullTime)
            {
                EmpHrs = 8;

            }
            else
            {
                EmpHrs = 0;
            }
            int EmployeeWage = Emp_Wage_Hour * EmpHrs;
            Console.WriteLine(EmployeeWage);
            }
        }
    }

