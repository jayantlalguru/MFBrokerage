using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace MFBrokerage.Persistence
{
    public static class DapperConfig
    {
        public static IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ToString());
            }
        }
    }
}