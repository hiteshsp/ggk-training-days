namespace DAL
{
    ///<summary>
    /// Concrete Factory to Return Object of Data Access.
    /// </summary>
    public class ConcreteDatabaseFactory : IDataFactory
    {
        /// <summary>
        /// Gets instance for a DataAccess class.
        /// </summary>
        /// <returns></returns>
        public  IDatabase GetDataBase()
        {
            return new DataAccess();
        }
    }
}
