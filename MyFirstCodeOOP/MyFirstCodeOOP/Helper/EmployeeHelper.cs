using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP.Helper
{
    public class EmployeeHelper
    {
        #region fields
        private Employee _salaryEmployee;
        private Employee _commissionEmployee;
        private Employee _contractorEmployee;
        private Employee _basecommissionEmploye;
        #endregion

        #region methods
        public EmployeeHelper(Employee salaryEmployee, Employee commissionEmployee, Employee contractorEmployee, Employee basecommissionEmploye)
        {
            _salaryEmployee = salaryEmployee;
            _commissionEmployee = commissionEmployee;
            _contractorEmployee = contractorEmployee;
            _basecommissionEmploye = basecommissionEmploye;
        }

        public decimal GetPayRollFromActiveEmployee() 
        {
            ICollection<Employee> employees = new List<Employee>()
                {
                    _salaryEmployee,
                    _commissionEmployee,
                    _contractorEmployee,
                    _basecommissionEmploye
                };
            decimal payroll = 0;
            foreach (Employee employee in employees)
            {
                if (employee.IsActive == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine(employee);
                    Console.WriteLine("");
                    payroll += employee.GetValueToPay();
                }

            }
            return payroll;
        }
        #endregion
    }
}
