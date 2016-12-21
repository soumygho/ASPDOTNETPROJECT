using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DatabaseOperation
/// </summary>
/// 
namespace offsetLibrary
{
    public class DatabaseOperation
    {
        public DbConnection dbcon = null;
        public DatabaseOperation()
        {
            //
            // TODO: Add constructor logic here
            //
            dbcon = new DbConnection();
        }

        public void getConnection()
        {
            try
            {
                dbcon.con.Open();
                dbcon.cmd.Connection = dbcon.con;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void executeNonQuery(String command)
        {
            try
            {
                dbcon.cmd.CommandText = command;
                dbcon.cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void executeReader(String command)
        {
            try
            {
                dbcon.cmd.CommandText = command;
                dbcon.dr = dbcon.cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void closeConnection()
        {
            try
            {
                dbcon.con.Close();
                if (dbcon.dr != null)
                {
                    dbcon.dr.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
