using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LSS
{
    public class connection
    {
        public SqlConnection sqlcon = new SqlConnection();


        public connection()
        {
            sqlcon = new SqlConnection(ConfigurationManager.AppSettings["con1"].ToString());
            sqlcon.Open();
        }
    }
}