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
    [Route("[controller]")]
    public class OrdersController : Controller
    {
        [HttpGet]
        public IActionResult GetAllOrders(int? idClient)
        {
            var response = new Response<Order>();
            if(idClient == null) //si no pone para filtrar por cliente
            {
                response = OrdersRepository.GetAllOrders();
            }
            else
            {
                response = OrdersRepository.GetOrdersByClient(idClient);
            }
            if (response.Sucess) return Ok(response);
            else return Problem(response.Message);
        }
        [HttpPost("add")]
        public IActionResult InsertOrder(Order newOrder) //insertar un pedido
        {
            var response = OrdersRepository.InsertOrder(newOrder); 

            if (response.Sucess) return Ok(response);
            else return Problem(response.Message);

        }
        [HttpPut]
        public IActionResult UpdateOrder(Order order) //actualizar un pedido
        {
            var response = OrdersRepository.UpdateOrder(order);

            if (response.Sucess) return Ok(response);
            else return Problem(response.Message);
        }
        [HttpDelete]
        public IActionResult DeleteOrder(int idOrder) //eliminar un pedido
        {
            var response = OrdersRepository.DeleteOrder(idOrder);

            if (response.Sucess) return Ok(response);
            else return Problem(response.Message);
        }

    }
}
