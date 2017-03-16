namespace DAL
{
    /// <summary>
    /// Interface IDatabase which contains the methods Add, Get and IsExistingUser.
    /// </summary>
  public interface IDatabase
    {
        bool StoreCredentials(string userName, string password);
        string GetPassword(string userName);
        bool IsExistingUser(string userName);
        bool UpdatePassword(string userName, string password);
    }
}
