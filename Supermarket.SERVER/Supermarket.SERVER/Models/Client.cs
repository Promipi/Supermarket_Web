using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.SERVER.Models
{
    public class Client
    {
        public int Id { get; set; }

        public int Ruc { get; set; }
        public string Name { get; set; }

        public string Gmail { get; set; }
        public int PhoneNumber { get; set; }

        public int Age { get; set; }

        public List<Order> Orders { get; set; } //la lsita de pedidos que realizo el cliente
    }
}
