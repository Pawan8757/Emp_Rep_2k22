using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReport
{
    public class MonthSalary
    {
        public static void FindingEmpSalary()
        {
            int IsFullTime = 1;
            int IsPartTime = 2;
            int EmpRatePerHrs = 20;
            int TotalWorkingDay = 20;
            int TotalSalary = 0;
            int WorkingHours;
            int empWage;
            int TotalEmpWage;



            for (int Day = 0; Day <= TotalWorkingDay; Day++);
            {
                Random random = new Random();
                int num = random.Next(3);
                switch (num)
                {
                    case 1:
                        WorkingHours = 8;
                        break;

                    case 2:
                        WorkingHours = 4;
                        break;

                    default:
                        WorkingHours = 0;
                        break;

                }
                empWage = WorkingHours * EmpRatePerHrs;
                
            }
                    TotalWorkingDay++;
            TotalEmpWage = empWage + TotalSalary;
            Console.WriteLine("Emp Wage is " + TotalEmpWage);
        }
    }
}
