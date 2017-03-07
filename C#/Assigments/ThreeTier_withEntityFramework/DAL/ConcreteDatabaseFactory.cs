namespace DAL
{
    ///<summary>
    /// Concrete Factory to Return Object of Data Access.
    /// </summary>
    public class ConcreteDatabaseFactory : IDataFactory
    {
        public  IDatabase GetDataBase()
        {
            return new DataAccess();
        }
    }
}
