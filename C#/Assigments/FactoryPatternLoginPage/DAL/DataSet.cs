using System;
using System.Collections.Generic;

namespace DAL
{
    public interface DataBase
    {
        void Validate(string name, string passwd);
    }
    public class DataStore : DataBase
    {
        public static Dictionary<string, string> users = new Dictionary<string, string>();
        public void Validate(string name, string passwd)
        {

        }
    }
    public class DataValidate : DataBase
    {
        public void Validate(string name, string passwd)
        {

        }
    }

}
