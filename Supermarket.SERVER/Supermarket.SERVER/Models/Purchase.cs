using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.SERVER.Models
{
    public class Purchase
    {
       /* Id int identity,
ArticleId int, --que articulo fue comprado
OrderId int, --a que pedido pertence
Units int,	  --unidades que se llevan
SubTotal float,	--el subtotal de cada compra*/

        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int OrderId { get; set; }

        public int Units { get; set; }
        
        public float SubTotal { get; set; }

        public Article ArticleNavigation { get; set; }

        public Order OrderNavigation { get; set; } //a que pedido pertence
    }
}
