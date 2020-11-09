using System;
using System.Collections.Generic;
using System.Text;

namespace TesteNava.Domain.Models
{
    public class Seller : Entity
    {       
        public string Cpf { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Sale> Sales { get; set; }

        public Seller(){}
        public Seller(string cpf, string name, string email, string phone)
        {
            Cpf = cpf;
            Name = name;
            Email = email;
            PhoneNumber = phone;
            Sales = new List<Sale>();
        }
        public void AddSale(Sale sale)
        {
            Sales.Add(sale);
        }
    }
}
