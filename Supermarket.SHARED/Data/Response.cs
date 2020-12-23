using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.SHARED.Data
{
    public class Response<T> //clase para la respuesta de cada METODO HTTP
    {
        public bool Sucess { get; set; } //si tuvo exito 
        public string Message { get; set; }
        
        public List<T> Content { get; set; } //lo que tendra de contenido la respuesta que se pasara a JSON

       
    }
}
