using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Xml;

namespace GenericTableOperations
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Table<T> where T : class, new()
    {
        /// <summary>
        /// Inserts a record.
        /// </summary>
        /// <param name="record"></param>
        public void Insert(T record)
        {
            PropertyInfo[] props = record.GetType().GetProperties();
            string cmdText = "insert into " + typeof(T).Name + " Values(";
            int i;
            for (i = 0; i < props.Length - 1; i++)
            {
                cmdText += "'" + props[i].GetValue(record) + "',";
            }
            cmdText += "'" + props[i].GetValue(record) + "')";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConfig"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        Console.WriteLine("Insert Success !!");
                    }
                    else
                    {
                        Console.WriteLine("Insert Failed !!");
                    }
                }
            }
        }
        /// <summary>
        /// Updates the record with respect to '0' index.
        /// </summary>
        /// <param name="recordObj"></param>
        /// <param name="columnName"></param>
        /// <param name="columnValue"></param>
        public void Update(T recordObj)
        {
            PropertyInfo[] props = recordObj.GetType().GetProperties();
            Console.WriteLine("Enter the column name, Value to update");
            string columnName = Console.ReadLine();
            string columnValue = Console.ReadLine();
            string cmdText = "update " + typeof(T).Name + " set " + columnName + " = '" + columnValue + "' where " + props[0].Name + " = " + props[0].GetValue(recordObj);
            
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConfig"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        Console.WriteLine("Update Success !!");
                    }
                    else
                    {
                        Console.WriteLine("Update Failed !!");
                    }
                }
            }
        }
        /// <summary>
        /// Gets the list of rows.
        /// </summary>
        /// <param name="record"></param>
        /// <returns> List </returns>
        public List<T> GetList(T recordObj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConfig"].ConnectionString))
            {
                List<T> listObj = new List<T>();
                using (SqlCommand cmd = new SqlCommand())
                {
                    string tableName = recordObj.GetType().Name;
                    cmd.CommandText = "Select * from " + tableName;
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter daObj = new SqlDataAdapter(cmd);
                    DataSet dsObj = new DataSet();
                    daObj.Fill(dsObj, tableName);
                    DataTable dtObj = dsObj.Tables[tableName];
                    foreach (DataRow row in dtObj.Rows)
                    {
                        T newObj = Map(row, dtObj);
                        listObj.Add(newObj);
                    }

                }
                return listObj;
            }
            
        }

        /// <summary>
        /// Create objects for each row of a table.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="dtObj"></param>
        /// <returns></returns>
        private T Map(DataRow rowObj, DataTable dtObj)
        {
            T destinationObj = new T();
            PropertyInfo[] props = destinationObj.GetType().GetProperties();
           
                foreach (PropertyInfo iterProp in props)
                {                 
                        iterProp.SetValue(destinationObj, rowObj.Field<object>(iterProp.Name));                    
                }

            return destinationObj;
        }
        /// <summary>
        /// Deletes the record based on first column.
        /// </summary>
        /// <param name="recordObj"></param>
        public void Delete(T recordObj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConfig"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    PropertyInfo[] props = recordObj.GetType().GetProperties();
                    Console.WriteLine("Enter the StudentID to delete");

                    cmd.CommandText = "delete from " + recordObj.GetType().Name + " where " + props[0].Name + " = " + Console.ReadLine();
                    cmd.Connection = conn;
                    conn.Open();

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("deleted row !");
                    }
                    else
                    {
                        Console.WriteLine("delete Unsuccessful");
                    }
                }
            }
        }
    }
}
