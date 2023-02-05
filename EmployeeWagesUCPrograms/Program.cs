using System.Linq.Expressions;

namespace EmployeeWagesUCPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Prgrams");
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            EmployeeWagesUC1.EmployeeUC1(empCheck);
        }
    }
}