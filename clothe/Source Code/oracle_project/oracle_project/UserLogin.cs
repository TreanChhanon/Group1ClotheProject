using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracle_project
{
    static class UserLogin //or public static class
    {
        //static data member or static fileds or attributee  

        private static string UserID;
        private static string UserName;
        private static string UserPassword;
        private static string UserType;

        //static method or static member method : create setter method
        public static void setUserID(string userId)
        {
            UserID = userId;
        }

        // create getter method
        public static string getUserID()
        {
            return UserID;
        }
        public static void setUsername(string username)
        {
            UserName = username;
        }
        public static string getUsername()
        {
            return UserName;
        }
        public static void setUserPassword(string userPassword)
        {
            UserPassword = userPassword;
        }
        public static string getUserPassword()
        {
            return UserPassword;
        }

        public static void setUserType(string userType)
        {
            UserType = userType;
        }
        public static string getuserType()
        {
            return UserType;
        }
        //clear user login info
        public static void ClearSessions()
        {
            UserID = string.Empty;
            UserName = string.Empty;
            UserPassword = string.Empty;
            UserType = string.Empty;
        }

    }
}
