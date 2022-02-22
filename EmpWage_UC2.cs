using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReport
{
    public class EmpWageDaily
    {
        public static void CheckEmpWage()
        {
            int WagePerHr = 20;
            int FullWorkingDays = 8;

            Random random = new Random();
            int number = random.Next(2);

            if (number == 1)
            {
                int calculated = WagePerHr * FullWorkingDays;
                Console.WriteLine(calculated);
            }
            else
            {
                Console.WriteLine("Employee Absent");
            }
        }
    }
}
