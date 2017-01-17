using System.Collections.Generic;

namespace DAL
{
    /// <summary>
    /// Class containing operations on DB.
    /// </summary>
    class DataAccess : IDatabase
    {
      static Dictionary<string, string> list;
        static DataAccess()
        {
            list = new Dictionary<string, string>();
        }
        /// <summary>
        /// Adds the UserName and Password.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public void StoreCredentials(string userName, string password)
        {
            list.Add(userName, password);            
        }

        /// <summary>
        /// Returns the Password for the UserName.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public  string GetPassword(string userName)
        {
            if (IsExistingUser(userName))
                return list[userName];
            return "Incorrect UserName";
        }
        /// <summary>
        /// Checks for the user if exists.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public  bool IsExistingUser(string userName)
        {
            return list.ContainsKey(userName);
        }
        /// <summary>
        /// Updates the password.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public bool UpdatePassword(string userName, string password)
        {
            list[userName] = password;
            return true;
        }    
    }
}
