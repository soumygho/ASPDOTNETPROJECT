using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace offsetLibrary
{
    public class AdminTransactionReport
    {
        private DatabaseOperation dbops = null;
        public DbConnection dbcon = null;
        private CreateDateClass createdate = null;
        public AdminTransactionReport()
        {
            dbops = new DatabaseOperation();
            dbcon = new DbConnection();
            createdate = new CreateDateClass();
        }
        public List<AdminTransaction> getUserTransactions()
        {
            List<AdminTransaction> transactions = null;
            try
            {
                dbops.getConnection();
                string command = "select * from admintransaction;";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    transactions = new List<AdminTransaction>();
                    AdminTransaction transaction = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        transaction = new AdminTransaction();
                        
                        transaction.Transdate = dbops.dbcon.dr["transdate"].ToString();
                        transaction.Credit = float.Parse(dbops.dbcon.dr["credit"].ToString());
                        transaction.Debit = float.Parse(dbops.dbcon.dr["debit"].ToString());
                        transaction.Opbalance = float.Parse(dbops.dbcon.dr["opbalance"].ToString());
                        transaction.Closingbalance = float.Parse(dbops.dbcon.dr["closingbalance"].ToString());
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transaction.Chequeno = dbops.dbcon.dr["chequeno"].ToString();
                        transaction.Description = dbops.dbcon.dr["description"].ToString();
                        transaction.Accno = dbops.dbcon.dr["accno"].ToString();
                        transaction.Method = dbops.dbcon.dr["method"].ToString();
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
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
        public List<AdminTransaction> getUserTransactionsFilterByMonth(int month)
        {
            List<AdminTransaction> transactions = null;
            try
            {
                dbops.getConnection();
                string command = "select * from admintransaction where transmonth = "+month+";";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    transactions = new List<AdminTransaction>();
                    AdminTransaction transaction = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        transaction = new AdminTransaction();

                        transaction.Transdate = dbops.dbcon.dr["transdate"].ToString();
                        transaction.Credit = float.Parse(dbops.dbcon.dr["credit"].ToString());
                        transaction.Debit = float.Parse(dbops.dbcon.dr["debit"].ToString());
                        transaction.Opbalance = float.Parse(dbops.dbcon.dr["opbalance"].ToString());
                        transaction.Closingbalance = float.Parse(dbops.dbcon.dr["closingbalance"].ToString());
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transaction.Chequeno = dbops.dbcon.dr["chequeno"].ToString();
                        transaction.Description = dbops.dbcon.dr["description"].ToString();
                        transaction.Accno = dbops.dbcon.dr["accno"].ToString();
                        transaction.Method = dbops.dbcon.dr["method"].ToString();
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
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
        public List<AdminTransaction> getUserTransactionsFilterByYear(int year)
        {
            List<AdminTransaction> transactions = null;
            try
            {
                dbops.getConnection();
                string command = "select * from admintransaction where transyear = " + year + ";";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    transactions = new List<AdminTransaction>();
                    AdminTransaction transaction = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        transaction = new AdminTransaction();

                        transaction.Transdate = dbops.dbcon.dr["transdate"].ToString();
                        transaction.Credit = float.Parse(dbops.dbcon.dr["credit"].ToString());
                        transaction.Debit = float.Parse(dbops.dbcon.dr["debit"].ToString());
                        transaction.Opbalance = float.Parse(dbops.dbcon.dr["opbalance"].ToString());
                        transaction.Closingbalance = float.Parse(dbops.dbcon.dr["closingbalance"].ToString());
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transaction.Chequeno = dbops.dbcon.dr["chequeno"].ToString();
                        transaction.Description = dbops.dbcon.dr["description"].ToString();
                        transaction.Accno = dbops.dbcon.dr["accno"].ToString();
                        transaction.Method = dbops.dbcon.dr["method"].ToString();
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
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
        public List<AdminTransaction> getUserTransactionsFilterByDate(string date)
        {
            List<AdminTransaction> transactions = null;
            try
            {
                date = createdate.createDate(date);
                dbops.getConnection();
                string command = "select * from admintransaction where transdate = " + date + ";";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    transactions = new List<AdminTransaction>();
                    AdminTransaction transaction = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        transaction = new AdminTransaction();

                        transaction.Transdate = dbops.dbcon.dr["transdate"].ToString();
                        transaction.Credit = float.Parse(dbops.dbcon.dr["credit"].ToString());
                        transaction.Debit = float.Parse(dbops.dbcon.dr["debit"].ToString());
                        transaction.Opbalance = float.Parse(dbops.dbcon.dr["opbalance"].ToString());
                        transaction.Closingbalance = float.Parse(dbops.dbcon.dr["closingbalance"].ToString());
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transaction.Chequeno = dbops.dbcon.dr["chequeno"].ToString();
                        transaction.Description = dbops.dbcon.dr["description"].ToString();
                        transaction.Accno = dbops.dbcon.dr["accno"].ToString();
                        transaction.Method = dbops.dbcon.dr["method"].ToString();
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
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
        public List<AdminTransaction> getUserTransactionsForExpense()
        {
            List<AdminTransaction> transactions = null;
            try
            {
                dbops.getConnection();
                string command = "select * from admintransaction where description <> 'REFUND' and debit <> '0';";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    transactions = new List<AdminTransaction>();
                    AdminTransaction transaction = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        transaction = new AdminTransaction();

                        transaction.Transdate = dbops.dbcon.dr["transdate"].ToString();
                        transaction.Credit = float.Parse(dbops.dbcon.dr["credit"].ToString());
                        transaction.Debit = float.Parse(dbops.dbcon.dr["debit"].ToString());
                        transaction.Opbalance = float.Parse(dbops.dbcon.dr["opbalance"].ToString());
                        transaction.Closingbalance = float.Parse(dbops.dbcon.dr["closingbalance"].ToString());
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transaction.Chequeno = dbops.dbcon.dr["chequeno"].ToString();
                        transaction.Description = dbops.dbcon.dr["description"].ToString();
                        transaction.Accno = dbops.dbcon.dr["accno"].ToString();
                        transaction.Method = dbops.dbcon.dr["method"].ToString();
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
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
        public List<AdminTransaction> getUserTransactionsForExpenseFilterByMonth(int month)
        {
            List<AdminTransaction> transactions = null;
            try
            {
                dbops.getConnection();
                string command = "select * from admintransaction where description <> 'REFUND' and debit <> '0' and transmonth = "+month+";";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    transactions = new List<AdminTransaction>();
                    AdminTransaction transaction = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        transaction = new AdminTransaction();

                        transaction.Transdate = dbops.dbcon.dr["transdate"].ToString();
                        transaction.Credit = float.Parse(dbops.dbcon.dr["credit"].ToString());
                        transaction.Debit = float.Parse(dbops.dbcon.dr["debit"].ToString());
                        transaction.Opbalance = float.Parse(dbops.dbcon.dr["opbalance"].ToString());
                        transaction.Closingbalance = float.Parse(dbops.dbcon.dr["closingbalance"].ToString());
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transaction.Chequeno = dbops.dbcon.dr["chequeno"].ToString();
                        transaction.Description = dbops.dbcon.dr["description"].ToString();
                        transaction.Accno = dbops.dbcon.dr["accno"].ToString();
                        transaction.Method = dbops.dbcon.dr["method"].ToString();
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
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
        public List<AdminTransaction> getUserTransactionsForExpenseFilterByYear(int year)
        {
            List<AdminTransaction> transactions = null;
            try
            {
                dbops.getConnection();
                string command = "select * from admintransaction where description <> 'REFUND' and debit <> '0' and transyear = " + year + ";";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    transactions = new List<AdminTransaction>();
                    AdminTransaction transaction = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        transaction = new AdminTransaction();

                        transaction.Transdate = dbops.dbcon.dr["transdate"].ToString();
                        transaction.Credit = float.Parse(dbops.dbcon.dr["credit"].ToString());
                        transaction.Debit = float.Parse(dbops.dbcon.dr["debit"].ToString());
                        transaction.Opbalance = float.Parse(dbops.dbcon.dr["opbalance"].ToString());
                        transaction.Closingbalance = float.Parse(dbops.dbcon.dr["closingbalance"].ToString());
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transaction.Chequeno = dbops.dbcon.dr["chequeno"].ToString();
                        transaction.Description = dbops.dbcon.dr["description"].ToString();
                        transaction.Accno = dbops.dbcon.dr["accno"].ToString();
                        transaction.Method = dbops.dbcon.dr["method"].ToString();
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
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
        public List<AdminTransaction> getUserTransactionsForExpenseFilterByDate(string date)
        {
            List<AdminTransaction> transactions = null;
            try
            {
                date = createdate.createDate(date);
                dbops.getConnection();
                string command = "select * from admintransaction where description <> 'REFUND' and debit <> '0' and transdate = " + date + ";";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    transactions = new List<AdminTransaction>();
                    AdminTransaction transaction = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        transaction = new AdminTransaction();

                        transaction.Transdate = dbops.dbcon.dr["transdate"].ToString();
                        transaction.Credit = float.Parse(dbops.dbcon.dr["credit"].ToString());
                        transaction.Debit = float.Parse(dbops.dbcon.dr["debit"].ToString());
                        transaction.Opbalance = float.Parse(dbops.dbcon.dr["opbalance"].ToString());
                        transaction.Closingbalance = float.Parse(dbops.dbcon.dr["closingbalance"].ToString());
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transaction.Chequeno = dbops.dbcon.dr["chequeno"].ToString();
                        transaction.Description = dbops.dbcon.dr["description"].ToString();
                        transaction.Accno = dbops.dbcon.dr["accno"].ToString();
                        transaction.Method = dbops.dbcon.dr["method"].ToString();
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
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
        public List<AdminTransaction> getUserTransactionsForDebit()
        {
            List<AdminTransaction> transactions = null;
            try
            {
                dbops.getConnection();
                string command = "select * from admintransaction where  debit <> '0' and credit = '0';";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    transactions = new List<AdminTransaction>();
                    AdminTransaction transaction = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        transaction = new AdminTransaction();

                        transaction.Transdate = dbops.dbcon.dr["transdate"].ToString();
                        transaction.Credit = float.Parse(dbops.dbcon.dr["credit"].ToString());
                        transaction.Debit = float.Parse(dbops.dbcon.dr["debit"].ToString());
                        transaction.Opbalance = float.Parse(dbops.dbcon.dr["opbalance"].ToString());
                        transaction.Closingbalance = float.Parse(dbops.dbcon.dr["closingbalance"].ToString());
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transaction.Chequeno = dbops.dbcon.dr["chequeno"].ToString();
                        transaction.Description = dbops.dbcon.dr["description"].ToString();
                        transaction.Accno = dbops.dbcon.dr["accno"].ToString();
                        transaction.Method = dbops.dbcon.dr["method"].ToString();
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
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
        public List<AdminTransaction> getUserTransactionsForDebitFilterByMonth(int month)
        {
            List<AdminTransaction> transactions = null;
            try
            {
                dbops.getConnection();
                string command = "select * from admintransaction where  debit <> '0' and credit = '0' and transmonth = "+month+";";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    transactions = new List<AdminTransaction>();
                    AdminTransaction transaction = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        transaction = new AdminTransaction();

                        transaction.Transdate = dbops.dbcon.dr["transdate"].ToString();
                        transaction.Credit = float.Parse(dbops.dbcon.dr["credit"].ToString());
                        transaction.Debit = float.Parse(dbops.dbcon.dr["debit"].ToString());
                        transaction.Opbalance = float.Parse(dbops.dbcon.dr["opbalance"].ToString());
                        transaction.Closingbalance = float.Parse(dbops.dbcon.dr["closingbalance"].ToString());
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transaction.Chequeno = dbops.dbcon.dr["chequeno"].ToString();
                        transaction.Description = dbops.dbcon.dr["description"].ToString();
                        transaction.Accno = dbops.dbcon.dr["accno"].ToString();
                        transaction.Method = dbops.dbcon.dr["method"].ToString();
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
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
        public List<AdminTransaction> getUserTransactionsForDebitFilterByYear(int year)
        {
            List<AdminTransaction> transactions = null;
            try
            {
                dbops.getConnection();
                string command = "select * from admintransaction where  debit <> '0' and credit = '0' and transyear = "+year+";";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    transactions = new List<AdminTransaction>();
                    AdminTransaction transaction = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        transaction = new AdminTransaction();

                        transaction.Transdate = dbops.dbcon.dr["transdate"].ToString();
                        transaction.Credit = float.Parse(dbops.dbcon.dr["credit"].ToString());
                        transaction.Debit = float.Parse(dbops.dbcon.dr["debit"].ToString());
                        transaction.Opbalance = float.Parse(dbops.dbcon.dr["opbalance"].ToString());
                        transaction.Closingbalance = float.Parse(dbops.dbcon.dr["closingbalance"].ToString());
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transaction.Chequeno = dbops.dbcon.dr["chequeno"].ToString();
                        transaction.Description = dbops.dbcon.dr["description"].ToString();
                        transaction.Accno = dbops.dbcon.dr["accno"].ToString();
                        transaction.Method = dbops.dbcon.dr["method"].ToString();
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
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
        public List<AdminTransaction> getUserTransactionsForDebitFilterByDate(string date)
        {
            List<AdminTransaction> transactions = null;
            try
            {
                date = createdate.createDate(date);
                dbops.getConnection();
                string command = "select * from admintransaction where  debit <> '0' and credit = '0' and transdate = "+date+";";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    transactions = new List<AdminTransaction>();
                    AdminTransaction transaction = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        transaction = new AdminTransaction();

                        transaction.Transdate = dbops.dbcon.dr["transdate"].ToString();
                        transaction.Credit = float.Parse(dbops.dbcon.dr["credit"].ToString());
                        transaction.Debit = float.Parse(dbops.dbcon.dr["debit"].ToString());
                        transaction.Opbalance = float.Parse(dbops.dbcon.dr["opbalance"].ToString());
                        transaction.Closingbalance = float.Parse(dbops.dbcon.dr["closingbalance"].ToString());
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transaction.Chequeno = dbops.dbcon.dr["chequeno"].ToString();
                        transaction.Description = dbops.dbcon.dr["description"].ToString();
                        transaction.Accno = dbops.dbcon.dr["accno"].ToString();
                        transaction.Method = dbops.dbcon.dr["method"].ToString();
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
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
        public List<AdminTransaction> getUserTransactions(int billid)
        {
            List<AdminTransaction> transactions = null;
            try
            {
                dbops.getConnection();
                string command = "select * from admintransaction where billid = '"+billid+"';";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    transactions = new List<AdminTransaction>();
                    AdminTransaction transaction = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        transaction = new AdminTransaction();

                        transaction.Transdate = dbops.dbcon.dr["transdate"].ToString();
                        transaction.Credit = float.Parse(dbops.dbcon.dr["credit"].ToString());
                        transaction.Debit = float.Parse(dbops.dbcon.dr["debit"].ToString());
                        transaction.Opbalance = float.Parse(dbops.dbcon.dr["opbalance"].ToString());
                        transaction.Closingbalance = float.Parse(dbops.dbcon.dr["closingbalance"].ToString());
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
                        transaction.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        transaction.Chequeno = dbops.dbcon.dr["chequeno"].ToString();
                        transaction.Description = dbops.dbcon.dr["description"].ToString();
                        transaction.Accno = dbops.dbcon.dr["accno"].ToString();
                        transaction.Method = dbops.dbcon.dr["method"].ToString();
                        transaction.Billid = dbops.dbcon.dr["billid"].ToString();
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
        public DataTable generateTableForAdminTransaction(List<AdminTransaction> bills)
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
                col = new DataColumn("TRANSACTION METHOD");
                data.Columns.Add(col);
                col = new DataColumn("DESCRIPTION");
                data.Columns.Add(col);
               
                col = new DataColumn("ACC NO");
                data.Columns.Add(col);
                col = new DataColumn("CHEQUE NO");
                data.Columns.Add(col);
                for (int i = 0; i < bills.Count; i++)
                {
                    DataRow dr = data.NewRow();
                    dr["TRANS ID"] = bills[i].Id;
                    dr["BILLID"] = bills[i].Billid;
                    dr["RECIEPTID"] = bills[i].Receiptid;
                    dr["TRANS DATE"] = bills[i].Transdate;
                    dr["OPENING"] = bills[i].Opbalance;
                    dr["CLOSING"] = bills[i].Closingbalance;
                    dr["CREDIT"] = bills[i].Credit;
                    dr["DEBIT"] = bills[i].Debit;
                    dr["TRANSACTION METHOD"] = bills[i].Method;
                    dr["DESCRIPTION"] = bills[i].Description;
                    dr["ACC NO"] = bills[i].Accno;
                    dr["CHEQUE NO"] = bills[i].Description;
                    data.Rows.Add(dr);
                }
            }
            return data;
        }
    }
    }

