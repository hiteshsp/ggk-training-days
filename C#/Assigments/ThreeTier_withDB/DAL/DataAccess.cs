using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// Class containing operations on DB.
    /// </summary>
    class DataAccess : IDatabase
    {
        /// <summary>
        /// Adds the UserName and Password.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public bool StoreCredentials(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=192.168.169.40;Initial Catalog=LoginDetails;Persist Security Info=True;User ID=sa;Password=Dbase!2";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "insert into LoginData Values('" + username + "','" + password + "');";
                    cmd.Connection = conn;


                    try
                    {
                        int rowsInserted = cmd.ExecuteNonQuery();
                        if (rowsInserted == 1)
                        {
                            return true;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                    }

                }
                return false;
            }
        }

        /// <summary>
        /// Returns the Password for the UserName.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetPassword(string username)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=192.168.169.40;Initial Catalog=LoginDetails;Persist Security Info=True;User ID=sa;Password=Dbase!2";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select Password from LoginData where UserName ='" + username + "';";
                    cmd.Connection = conn;


                    string passwd = (string)cmd.ExecuteScalar();
                    return passwd;
                }

            }
        }
        /// <summary>
        /// Checks for the user if exists.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool IsExistingUser(string username)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=192.168.169.40;Initial Catalog=LoginDetails;Persist Security Info=True;User ID=sa;Password=Dbase!2";
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select UserName from LoginData where UserName ='" + username + "';";
                    cmd.Connection = conn;

                    string userID = (string)cmd.ExecuteScalar();
                    if (username == userID)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        /// <summary>
        /// Updates the password.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public bool UpdatePassword(string username, string newPassword)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=192.168.169.40;Initial Catalog=LoginDetails;Persist Security Info=True;User ID=sa;Password=Dbase!2";
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "update LoginData  set Password ='" + newPassword + "' where UserName = '" + username + "'";
                    cmd.Connection = conn;
                    int passwdUpdated = cmd.ExecuteNonQuery();
                    if (passwdUpdated == 1)
                    {
                        return true;
                    }

                }
                return false;

            }
        }


    }
}
