using MyFirstCodeOOP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    internal class Invoice : IPay
    {
        #region properties
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Quantity { get; set; }

        #endregion

        #region Methods
        public decimal GetValueToPay()
        {
            return Price * (decimal)Quantity;
        }
        public override string ToString()
        {
            return $"ID: {Id} - Description: {Description}\n\t" +
                $"Quantity..........{Quantity}\n\t" +
                $"Price.............{Price:C2}\n\t" +
                $"Invoice Values....{GetValueToPay():C2}";
        }
        #endregion
    }
}
