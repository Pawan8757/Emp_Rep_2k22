using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReport
{ 
    public class EmployeeAbsentyCheck
    {
    public static void EmpAbsenty()
    {
        Random random = new Random();
        int num = random.Next(2);

        if (num == 1)
        {
            Console.WriteLine("Employee is present");
        }
        else
        {
            Console.WriteLine("Employee is absent");
        }
      }
   }
}


