using System.Linq.Expressions;

namespace EmployeeWagesUCPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Prgrams");
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("1:Employee is present or absent UC1\n2:Employee Wage UC2\n3:Employee wage UC3\n4:Employee wage UC4\n5:Employee wage UC5\n6:Employee wage UC6");
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
                default:
                    Console.WriteLine("Please enter right option");
                    break;

            }
        }
    }
}