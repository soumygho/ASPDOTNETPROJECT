using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace offsetLibrary
{
   public class AdminTrnsactionOperation
    {
         private DatabaseOperation dbops = null;
      
        private CreateDateClass createdate = null;
        public AdminTrnsactionOperation()
        {
            dbops = new DatabaseOperation();
            
            createdate = new CreateDateClass();
        }
        OleDbTransaction transaction = null;
        public bool insertExpenseIntoAdminTransaction(AdminTransaction admintransaction)
        {
            bool flag = false;
            try
            {
                admintransaction.Transdate = createdate.createDate(DateTime.Today.ToShortDateString());
                admintransaction.Transmonth = DateTime.Today.Month;
                admintransaction.Transyear = DateTime.Today.Year;
                dbops.dbcon.con.Open();
                transaction = dbops.dbcon.con.BeginTransaction();
                dbops.dbcon.cmd.Connection = dbops.dbcon.con;
                dbops.dbcon.cmd.Transaction = transaction;
                string command = "";
                float adminopeningbalance = 0;
                command = "select last(closingbalance) as userclosing from admintransaction;";
                dbops.dbcon.cmd.CommandText = command;
                dbops.dbcon.dr = dbops.dbcon.cmd.ExecuteReader();
                if (dbops.dbcon.dr.HasRows)
                {
                    while (dbops.dbcon.dr.Read())
                    {
                        try
                        {
                            adminopeningbalance = float.Parse(dbops.dbcon.dr["userclosing"].ToString());
                        }
                        catch (Exception e)
                        {
                        }
                    }
                }
                dbops.dbcon.dr.Close();



                float adminclosing = adminopeningbalance - admintransaction.Debit;
                command = "insert into admintransaction (opbalance,credit,debit,description,method,billid,receiptid,transdate,chequeno,accno,transmonth,transyear,closingbalance)";
                command += "values ('" + adminopeningbalance + "','" + admintransaction.Credit + "','" + admintransaction.Debit + "','" + admintransaction.Description + "',";
                command += "'" + admintransaction.Method + "','" + admintransaction.Billid + "','" + admintransaction.Receiptid + "'," + admintransaction.Transdate + ",'" + admintransaction.Chequeno + "','" + admintransaction.Accno + "'," + admintransaction.Transmonth + "," + admintransaction.Transyear + ",'" + adminclosing + "');";
                dbops.dbcon.cmd.CommandText = command;
                dbops.dbcon.cmd.ExecuteNonQuery();
                transaction.Commit();
                flag = true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception em)
                {
                    throw em;
                }
            }
            finally
            {
                dbops.dbcon.con.Close();
            }
            return flag;
        }

    }
}
