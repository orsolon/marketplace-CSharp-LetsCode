using System.Collections.Generic;

namespace Project2
{
    public class DataBase
    {
        public static List<User> Users {get; set;}
        static DataBase()
        {
            Users = new List<User>();
        }
    }
}