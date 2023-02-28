using Microsoft.Win32.SafeHandles;
using System;

namespace MyFirstCodeOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("****************");
                Console.WriteLine("* OOP CONCEPTS *");
                Console.WriteLine("****************");

                Console.WriteLine("Please put your birth date year:");
                var year = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Please put your birth date month:");
                var month = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Please put your birth date day:");
                var day = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine(new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)));
                Console.WriteLine("");
                Console.WriteLine("******Testing latest implementation*******");
                Console.WriteLine("");

                Console.WriteLine("*******************");
                Console.WriteLine("* SALARY EMPLOYEE *");
                Console.WriteLine("*******************");

                Console.WriteLine("Type your ID");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type your first name");
                string firstName = Console.ReadLine();

                Console.WriteLine("Type your last name");
                string lastName = Console.ReadLine();

                Console.WriteLine("Are you active?");
                bool isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter your salary:");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    Birthdate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    Hiringdate = new Date(2022, 3, 4),
                    IsActive = isActive,
                    Salary = salary,
                };

                //Console.WriteLine(salaryEmployee);
                Console.WriteLine("");

                Console.WriteLine("******************************");
                Console.WriteLine("* BASE & COMMISSION EMPLOYEE *");
                Console.WriteLine("******************************");

                Console.WriteLine("Type your ID");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type your first name");
                firstName = Console.ReadLine();

                Console.WriteLine("Type your last name");
                lastName = Console.ReadLine();

                Console.WriteLine("Are you active?");
                isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter your commission percentage:");
                commissionPercentage = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter your sales:");
                sales = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter your salary base:");
                decimal salaryBase = Convert.ToDecimal(Console.ReadLine());

                Employee baseComissionEmployee = new BaseCommissionEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 3, 4),
                    IsActive = isActive,
                    CommissionPercentage = commissionPercentage,
                    Sales = sales,
                    Base = salaryBase
                };
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
