using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Supermarket.SERVER.Data;
using Supermarket.SERVER.Models;

namespace Supermarket.SERVER.Respositories
{
    public static class ArticlesRepository
    {
        public static SqlConnection sqlConnection = new SqlConnection(Direc.SqlConnection);
        private const string sucess = "Peticion realizada con Exito!";

        public static Response<Article> InsertArticle(Article newArticle) //Para insertar un nuevo Articulo
        {
            var response = new Response<Article>();

            string query = "INSERT INTO [dbo].[Articles] VALUES (@Family,@Description,@Price)";
            try
            {
                var result = sqlConnection.Execute(query,
                new Article { Family = newArticle.Family, Description = newArticle.Description, Price = newArticle.Price });
                //Ejecutamos la consulta 

                response.Sucess = true; response.Message = sucess;
            }
            catch(Exception ex) //Si ocurre alguna excepcion
            {
                response.Sucess = false; response.Message = ex.Message; //guardamos el mensaje de la excepcion
                
            }
            return response;

        }

        public static Response<Article> GetAllArticles()
        {
            var response = new Response<Article>();
            string query = "SELECT * FROM [dbo].[Articles] ";
            try
            {
                response.Content = sqlConnection.Query<Article>(query).ToList(); //guardamos la lista de articulos
                response.Sucess = true; response.Message = sucess;
            }
            catch(Exception ex) //si ocurre un excepcion
            {
                response.Sucess = false; response.Message = ex.Message;  
            }
            return response;
        }

        public static Response<Article> UpdateArticle(Article article)
        {
            var response = new Response<Article>();
            try
            {
                using (var db = new Supermarket_DbContext())
                {
                    db.Articles.Update(article); //actualizamos los datos del articulo
                    db.SaveChanges();
                    response.Sucess = true; response.Message = sucess;
                }
            }
            catch(Exception ex)
            {
                response.Sucess = false;
                response.Message = ex.Message;
            }
            return response;

        }

        public static Response<Article> DeleteArticle(int id) //para eliminar un articulo mediante su id
        {
            var response = new Response<Article>();
            try
            {
                string query = string.Format("DELETE FROM [dbo].[Articles] where Id = {0} ", id);
                sqlConnection.Execute(query); //ejecutamos el comando para eliminar un articulo
                response.Sucess = true; response.Message = sucess;
            }
            catch(Exception ex)
            {
                response.Sucess = false;
                response.Message = ex.Message;
            }
            return response;
        }

        
    }
}
