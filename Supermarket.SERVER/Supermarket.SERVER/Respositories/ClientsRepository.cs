using Supermarket.SERVER.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Supermarket.SERVER.Respositories
{
    public static class ClientsRepository
    {
        static SqlConnection sqlConnection = new SqlConnection(Direc.SqlConnection);
        public static List<Client> GetAllClients()
        {
            string query = "SELECT * FROM [dbo].[Clients] ";
            return sqlConnection.Query<Client>(query).ToList(); //retornamos la lista de clientes
        }
        public static bool InsertClient(Client newClient)
        {
            string query = string.Format("INSERT INTO [dbo].[Clients] VALUES ('{0}','{1}','{2}','{3}','{4}') ",
                newClient.Ruc, newClient.Name, newClient.Gmail, newClient.PhoneNumber, newClient.Age);
            //creamos la consulta para introducir el nuevo cliente
            int result = sqlConnection.Execute(query);
            if (result > 0) return true ;
            else            return false;
        }
        public static bool DeleteClient(int id)
        {
            string query = string.Format("DELETE FROM [dbo].[Clients] WHERE Id = {0} ", id);
            sqlConnection.Execute(query); //ejecutamos el comando para elimnar un cleinte
            return true;
        }

        public static bool UpdateClient(Client client)
        {
            using (var db = new Supermarket_DbContext())
            {
                db.Clients.Update(client);
                db.SaveChanges();
                return true;
            }
        }
    }
}
