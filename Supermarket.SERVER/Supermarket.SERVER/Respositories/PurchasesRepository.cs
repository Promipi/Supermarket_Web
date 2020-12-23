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

    public static class PurchasesRepository
    {
        static SqlConnection sqlConnection = new SqlConnection(Direc.SqlConnection);
        private const string sucess = "Peticion realizada con Exito!";
        
        public static Response<Purchase> GetAllPurchases()
        {
            var response = new Response<Purchase>();
            string query = "SELECT * FROM [dbo].[Purchases] ";
            try
            {
                response.Content = sqlConnection.Query<Purchase>(query).ToList(); //obtenemos la lista de compras
                response.Sucess = true; response.Message = sucess;
            }
            catch (Exception ex) //si ocurre un excepcion
            {
                response.Sucess = false; response.Message = ex.Message;
            }
            return response;
        }
        public static Response<Purchase> GetPurchasesByOrder(int? idOrder) //para obtener la lista de compras de un pedido
        {
            var response = new Response<Purchase>();
            string query = string.Format("SELECT * FROM [dbo].[Purchases] WHERE OrderId = {0} ", idOrder);
            try
            {    
                response.Content = sqlConnection.Query<Purchase>(query).ToList() ; //obtengo la lista compras de un pedido
                foreach (var purchase in response.Content) //recorremos la compras
                {
                    //recoorremos cada comra y le estableces que articulo fue comprado
                    purchase.ArticleNavigation = ArticlesRepository.GetArticleById(purchase.ArticleId).Content.First();
                }
                response.Sucess = true; response.Message = sucess;
            }
            catch (Exception ex) //si ocurre un excepcion
            {
                response.Sucess = false; response.Message = ex.Message;
            }
            return response;
        }


        public static Response<Purchase> InsertPurchase(Purchase newPurchase)
        {
            var response = new Response<Purchase>();
            string query = string.Format("INSERT INTO [dbo].[Purchases] VALUES(@ArticleId,@OrderId,@Units,@SubTotal ) ");
            try
            {
                sqlConnection.Execute(query, newPurchase); //insertamos una nueva compra
                response.Sucess = true; response.Message = sucess;
            }
            catch (Exception ex) //si ocurre un excepcion
            {
                response.Sucess = false; response.Message = ex.Message;
            }
            return response;

        }
        public static Response<Purchase> UpdatePurchase(Purchase purchase)
        {
            var response = new Response<Purchase>();
            try
            {
                using (var db = new Supermarket_DbContext())
                {
                    db.Purchases.Update(purchase); //actualizamos la compra
                    db.SaveChanges();
                    response.Sucess = true; response.Message = sucess;
                }
            }
            catch(Exception ex) //si ocurre algun fallo retornamos el error
            {
                response.Sucess = false; response.Message = ex.Message;
            }
            return response;

           
        }
        public static Response<Purchase> DeletePurchase(int id)
        {
            var response = new Response<Purchase>();
            string query = string.Format("DELETE FROM [dbo].[Purchases] WHERE Id = {0} ", id); //query para eliminar una compra en especifico
            try
            {
                sqlConnection.Execute(query); //eliminamos la compra
                response.Sucess = true; response.Message = sucess;
            }
            catch(Exception ex)
            {
                response.Sucess = false; response.Message = ex.Message;
            }
            return response;
        }
    }
}
