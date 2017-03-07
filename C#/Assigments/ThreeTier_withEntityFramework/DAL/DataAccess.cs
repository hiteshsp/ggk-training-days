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
            using (AuthenticationEntities authEntity = new AuthenticationEntities())
            {
                try
                {
                    
                    AuthDetail table = new AuthDetail();
                    table.username = username;
                    table.password = password;
                    authEntity.AuthDetails.Add(table);
                    authEntity.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
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
            using (AuthenticationEntities authEntity = new AuthenticationEntities())
            {
                AuthDetail table = authEntity.AuthDetails.Find(username);

                if (table == null)
                {
                    return false;

                }
                else
                {
                    if (username == table.username)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Not Required.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public string GetPassword(string userName)
        {
            using (AuthenticationEntities authEntity = new AuthenticationEntities())
            {

                AuthDetail table = authEntity.AuthDetails.Find(userName);
                if (table == null)
                {
                    return "Not Found";
                }
                else
                {
                    return table.password;
                }

            }
        }
        /// <summary>
        /// Updates the password.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>

        public bool UpdatePassword(string userName, string password)
        {
            using (AuthenticationEntities authEntity = new AuthenticationEntities())
            {
               
               AuthDetail table = authEntity.AuthDetails.Find(userName);

                if (table == null)
                {
                    return false;
                }
                else
                {
                    table.password = password;
                    authEntity.SaveChanges();
                    return true;
                }

           }
               
        }
    }
}
    
  
