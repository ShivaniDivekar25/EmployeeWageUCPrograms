using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesUCPrograms
{
    public class EmployeeWageBuilder
    {
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;
        List<CompanyEmpWage> list;
        Dictionary<string, CompanyEmpWage> dic;
        //public int numOfCompany = 0;
        //public CompanyEmpWage[] companyEmpWageArray;

        public EmployeeWageBuilder()
        {
            //this.companyEmpWageArray = new CompanyEmpWage[5];
            list = new List<CompanyEmpWage>();
            dic = new Dictionary<string, CompanyEmpWage>();
        }
        public void AddCompanyEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int maxHrsPerMonth)
        {
            CompanyEmpWage comp = new CompanyEmpWage(company, empRatePerHr, maxHrsPerMonth, numOfWorkingDays);
            //companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHr, numOfWorkingDays, maxHrsPerMonth);
            //numOfCompany++;
            list.Add(comp);
            dic.Add(company, comp);
        }
        public int GetTotalWageBasedOnCompany(string companyName)
        {
            return dic[companyName].totalEmpWages;
        }
        public void ComputeEmpWagesForCompany()
        {
            for (int i = 0; i < list.Count; i++)
            {
                //companyEmpWageArray[i].SetTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                //Console.WriteLine(this.companyEmpWageArray[i].ToString());
                int totalEmpWage = ComputeEmpWage(list[i]);
                list[i].SetTotalEmpWage(totalEmpWage);
                Console.WriteLine(list[i].ToString());
            }
        }
        public int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, empWage = 0, totalEmpHrs = 0, totalWorkingDays = 0, totalEmpWages = 0;
            while (totalEmpHrs < companyEmpWage.maxHrsPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
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
                empWage = companyEmpWage.empRatePerHr * empHrs;
                totalEmpHrs = totalEmpHrs + empHrs;
                totalEmpWages = totalEmpHrs * companyEmpWage.empRatePerHr;
                //Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs: " + empHrs);
            }
            return totalEmpWages;
        }
    }
}
