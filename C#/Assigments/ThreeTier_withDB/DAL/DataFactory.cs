namespace DAL
{
    /// <summary>
    /// Factory which contains the method GetDatabase.
    /// </summary>
    public interface IDataFactory
    {
         IDatabase GetDataBase();
    }
    
}
