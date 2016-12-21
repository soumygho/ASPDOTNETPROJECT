using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

/// <summary>
/// Summary description for DbConnection
/// </summary>
/// 
namespace offsetLibrary
{
    public class DbConnection
    {
        public DbConnection()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\offsetdb.mdb");
        public OleDbCommand cmd = new OleDbCommand();
        public OleDbDataReader dr = null;
        public OleDbDataAdapter da = new OleDbDataAdapter();

    }
}
