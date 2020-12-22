using Microsoft.AspNetCore.Mvc;
using Supermarket.SERVER.Data;
using Supermarket.SERVER.Models;
using Supermarket.SERVER.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.SERVER.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PurchasesController : Controller
    {
        [HttpGet]
        public IActionResult GetAllPurchases(int? idOrder) //obtener una lista de compras
        {
            var response = new Response<Purchase>();

            if(idOrder == null) //si no se le pasa el id del pedido retornamos todas las compras
            {
                response = PurchasesRepository.GetAllPurchases();
            }
            if (idOrder != null)
            {
                response = PurchasesRepository.GetPurchasesByOrder(idOrder); //obtenemos la lista de compras de un pedido
            }
            if (response.Sucess) return Ok(response);
            else                 return Problem(response.Message);


        }
        [HttpPost]
        public IActionResult InsertPurchase(Purchase newPurchase)
        {
            var response = PurchasesRepository.InsertPurchase(newPurchase); //introducimos la nueva compra
            if (response.Sucess) return Ok(response);
            else                 return Problem(response.Message);
        }

        [HttpPut]
        public IActionResult UpdatePurchase(Purchase purchase)
        {
            var response = PurchasesRepository.UpdatePurchase(purchase); //actualizamos la compra especifica
            if (response.Sucess) return Ok(response);
            else                 return Problem(response.Message);
        }

        [HttpDelete]
        public IActionResult DeletePurchase(int id) 
        {
            var response = PurchasesRepository.DeletePurchase(id); //eliminamos una compra mediante su id
            if (response.Sucess) return Ok(response);
            else                 return Problem(response.Message);
        }
    }
}
