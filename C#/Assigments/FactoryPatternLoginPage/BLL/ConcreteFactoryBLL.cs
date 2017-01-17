namespace BLL
{
    /// <summary>
    /// Concrete Factory For BLL.
    /// </summary>
    public class ConcreteFactoryBLL : IUsersFactory
    {
        /// <summary>
        /// Gets an instance of Authenticate Class.
        /// </summary>
        /// <returns></returns>
        public IAuthenticate GetAuthenticateInstance()
        {
            return new Authenticate();
        }
   
    }
}
