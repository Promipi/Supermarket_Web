using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.SERVER.Models
{
    public class Order
    {/*Id int identity,
ClientId int,
DateMade datetime,
Total float,*/
        public int Id { get; set; }
        public int ClientId { get; set; }

        public DateTime? DateMade { get; set; }

        public float Total { get; set; }

        public Client ClientNavigation { get; set; }
        public List<Purchase> Purchases {get;set;} //e; conjunto de compras del pedido
    }
}
