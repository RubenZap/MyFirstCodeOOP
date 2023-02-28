using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public class CommissionEmployee : Employee
    {
        #region Properties
        public float CommissionPercentage { get; set; }
        public decimal Sales { get; set; }

        #endregion
        #region Methods
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)convertpercentage(CommissionPercentage) + Sales;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $" Commission percentage.........{convertpercentage(CommissionPercentage):P2}\n\t" +
                $"Sales.........{Sales:C2}\n\t" +
                $"Values to pay ............{GetValueToPay():C2}";
        }
        public float convertpercentage(float commissionPercentage)
        {
            return CommissionPercentage/100;
        }
        #endregion
    }
}
