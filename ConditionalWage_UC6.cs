using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpHrPerMonth;

public class EmpPerMont
{

    public const int PartTime = 1;
    public const int FullTime = 2;
    public const int empRatePerHr = 20;
    public const int NumOfWorkingDays = 20;
    public const int MaxHrInMon = 100;
    public static void EmpMonHr()

    {
        int emphrs = 0;



        int TotalHr = 0;


        int TotalSalary = 0;
        int WorkingDays = 0;


        while (TotalHr < MaxHrInMon || WorkingDays < NumOfWorkingDays)
        {
            WorkingDays++;

            Random random = new Random();
            int num = random.Next(3);

            switch (num)
            {
                case PartTime:
                    emphrs = 4;
                    break;

                case FullTime:
                    emphrs = 8;
                    break;

                default:
                    emphrs = 0;
                    break;

            }

            TotalHr = (TotalHr + emphrs);

            Console.WriteLine("total hours" + TotalHr);
        }

        TotalSalary = (TotalHr * empRatePerHr);

        Console.WriteLine("totalsalary" + TotalSalary);
    }
}
