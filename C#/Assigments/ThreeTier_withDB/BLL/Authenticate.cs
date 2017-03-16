using DAL;
namespace BLL
{
    /// <summary>
    /// Authentication class which contains definitions of Login, Register and Forgot Password.
    /// </summary>
    class Authenticate : IAuthenticate
    {
        /// <summary>
        /// Instance access for database.
        /// </summary>
        static ConcreteDatabaseFactory databaseFactory = new ConcreteDatabaseFactory();
        IDatabase dbObj = databaseFactory.GetDataBase();

        /// <summary>
        /// Login Method which authenticates the user.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string userName, string password)
        {
            return dbObj.GetPassword(userName).Equals(password);       
        }
        /// <summary>
        /// Register's the Users in to the Database.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Register(string userName, string password)
        {
            if (dbObj.IsExistingUser(userName))
            {
                return false;
            }
            else
            {
                dbObj.StoreCredentials(userName, password);
                return true;
            }
        }
        /// <summary>
        /// ForgotPassword method lets you to change the password.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ForgotPassword(string userName, string password)
        {
           return dbObj.UpdatePassword(userName, password);
            
        }
    }
}
