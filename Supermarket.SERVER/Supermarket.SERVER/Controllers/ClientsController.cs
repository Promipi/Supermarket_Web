using Microsoft.AspNetCore.Mvc;
using Supermarket.SERVER.Models;
using Supermarket.SERVER.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.SERVER.Controllers
{
    [ApiController]
    [Route("api/Clients")]
    public class ClientsController : Controller
    {
        [HttpGet]
        public IActionResult GetAllClients()
        {
            return Ok(ClientsRepository.GetAllClients()); //retornamos un 200 con la lista de clientes
        }

        [HttpPost("add")]
        public IActionResult InsertClient(Client newClient)
        {
            return Ok(ClientsRepository.InsertClient(newClient));
        }
        [HttpPut]
        public IActionResult UpdateClient(Client client) //para actualziar un ciente
        {
            return Ok(ClientsRepository.UpdateClient(client));
        }
        [HttpDelete]
        public IActionResult DeleteClient(int id)
        {
            return Ok(ClientsRepository.DeleteClient(id));  //para eliminar un cliente
        }
    }
}
