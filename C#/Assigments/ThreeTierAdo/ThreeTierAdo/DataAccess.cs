using System;
using System.Data.SqlClient;
using System.Configuration;
namespace ThreeTierAdo
{
    class DataAccess
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConfig"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        /// <summary>
        /// Return true if login is successful.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            using (conn)
            {
                conn.Open();
                cmd.CommandText = "select UserName, Password from LoginData";
                cmd.Connection = conn;

                using (cmd)
                {
                    try
                    {
                        SqlDataReader readerObj = cmd.ExecuteReader();
                        while (readerObj.Read())
                        {
                            if (username == readerObj.GetString(0) && password == readerObj.GetString(1))
                            {
                                return true;
                            }
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                return false;
            }
        }
        /// <summary>
        /// Returns true if user is registered successfully else returns false.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Register(string username, string password)
        {
            using (conn)
            {
                conn.ConnectionString = "Data Source=192.168.169.40;Initial Catalog=LoginDetails;Persist Security Info=True;User ID=sa;Password=Dbase!2";
                conn.Open();
                cmd.CommandText = "insert into LoginData Values('" + username + "','" + password + "');";
                cmd.Connection = conn;

                using (cmd)
                {
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
        /// Returns the forgotten password.
        /// </summary>
        /// <param name="username"></param>
        /// <returns>password</returns>
        public string ForgotPassword(string username)
        {
            using (conn)
            {
                conn.ConnectionString = "Data Source=192.168.169.40;Initial Catalog=LoginDetails;Persist Security Info=True;User ID=sa;Password=Dbase!2";
                conn.Open();
                cmd.CommandText = "select Password from LoginData where UserName ='" + username + "';";
                cmd.Connection = conn;

                  using (cmd)
                  {
                      string passwd = (string)cmd.ExecuteScalar();
                      return passwd;
                  }
                                        
            }                
        }
    }
}
