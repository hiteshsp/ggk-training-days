using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace ThreeTierAdo
{
    /// <summary>
    /// Class which establishes the connection. 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Driver Class.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConfig"].ConnectionString;
            new DataAccess().Register("hitesh", "sp");
            using (SqlConnection conn = new SqlConnection(cs))
            {
                //SqlDataAdapter da = new SqlDataAdapter("sp_GetData", conn);
                //da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //SqlParameter param = new SqlParameter("UserName", "Ananth");
                //da.SelectCommand.Parameters.Add(param);
                //DataSet ds = new DataSet();
                //da.Fill(ds);
                //Console.WriteLine(  ds.GetXml());
            }
        }
    }
}

;