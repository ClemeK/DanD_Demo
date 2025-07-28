using DanD_Demo.Models;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace DanD_Demo
{
    internal class SQLiteDataAccess
    {
        /// <summary>
        /// Retrieves the connection string from the Configure Manager
        /// </summary>
        /// <param name="id"></param>
        /// <returns>string = connection name</returns>
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        // ************************************************
        //                  C E L L S
        // ************************************************
        // ************************************************
        // ************************************************
        public static List<Citadel> LoadCell(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string getText = "select * from Game where Cell = " + id.ToString();

                var output = cnn.Query<Citadel>(getText, new DynamicParameters());

                return output.ToList();
            }
        }
    }
}