using System;

namespace MyFirstCodeOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                var dateObject = new Date(1, 2, 3);
                Console.WriteLine(dateObject);

                Console.WriteLine("********Testing lastest implementation********");
                //employe madre
                //salaryEmployee hija
                Employee salaryEmployee = new SalaryEmployee() 
                {
                    Id = 1000,
                    LastName = "Posada",
                    FirstName = "Maria", 
                    Birthdate = new Date(1950, 2, 5),
                    Hiringdate = new Date(2022, 12, 31),
                    IsActive = true,
                    Salary = 2000000.34m
                };
                Console.WriteLine(salaryEmployee);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
