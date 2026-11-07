using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.IO;

namespace IS_SII_ACT3_BALANA
{
    public class Connection
    {
        public static OleDbConnection GetConnection()
        {
            string databasePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Database",
                "IMSdb.accdb"
                );

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                                        + databasePath + "; Persist Security Info=False;";

            return new OleDbConnection( connectionString );
        }
    }
}
