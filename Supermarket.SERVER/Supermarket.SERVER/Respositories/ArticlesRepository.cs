using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Supermarket.SERVER.Models;

namespace Supermarket.SERVER.Respositories
{
    public static class ArticlesRepository
    {
        public static SqlConnection sqlConnection = new SqlConnection(Direc.SqlConnection);

        public static bool InsertArticle(Article newArticle)
        {
            string query = "INSERT INTO [dbo].[Articles] VALUES (@Family,@Description,@Price)";
            var result = sqlConnection.Execute(query,
            new Article { Family = newArticle.Family, Description = newArticle.Description, Price = newArticle.Price }); 

            //ejecutamos el comando para introducir un nuevo articulo a la base de datos
            
            if (result > 0) return true ; //si tuvo exito retornamos TRUE
            else            return false;
        }

        public static List<Article> GetAllArticles()
        {
            string query = "SELECT * FROM [dbo].[Articles] ";
            return sqlConnection.Query<Article>(query).ToList(); //retornamos la lista de articulos en la bae de datos
        }

        public static bool UpdateArticle(Article article)
        {
            using (var db = new Supermarket_DbContext())
            {
                db.Articles.Update(article); //actualizamos los datos del articulo
                db.SaveChanges();
                return true;
            }
        }

        public static bool DeleteArticle(int id) //para eliminar un articulo mediante su id
        {
            string query = string.Format("DELETE FROM [dbo].[Articles] where Id = {0} ", id);
            sqlConnection.Execute(query); //ejecutamos el comando para eliminar 
            return true;
        }

        
    }
}
