using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {

           UC8_EmpWageForMultipleCompanies.ComputeEmpWage("DMart",25,26,80); //UC8
           UC8_EmpWageForMultipleCompanies.ComputeEmpWage("Reliance", 20, 22, 100);

           Console.ReadLine();
        }
    }
}
