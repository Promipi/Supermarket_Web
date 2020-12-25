using Supermarket.SERVER.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Supermarket.SERVER.Data;

namespace Supermarket.SERVER.Respositories
{
    public static class ClientsRepository
    {
        static SqlConnection sqlConnection = new SqlConnection(Direc.SqlConnection);
        private const string sucess = "Peticion realizada con Exito!";

        public static Response<Client> GetAllClients()
        {
            var response = new Response<Client>();
            string query = "SELECT * FROM [dbo].[Clients] ";
            try
            {
                response.Content = sqlConnection.Query<Client>(query).ToList(); //retornamos la lista de clientes
                response.Sucess = true; response.Message = sucess;
            }
            catch(Exception ex)
            {
                response.Sucess = false; response.Message = ex.Message;
            }
            return response;
            
        }
        public static Response<Client> GetClientById(int? id)
        {
            var response = new Response<Client>();
            string query = $"SELECT * FROM [dbo].[Clients] WHERE Id = {id} ";
            try
            {
                response.Content = sqlConnection.Query<Client>(query).ToList(); //retornamos la lista de clientes
                response.Sucess = true; response.Message = sucess;
            }
            catch (Exception ex)
            {
                response.Sucess = false; response.Message = ex.Message;
            }
            return response;
        }
        public static Response<Client> InsertClient(Client newClient)
        {
            var response = new Response<Client>();
            string query = "INSERT INTO [dbo].[Clients] VALUES (@Ruc,@Name,@Gmail,@PhoneNumber,@Age) ";
            //creamos la query para introducir un nuevo cliente a la base de datos
            try
            {
                sqlConnection.ExecuteAsync(query,newClient); //inseramos el nuevo cliente 
                response.Sucess = true; response.Message = sucess;
            }   
            catch(Exception ex)
            {
                response.Sucess = false; response.Message = ex.Message;
            }
            return response;
        }

        public static Response<Client> DeleteClient(int id)
        {
            sqlConnection.Open();
            var response = new Response<Client>();
            string updateOrder = $"UPDATE Orders SET ClientId = 2 Where ClientId = {id}";
            string query = $"delete from Clients where Id = {id} "; //query para eliminar un cliente
            try
            {
                var a = sqlConnection.ExecuteAsync(updateOrder); //las ordenes que contenian a ese cleinte las actualizamos a cleinte anonimo
                a = sqlConnection.ExecuteAsync(query);
                response.Sucess = true; response.Message = sucess;
            }
            catch (Exception ex)
            {
                response.Sucess = false; response.Message = ex.Message;
            }
            return response;
        }

        public static Response<Client> UpdateClient(Client client)
        {
            var response = new Response<Client>();
            try
            {
                using (var db = new Supermarket_DbContext())
                {
                    db.Clients.Update(client);
                    db.SaveChanges();
                    response.Sucess = true; response.Message = sucess;
                }
            }
            catch(Exception ex)
            {
                response.Sucess = false; response.Message = ex.Message;
            }
            return response;
        }

    }
    
}
