using Supermarket.SERVER.Data;
using Supermarket.SERVER.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Supermarket.SERVER.Respositories
{
    public class OrdersRepository
    {
        static SqlConnection sqlConnection = new SqlConnection(Direc.SqlConnection); //creamos la coneixon a la base de datos
        private const string sucess = "Peticion realizada con Exito!";
        public static Response<Order> GetAllOrders()
        {
            var response = new Response<Order>();
            string query = "SELECT * FROM [dbo].[Orders] "; //seleccionar pedidos
            try
            {
                response.Content = sqlConnection.Query<Order>(query).ToList(); //obtenemos la lista de pedidos
                response.Sucess = true; response.Message = sucess;
            }
            catch (Exception ex) //si ocurre un excepcion
            {
                response.Sucess = false; response.Message = ex.Message;
            }
            return response;

        }
        public static Response<Order> GetOrdersByClient(int? idClient )
        {
            var response = new Response<Order>();
            string query = string.Format("SELECT * FROM [dbo].[Orders] WHERE ClientId = {0}  ",idClient); //seleccionar pedidos
            try
            {
                response.Content = sqlConnection.Query<Order>(query).ToList(); //obtenemos la lista de pedidos del cleinte especifico
                response.Sucess = true; response.Message = sucess;
            }
            catch (Exception ex) //si ocurre un excepcion
            {
                response.Sucess = false; response.Message = ex.Message;
            }
            return response;
        }


        public static Response<Order> InsertOrder(Order newOrder)
        {
            var response = new Response<Order>();

            string query = "INSERT INTO [dbo].[Orders] VALUES(@ClientId,@DateMade,@Total,@PaymentMethod ) ";            
            try
            {
                sqlConnection.Execute(query,newOrder); //ejecutamos nuestro query para introdicr el nuevo pedido                  
                response.Sucess = true; response.Message = sucess;
            }
            catch(Exception ex)
            {
                response.Sucess = false; response.Message = ex.Message;
            }
            return response;
        }

        public static Response<Order> UpdateOrder(Order order) //actualizar un pedido
        {
            var response = new Response<Order>();
            try
            {
                using(Supermarket_DbContext db = new Supermarket_DbContext() )
                {
                    db.Orders.Update(order); db.SaveChanges();  //actualizamos la orden y guardamos cambios
                    response.Sucess = true; response.Message = sucess;
                }
            }
            catch(Exception ex)
            {
                response.Sucess = false; response.Message = ex.Message;
            }
            return response;
        }
            
        public static Response<Order> DeleteOrder(int idOrder)
        {
            var response = new Response<Order>();

            string query = string.Format("DELETE FROM [dbo].[Orders] WHERE '{0}' ", idOrder);
            //query para eliminar una order
            try
            {
                sqlConnection.Execute(query);                   //ejecutamos nuestro query
                response.Sucess = true; response.Message = sucess;
            }
            catch (Exception ex)
            {
                response.Sucess = false; response.Message = ex.Message;
            }
            return response;
        }
            
        
    } 
}
