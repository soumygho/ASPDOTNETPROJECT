using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
namespace offsetLibrary
{
    public class QuotationOperation
    {

        private DatabaseOperation dbops = null;
        public DbConnection dbcon = null;
        CreateDateClass craetedate = new CreateDateClass();
        public QuotationOperation()
        {
            dbops = new DatabaseOperation();
            dbcon = new DbConnection();
        }
        OleDbTransaction transaction = null;
        public Quotation insertIntoQuotation(Quotation quotation)
        {
            
            bool flag = false;
            if (quotation.Orders != null&&quotation.Orders.Count>0)
            {
            try
            {
                quotation.Quotedate = craetedate.createDate(quotation.Quotedate);
                string command = "";
                dbcon.con.Open();
                transaction = dbcon.con.BeginTransaction();
                dbcon.cmd.Connection = dbcon.con;
                dbcon.cmd.Transaction = transaction;
                int lastid = 0;
                //read last quotation id
                command = "select quoteid as lastid from quotationid;";
                dbcon.cmd.CommandText = command;
                bool hasrows = false;
                dbcon.dr = dbcon.cmd.ExecuteReader();
                if (dbcon.dr.HasRows)
                {
                    while (dbcon.dr.Read())
                    {
                        lastid =Int32.Parse(dbcon.dr["lastid"].ToString());
                        hasrows = true;
                    }
                }
                dbcon.dr.Close();
                ++lastid;
                
                //increment lastid to get currentid
                
               
                command = "insert into quotation (userid,totalamount,quotedate,transmonth,transyear,quoteid)";
                command += "values (" + quotation.Customer.Customerid + ",'" + quotation.Totalamount + "',"+quotation.Quotedate+","+quotation.Transmonth+","+quotation.Transyear+","+lastid+");";
                dbcon.cmd.CommandText = command;
                dbcon.cmd.ExecuteNonQuery();
                int lastorderid = 0;
                command = "select lastorderid  as orderid from lastorderid;";
                dbcon.cmd.CommandText = command;
                dbcon.dr = dbcon.cmd.ExecuteReader();
                hasrows = false;
                if (dbcon.dr.HasRows)
                {
                    while (dbcon.dr.Read())
                    {
                        lastorderid =Int32.Parse( dbcon.dr["orderid"].ToString());
                        hasrows = true;
                    }
                }
                dbcon.dr.Close();
                
                //insertinto cost
                for (int i = 0; i < quotation.Orders.Count; i++)
                {

                    ++lastorderid;
                    OrderDetails order = quotation.Orders[i];
                    //insert into order details
                    command = "insert into orderdetails (paper,[size],color,printside,flexsize,stampmodelno,quoteid,qty,description,categoryid,orderid)";
                    command += "values ('" + order.Papername + "','" + order.Size + "','" + order.Color + "',";
                    command += "'" + order.Printside + "','" + order.Flexsize + "','" + order.Stampmodelno + "'," + lastid + "," + order.Qty + ",'" + order.Description + "'," + order.Categoryid + "," + lastorderid + ") ;";
                    dbcon.cmd.CommandText = command;
                    dbcon.cmd.ExecuteNonQuery();
                    CostTable cost = order.Cost;
                    command = "insert into costtable (orderid,pagecost,colorcost,bindingcost,dtpcost,deliverycost,additionalprofit,printcost,totalcost,categoryid)";
                    command += "values (" + lastorderid + ",'" + cost.Pagecost + "','" + cost.Colorcost + "','" + cost.Bindingcost + "',";
                    command += "'" + cost.Dtpcost + "','" + cost.Deliverycost + "','" + cost.Additionalprofit + "','" + cost.Printcost + "','" + cost.Totalcost + "'," + cost.Categoryid + ");";
                    dbcon.cmd.CommandText = command;
                    dbcon.cmd.ExecuteNonQuery();
                   
                }
                if (!hasrows)
                {

                    command = "insert into quotationid (quoteid) values(1);";
                    dbcon.cmd.CommandText = command;
                    dbcon.cmd.ExecuteNonQuery();
                }
                else
                {
                    command = "update quotationid set quoteid = " + lastid;
                    dbcon.cmd.CommandText = command;
                    dbcon.cmd.ExecuteNonQuery();
                }
                if (!hasrows)
                {
                    command = "insert into lastorderid (lastorderid) values(1);";
                    dbcon.cmd.CommandText = command;
                    dbcon.cmd.ExecuteNonQuery();
                }
                else
                {
                    command = "update lastorderid set lastorderid = " + lastorderid;
                    dbcon.cmd.CommandText = command;
                    dbcon.cmd.ExecuteNonQuery();
                }
                transaction.Commit();
                quotation.Id = lastid;
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
                dbcon.con.Close();
            }
        }
            return quotation;
        }


        public bool updateQuotation(Quotation quotation)
        {
            bool flag = false;
            try
            {
                string command = "";
                dbcon.con.Open();
                transaction = dbcon.con.BeginTransaction();
                dbcon.cmd.Connection = dbcon.con;
                dbcon.cmd.Transaction = transaction;
                
                
                
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
                dbcon.con.Close();
            }
            return flag;
        }

       
    }
}
