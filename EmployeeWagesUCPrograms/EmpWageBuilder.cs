using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesUCPrograms
{
    public class EmpWageBuilder
    {
        //Initialize input
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;

        private string company;
        private int empRatePerHr;
        private int numOfWorkingDays;
        private int maxHrsPerMonth;
        private int totalEmpWages;

        //Created parameterized constructor
        public EmpWageBuilder(string company, int empRatePerHr, int numOfWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }

        //Created method Employee wage UC9
        public void EmployeeUC9()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= this.maxHrsPerMonth && totalWorkingDays <= this.numOfWorkingDays)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                totalWorkingDays++;
                switch (empCheck)
                {
                    case IS_PARTTIME:
                        empHrs = 4;
                        break;
                    case IS_FULLTIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs: " + empHrs);
            }
            totalEmpWages = totalEmpHrs * this.empRatePerHr;
        }
        public string ToString()
        {
            return "Total Employee wage for company: " + this.company + " is: " + this.totalEmpWages;
        }
    }
}
