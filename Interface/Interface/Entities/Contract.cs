using System;
using System.Collections.Generic;
using System.Text;
using Interface.Services;

namespace Interface.Entities
{
    class Contract
    {
        public int Number { get; private set; }
        public DateTime Data { get; private set; }
        public double TotalAmount { get; private set; }
        public int Months { get; private set; }

        public Contract(int number, DateTime data, double totalAmount, int months)
        {
            Number = number;
            Data = data;
            TotalAmount = totalAmount;
            Months = months;
        }
    }
}
