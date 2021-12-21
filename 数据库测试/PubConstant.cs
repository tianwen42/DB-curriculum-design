using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataBase_Project
{
    /// <summary>
    /// 公共常量
    /// </summary>
    public class PubConstant
    {
        public static string currentAccount = "";
        public static string currentPasswd = "";
        //连接对象
        public static SqlConnection currentConnection = new SqlConnection();
    }
}
