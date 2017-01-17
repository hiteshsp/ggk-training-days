namespace BLL
{
    /// <summary>
    /// Concrete Factory For BLL.
    /// </summary>
    public class ConcreteFactoryBLL : IUsersFactory
    {
        public IAuthenticate GetAuthenticateInstance()
        {
            return new Authenticate();
        }
   
    }
}
