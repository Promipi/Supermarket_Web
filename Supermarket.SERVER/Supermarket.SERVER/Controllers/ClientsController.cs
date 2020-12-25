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
    [Route("api/Clients")]
    public class ClientsController : Controller
    {
        [HttpGet]
        public IActionResult GetAllClients(int? id)            //obtener todos los clientes
        {
            Response<Client> response = new Response<Client>();
            if (id != null) response = ClientsRepository.GetClientById(id);
            else            response = ClientsRepository.GetAllClients(); //obtenems la respuesta de nuestra consulta

            if (response.Sucess) return Ok(response);          //si no hubo errores
            else                return Problem(response.Message); 
        }

        [HttpPost("add")]
        public IActionResult InsertClient(Client newClient) //insertar un cliente
        {
            var response = ClientsRepository.InsertClient(newClient); //obtenems la respuesta de nuestra consulta 
            if (response.Sucess) return Ok(response);                 //si no hubo errores
            else                return Problem(response.Message);
        }
        [HttpPut]
        public IActionResult UpdateClient(Client client) //para actualizar un cliente
        {
            var response = ClientsRepository.UpdateClient(client); //obtenems la respuesta de nuestra consulta 
            if (response.Sucess) return Ok(response);              //si no hubo errores
            else                 return Problem(response.Message);
        }
        [HttpDelete]
        public IActionResult DeleteClient(int id)
        {
            var response = ClientsRepository.DeleteClient(id); //obtenems la respuesta de nuestra consulta 
            if (response.Sucess) return Ok(response);              //si no hubo errores
            else return Problem(response.Message);
        }
    }
}
