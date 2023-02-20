using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesUCPrograms
{
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHr;
        public int numOfWorkingDays;
        public int maxHrsPerMonth;
        public int totalEmpWages;
        public CompanyEmpWage(string company, int empRatePerHr,int numOfWorkingDays,int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }
        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWages = totalEmpWage;
        }
        public string ToString()
        {
            return $"Company:{company} RateperHr:{empRatePerHr} Days:{numOfWorkingDays} Hrs:{maxHrsPerMonth}";
        }
    }
}
