using System.Linq.Expressions;

namespace EmployeeWagesUCPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Prgrams");
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("1:Employee is present or absent UC1\n2:Employee Wage UC2\n3:Employee wage UC3\n4:Employee wage UC4\n5:Employee wage UC5\n6:Employee wage UC6\n7:Refactor Employee wage UC7\n8:Refactor to compute multiple company wages\n9:Compute total wages for every company\n10:Manage multiple companies emp wage\n11:");
            int option = Convert.ToInt32(Console.ReadLine());
            //Switch case to call different method 
            switch (option)
            {
                case 1:
                    Random random = new Random();
                    int empCheck = random.Next(0, 2);
                    EmployeeWagesUC1.EmployeeUC1(empCheck);
                    break;
                case 2:
                    Random random1 = new Random();
                    int empCheck1 = random1.Next(0, 2);
                    EmployeeWagesUC2.EmployeeUC2(empCheck1);
                    break;
                case 3:
                    Random random2 = new Random();
                    int empCheck2 = random2.Next(0, 3);
                    EmployeeWagesUC3.EmployeeUC3(empCheck2);
                    break;
                case 4:
                    Random random3 = new Random();
                    int empCheck3 = random3.Next(0, 3);
                    EmployeeWagesUC4.EmployeeUC4(empCheck3);
                    break;
                case 5:
                    Random random4 = new Random();
                    int empCheck4 = random4.Next(0, 3);
                    EmployeeWagesUC5.EmployeeUC5(empCheck4);
                    break;
                case 6:
                    Random random5 = new Random();
                    int empCheck5 = random5.Next(0, 3);
                    EmployeeWagesUC6.EmployeeUC6(empCheck5);
                    break;
                case 7:
                    Random random6 = new Random();
                    int empCheck6 = random6.Next(0, 3);
                    EmployeeWagesUC6.EmployeeUC6(empCheck6);
                    break;
                case 8:
                    EmployeeWagesUC8.EmployeeUC8("Dmart", 20, 2, 10);
                    EmployeeWagesUC8.EmployeeUC8("Reliance", 10, 4, 20);
                    break;
                case 9:
                    EmpWageBuilder dMart = new EmpWageBuilder("DMart", 20, 2, 10);
                    EmpWageBuilder reliance = new EmpWageBuilder("Reliance", 10, 4, 20);
                    dMart.EmployeeUC9();
                    Console.WriteLine(dMart.ToString());
                    reliance.EmployeeUC9();
                    Console.WriteLine(reliance.ToString());
                    break;
                case 10:
                    EmployeeWageBuilder employeeWageBuilder = new EmployeeWageBuilder();
                    employeeWageBuilder.AddCompanyEmpWage("DMart", 20, 2, 10);
                    employeeWageBuilder.AddCompanyEmpWage("Reliance", 10, 4, 20);
                    employeeWageBuilder.ComputeEmpWagesForCompany();
                    Console.WriteLine();
                    break;
                case 11:
                    EmployeeWageBuilder builder = new EmployeeWageBuilder();
                    builder.AddCompanyEmpWage("DMart", 20, 5, 10);
                    builder.AddCompanyEmpWage("Reliance", 10, 4, 20);
                    builder.ComputeEmpWagesForCompany();
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;

            }
        }
    }
}