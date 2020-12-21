using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.SERVER.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Family { get; set; } //a que tipo de comida pertence
        public string Description { get; set; }
        public float Price { get; set; }//precio de cada articulo   
    }
}
