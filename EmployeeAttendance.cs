using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class EmployeeMonthlyWage  //UC5
    {
        const int IS_FULL_TIME = 1;
        const int IS_Part_Time = 2;
        const int EMP_RATE_PER_HOUR = 20;
        const int Working_Days = 20;

        public static void GetMonthlyWage()
        {
           
            int empHrs = 0;
            int empWage = 0;
            int total_emp_Wage = 0;
            for (int i = 1; i <= Working_Days; i++)
            {

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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                total_emp_Wage += empWage;
            }
            Console.WriteLine("Employee Wage Per Month:" + total_emp_Wage);
            Console.ReadLine();
        }
    }
}
