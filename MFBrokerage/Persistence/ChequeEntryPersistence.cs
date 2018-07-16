using Dapper;
using MFBrokerage.BusinessModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MFBrokerage.Persistence
{
    public class ChequeEntryPersistence
    {
        public void CreateCheque(ChequeEntry chequeEntry)
        {   
            using (var dbConnection = DapperConfig.Connection)
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@chequeDate", chequeEntry.ChequeDate);
                dynamicParameters.Add("@chequeReceivedDate", chequeEntry.ChequeReceivedDate);
                dynamicParameters.Add("@chequeNumber", chequeEntry.ChequeNumber);
                dynamicParameters.Add("@chequeAmount", chequeEntry.ChequeAmount);
                dynamicParameters.Add("@tax", chequeEntry.Tax);
                dynamicParameters.Add("@brokeragePeriodFrom", chequeEntry.BrokeragePeriodFrom);
                dynamicParameters.Add("@brokeragePeriodTo", chequeEntry.BrokeragePeriodTo);
                dynamicParameters.Add("@bank", chequeEntry.Bank);
                dynamicParameters.Add("@branch", chequeEntry.Branch);
                dynamicParameters.Add("@referenceTag", chequeEntry.ReferenceTag);
                dynamicParameters.Add("@trail", chequeEntry.Trail);
                dynamicParameters.Add("@upfront", chequeEntry.Upfront);
                dynamicParameters.Add("@clawback", chequeEntry.Clawback);
                dynamicParameters.Add("@remarks", chequeEntry.Remarks);
                dbConnection.Execute("sp_name", dynamicParameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}