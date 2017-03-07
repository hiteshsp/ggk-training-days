namespace BLL
{
    /// <summary>
    /// Contains signature for Authentication.
    /// </summary>
    public interface IAuthenticate
    {
        bool Login(string userName, string password);
        bool Register(string userName, string password);
        bool ForgotPassword(string userName, string password);

    }
}
