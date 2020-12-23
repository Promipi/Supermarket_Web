using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.SERVER.Data
{
    public class Response<T> //clase para la respuesta de cada METODO HTTP
    {
        public bool Sucess { get; set; } //si tuvo exito 
        public string Message { get; set; }

        public List<T> Content { get; set; } = new List<T>(); //lo que tendra de contenido la respuesta que se pasara a JSON

       
    }
}
