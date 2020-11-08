using System;
using System.Collections.Generic;
using System.Text;

namespace TesteNava.Domain.Models
{
    public class Seller : Entity
    {       
        public int Cpf { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public IEnumerable<Sale> Sales { get; set; }
    }
}
