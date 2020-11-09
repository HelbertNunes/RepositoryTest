using System;
using System.Collections.Generic;
using System.Text;

namespace TesteNava.Domain.Models
{
    public class SaleItem : Entity
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public Guid SaleId { get; set; }
        public Sale Sale { get; set; }

        public SaleItem(){}
        public SaleItem(string name, double value, Sale sale)
        {
            Name = name;
            Value = value;
            Sale = sale;
        }
    }
}
