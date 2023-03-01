using MyFirstCodeOOP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public abstract class Employee : IPay
    {
        #region propierties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date Birthdate { get; set; }
        public Date Hiringdate { get; set; }
        public bool IsActive { get; set; }
        #endregion
        #region Methods
        public abstract decimal GetValueToPay();
        public override string ToString()
        {
            return $"---EMPLOYEE---\n\t" +
                $" ID: {Id} \n\t " +
                $"First Name: {FirstName} \n\t" +
                $" Last Name: {LastName} \n\t" +
                $" Birth Date: {Birthdate} \n\t" +
                $" Hiring Date: {Hiringdate}\n\t" +
                $" Is Active?:{IsActive}";
        }

        #endregion
    }
}
