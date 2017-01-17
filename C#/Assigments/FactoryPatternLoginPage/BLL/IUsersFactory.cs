namespace BLL
{
    /// <summary>
    /// Contains GetInstance method signature.
    /// </summary>
    public interface IUsersFactory
    {
         IAuthenticate GetAuthenticateInstance();
    }
  }
