using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class EmployeeMonthlyWageCondition  //UC6
    {
        const int IS_FULL_TIME = 1;
        const int IS_Part_Time = 2;
        const int EMP_RATE_PER_HOUR = 20;
        const int WORKING_DAYS = 20;
        const int Max_HRS_IN_MONTH = 100;

        public static void GetMonthlyWage()
        {
           
            int empHrs = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= Max_HRS_IN_MONTH || totalWorkingDays <= 20)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    case IS_Part_Time:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day :" + (totalWorkingDays) + ",Emp Working Hrs :" + empHrs);
            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage For the Month :" +totalEmpWage);
            Console.ReadLine();
        }
    }
}
