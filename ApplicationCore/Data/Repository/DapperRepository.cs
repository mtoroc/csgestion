using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ApplicationCore.Data.Repository
{
    public class DapperRepository<T>
    {

        private static string connectionString = "Server=192.168.30.129;Port=3306;UID=root;PWD=Condominium.2020*;Database=condominium_db";

        internal static T GetSingle(string sql)
        {
            try
            {

                using (IDbConnection connection = new MySqlConnection(connectionString))
                {
                    //connection.Open();

                    return connection.QueryFirstOrDefault<T>(sql);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal static List<T> GetList(string sql)
        {
            try
            {

                using (IDbConnection connection = new MySqlConnection(connectionString))
                {
                    //connection.Open();

                    return connection.Query<T>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal static int AddEntity(string sql)
        {
            try
            {

                using (IDbConnection connection = new MySqlConnection(connectionString))
                {
                    var id = connection.QueryFirstOrDefault<int>(sql);

                    return id;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal static int UpdateEntity(string sql)
        {
            try
            {

                using (IDbConnection connection = new MySqlConnection(connectionString))
                {
                    var exe = connection.Execute(sql);

                    return exe;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
