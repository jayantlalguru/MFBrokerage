using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFBrokerage.Persistence
{
    public class ChequeEntryPersistence
    {
        public void CreateCheque()
        {
            using (var dbConnection = DapperConfig.Connection)
            {
                dbConnection.Execute();
            }
        }
    }
}