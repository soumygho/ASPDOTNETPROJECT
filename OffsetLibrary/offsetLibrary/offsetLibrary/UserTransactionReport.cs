using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace offsetLibrary
{
 public   class UserTransactionReport
    {
        private DatabaseOperation dbops = null;
        public DbConnection dbcon = null;
        private CreateDateClass createdate = null;
        public UserTransactionReport()
        {
            dbops = new DatabaseOperation();
            dbcon = new DbConnection();
            createdate = new CreateDateClass();
        }
        public List<UserTransaction> getUserTransactions(CustomerDetails customer)
        {
            List<UserTransaction> transactions = null;
            try
            {
                dbops.getConnection();
                string command = "select * from usertransaction where userid = "+customer.Customerid;
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    transactions = new List<UserTransaction>();
                    UserTransaction transaction = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        transaction = new UserTransaction();
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transaction.Transdate = dbops.dbcon.dr["transdate"].ToString();
                        transaction.Credit = float.Parse(dbops.dbcon.dr["credit"].ToString());
                        transaction.Debit = float.Parse(dbops.dbcon.dr["debit"].ToString());
                        transaction.Opbalance = float.Parse(dbops.dbcon.dr["opbalance"].ToString());
                        transaction.Closingbalance = float.Parse(dbops.dbcon.dr["closingbalance"].ToString());
                        if (transaction.Credit > 0)
                        {
                            transaction.Recieptid = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        }
                        else
                        {
                            transaction.Billid = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        }
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transactions.Add(transaction);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbops.closeConnection();
            }
            return transactions;
        }
        public List<UserTransaction> getUserTransactions(CustomerDetails customer,String date)
        {
            date = createdate.createDate(date);
            List<UserTransaction> transactions = null;
            try
            {
                dbops.getConnection();
                string command = "select * from usertransaction where userid = " + customer.Customerid+" and transdate = "+date;
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    transactions = new List<UserTransaction>();
                    UserTransaction transaction = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        transaction = new UserTransaction();
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transaction.Transdate = dbops.dbcon.dr["transdate"].ToString();
                        transaction.Credit = float.Parse(dbops.dbcon.dr["credit"].ToString());
                        transaction.Debit = float.Parse(dbops.dbcon.dr["debit"].ToString());
                        transaction.Opbalance = float.Parse(dbops.dbcon.dr["opbalance"].ToString());
                        transaction.Closingbalance = float.Parse(dbops.dbcon.dr["closingbalance"].ToString());
                        if (transaction.Credit > 0)
                        {
                            transaction.Recieptid = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        }
                        else
                        {
                            transaction.Billid = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        }
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transactions.Add(transaction);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbops.closeConnection();
            }
            return transactions;
        }

       

        public List<UserTransaction> getUserTransactionsByMonth(CustomerDetails customer, int month)
        {
            
            List<UserTransaction> transactions = null;
            try
            {
                dbops.getConnection();
                string command = "select * from usertransaction where userid = " + customer.Customerid + " and transmonth = "+month+"";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    transactions = new List<UserTransaction>();
                    UserTransaction transaction = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        transaction = new UserTransaction();
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transaction.Transdate = dbops.dbcon.dr["transdate"].ToString();
                        transaction.Credit = float.Parse(dbops.dbcon.dr["credit"].ToString());
                        transaction.Debit = float.Parse(dbops.dbcon.dr["debit"].ToString());
                        transaction.Opbalance = float.Parse(dbops.dbcon.dr["opbalance"].ToString());
                        transaction.Closingbalance = float.Parse(dbops.dbcon.dr["closingbalance"].ToString());
                        if (transaction.Credit > 0)
                        {
                            transaction.Recieptid = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        }
                        else
                        {
                            transaction.Billid = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        }
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transactions.Add(transaction);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbops.closeConnection();
            }
            return transactions;
        }
        public List<UserTransaction> getUserTransactionsByYear(CustomerDetails customer, int year)
        {

            List<UserTransaction> transactions = null;
            try
            {
                dbops.getConnection();
                string command = "select * from usertransaction where userid = " + customer.Customerid + " and transyear = " + year + "";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    transactions = new List<UserTransaction>();
                    UserTransaction transaction = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        transaction = new UserTransaction();
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transaction.Transdate = dbops.dbcon.dr["transdate"].ToString();
                        transaction.Credit = float.Parse(dbops.dbcon.dr["credit"].ToString());
                        transaction.Debit = float.Parse(dbops.dbcon.dr["debit"].ToString());
                        transaction.Opbalance = float.Parse(dbops.dbcon.dr["opbalance"].ToString());
                        transaction.Closingbalance = float.Parse(dbops.dbcon.dr["closingbalance"].ToString());
                        if (transaction.Credit > 0)
                        {
                            transaction.Recieptid = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        }
                        else
                        {
                            transaction.Billid = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        }
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transactions.Add(transaction);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbops.closeConnection();
            }
            return transactions;
        }
        public DataTable generateTableForOnspotBill(List<UserTransaction> bills)
        {
            DataTable data = null;

            if (bills != null && bills.Count > 0)
            {
                data = new DataTable();
                DataColumn col = new DataColumn("TRANS ID");
                data.Clear();
                data.Columns.Add(col);
                col = new DataColumn("TRANS DATE");
                data.Columns.Add(col);
                col = new DataColumn("OPENING");
                data.Columns.Add(col);
                col = new DataColumn("CREDIT");
                data.Columns.Add(col);
                col = new DataColumn("DEBIT");
                data.Columns.Add(col);
                col = new DataColumn("CLOSING");
                data.Columns.Add(col);
                col = new DataColumn("BILLID");
                data.Columns.Add(col);
                col = new DataColumn("RECIEPTID");
                data.Columns.Add(col);
                for (int i = 0; i < bills.Count; i++)
                {
                    DataRow dr = data.NewRow();
                    dr["TRANS ID"] = bills[i].Id;
                    dr["BILLID"] = bills[i].Billid;
                    dr["RECIEPTID"] = bills[i].Recieptid;
                    dr["TRANS DATE"] = bills[i].Transdate;
                    dr["OPENING"] = bills[i].Opbalance;
                    dr["CLOSING"] = bills[i].Closingbalance;
                    dr["CREDIT"] = bills[i].Credit;
                    dr["DEBIT"] = bills[i].Debit;
                    data.Rows.Add(dr);
                }
            }
            return data;
        }
    }
}
