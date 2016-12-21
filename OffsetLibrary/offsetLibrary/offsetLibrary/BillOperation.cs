using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace offsetLibrary
{
   public  class BillOperation
    {
        private DatabaseOperation dbops = null;
        public DbConnection dbcon = null;
        private CreateDateClass createdate = null;
        public BillOperation()
        {
            dbops = new DatabaseOperation();
            dbcon = new DbConnection();
            createdate = new CreateDateClass();
        }
        OleDbTransaction transaction = null;
        public Bill insertIntoBill(Bill bill)
        {

            bill.Finalamount = bill.Totalamount - bill.Cons;
            bill.Userid = bill.Customer.Customerid;
                bool flag = false;
                Bill quotation = bill;
                float totalactualcost = 0;
                if (quotation.Orders != null && quotation.Orders.Count > 0)
                {
                    try
                    {
                        bill.Billdate = createdate.createDate(bill.Billdate);
                        String command = "";
                        
                        dbcon.con.Open();
                        transaction = dbcon.con.BeginTransaction();
                        dbcon.cmd.Connection = dbcon.con;
                        dbcon.cmd.Transaction = transaction;
                        int lastid = 0;
                        //read last quotation id
                        command = "select lastbillid  from billid;";
                        dbcon.cmd.CommandText = command;
                        dbcon.dr = dbcon.cmd.ExecuteReader();
                        if (dbcon.dr.HasRows)
                        {
                            while (dbcon.dr.Read())
                            {
                                try
                                {
                                lastid = Int32.Parse(dbcon.dr["lastbillid"].ToString());
                                }
                                catch (Exception e)
                                {
                                }
                            }
                        }
                        dbcon.dr.Close();
                        //increment lastid to get currentid
                        ++lastid;
                        bill.Id = lastid;
                        command = "insert into bill (userid,totalamount,billdate,cons,finalamount,transmonth,transyear,billid)";
                        command += "values (" + bill.Customer.Customerid + ",'" + bill.Totalamount + "',";
                        command += "" + bill.Billdate + ",'" + bill.Cons + "','" + bill.Finalamount + "',"+bill.Transmonth+","+bill.Transyear+","+lastid+");";
                        
                        dbcon.cmd.CommandText = command;
                        dbcon.cmd.ExecuteNonQuery();
                        int lastorderid = 0;
                        command = "select lastorderid  from lastorderid;";
                        dbcon.cmd.CommandText = command;
                        dbcon.dr = dbcon.cmd.ExecuteReader();
                        if (dbcon.dr.HasRows)
                        {
                            while (dbcon.dr.Read())
                            {
                                try
                                {
                                    lastorderid = Int32.Parse(dbcon.dr["lastorderid"].ToString());
                                }
                                catch (Exception e)
                                {
                                }
                            }
                        }
                        dbcon.dr.Close();
                        //insertinto cost
                        for (int i = 0; i < quotation.Orders.Count; i++)
                        {

                            ++lastorderid;
                            OrderDetails order = quotation.Orders[i];
                            //insert into order details
                            command = "insert into orderdetails (paper,[size],color,printside,flexsize,stampmodelno,billid,qty,description,categoryid,orderid)";
                            command += "values ('" + order.Papername + "','" + order.Size + "','" + order.Color + "',";
                            command += "'" + order.Printside + "','" + order.Flexsize + "','" + order.Stampmodelno + "'," + lastid + "," + order.Qty + ",'" + order.Description + "'," + order.Categoryid + ","+lastorderid+") ;";
                            
                            dbcon.cmd.CommandText = command;

                            dbcon.cmd.ExecuteNonQuery();
                            CostTable cost = order.Cost;
                            cost.Categoryid = order.Categoryid;
                            command = "insert into costtable (orderid,pagecost,colorcost,bindingcost,dtpcost,deliverycost,additionalprofit,printcost,totalcost,categoryid)";
                            command += "values (" + lastorderid + ",'" + cost.Pagecost + "','" + cost.Colorcost + "','" + cost.Bindingcost + "',";
                            command += "'" + cost.Dtpcost + "','" + cost.Deliverycost + "','" + cost.Additionalprofit + "','" + cost.Printcost + "','" + cost.Totalcost + "'," + cost.Categoryid + ");";
                            
                            totalactualcost += (cost.Totalcost-cost.Additionalprofit);
                            
                            dbcon.cmd.CommandText = command;

                            dbcon.cmd.ExecuteNonQuery();

                        }

                        //insertinto usertransaction and profittable and billpaymentdetails if not onspot billing
                        if (bill.Customer.Customerid != 0)
                        {
                            float useropeningbalance = 0;

                            command = "select last(closingbalance) as userclosing from usertransaction where userid = "+bill.Customer.Customerid+";";
                            dbcon.cmd.CommandText = command;
                            dbcon.dr = dbcon.cmd.ExecuteReader();
                            if (dbcon.dr.HasRows)
                            {
                                while (dbcon.dr.Read())
                                {
                                    try
                                    {
                                        useropeningbalance = float.Parse(dbcon.dr["userclosing"].ToString());
                                    }
                                    catch (Exception e)
                                    {
                                    }
                                }
                            }
                            dbcon.dr.Close();
                            float userclosingbalance = useropeningbalance - bill.Finalamount;

                            UserTransaction usertransaction = new UserTransaction();
                            usertransaction.Credit = 0;
                            usertransaction.Billid = lastid;
                            usertransaction.Userid = bill.Customer.Customerid;
                            usertransaction.Transdate = bill.Billdate;

                            usertransaction.Debit = bill.Finalamount;
                            usertransaction.Transmonth = bill.Transmonth;
                            usertransaction.Transyear = bill.Transyear;
                            command = "insert into usertransaction (userid,credit,debit,transdate,billid,receiptid,transmonth,transyear,opbalance,closingbalance)";
                            command += " values (" + usertransaction.Userid + ",'" + usertransaction.Credit + "','" + usertransaction.Debit + "',";
                            command += "" + usertransaction.Transdate + "," + usertransaction.Billid + "," + usertransaction.Recieptid + "," + usertransaction.Transmonth + "," + usertransaction.Transyear + ",'" + useropeningbalance + "','" + userclosingbalance + "');";
                            dbcon.cmd.CommandText = command;
                            dbcon.cmd.ExecuteNonQuery();
                        }
                        //insert into billpaymentdetails

                        


                        
                        BillPaymentDetails payment = new BillPaymentDetails();
                        payment.Billid = lastid;
                        payment.Finalamount = bill.Finalamount;
                        if (bill.Userid != 0)
                        {
                            payment.Outstanding = bill.Finalamount;
                        }
                        command = "insert into billpaymentdetails  (finalamount,paidamount ,outstanding,billid) values( '" + payment.Finalamount + "',  '" + payment.Paidamount + "','" + payment.Outstanding + "',"+bill.Id+");";
                        dbcon.cmd.CommandText = command;
                        dbcon.cmd.ExecuteNonQuery();

                        //insert into profit

                        ProfitTable profit = new ProfitTable();
                        profit.Actualcost = totalactualcost;
                        profit.Billid = lastid;
                        profit.Finalamount = bill.Finalamount;
                        profit.Transdate = bill.Billdate;
                        profit.Transmonth = bill.Transmonth;
                        profit.Transyear = bill.Transyear;
                        float profitamount = profit.Finalamount - profit.Actualcost;
                        float lossamount = 0;
                        if (profitamount < 0)
                        {
                            lossamount = profit.Actualcost - profit.Finalamount;
                        }
                        profit.Loss = lossamount;
                        profit.Profit = profitamount;
                        command = "insert into profittable (actualcost,finalamount,profit,loss,billid,transdate,transmonth,transyear) values ";
                        command += "('" + profit.Actualcost + "','" + profit.Finalamount + "','" + profit.Profit + "','" + profit.Loss +"',"+profit.Billid+","+profit.Transdate+","+profit.Transmonth+","+profit.Transyear+");";
                        dbcon.cmd.CommandText = command;
                        dbcon.cmd.ExecuteNonQuery();
                        
                        //update lastbillid and orderdetailsid
                        command = "update billid set lastbillid = "+lastid+";";
                        dbcon.cmd.CommandText = command;
                        dbcon.cmd.ExecuteNonQuery();
                        command = "update lastorderid set lastorderid = "+lastorderid+";";
                        dbcon.cmd.CommandText = command;
                        dbcon.cmd.ExecuteNonQuery();
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
                        throw e;
                    }
                    finally
                    {
                        dbcon.con.Close();
                    }
                }
                return bill;
        }


        public bool updateBill(Bill bill)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "update bill set userid = '" + bill.Userid + "'" ;
                command += ",totalamount = '" + bill.Totalamount + "',billdate = '" + bill.Billdate + "',cons = '" + bill.Cons + "',finalamount = '" + bill.Finalamount + "';";
                dbops.executeNonQuery(command);
                flag = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dbops.closeConnection();
            }
            return flag;
        }


        public bool payBillagainstSpecificBill(BillPaymentDetails payment,Transaction trans,CustomerDetails userid)
        {
            String command = "";
            payment.Transdate = createdate.createDate(payment.Transdate);
            AdminTransaction admintransaction = new AdminTransaction();
            admintransaction.Billid = payment.Billid.ToString();
            admintransaction.Credit = payment.Paidamount;
            admintransaction.Debit = 0;
            admintransaction.Description = trans.Description;
            admintransaction.Method = trans.Method ;
            admintransaction.Transdate = payment.Transdate;
            admintransaction.Transmonth = payment.Transmonth;
            admintransaction.Transyear = payment.Transyear;
            UserTransaction usertransaction = new UserTransaction();
            usertransaction.Credit = payment.Paidamount;
            usertransaction.Billid = payment.Billid;
            usertransaction.Userid = userid.Customerid;
            usertransaction.Transdate = payment.Transdate;
            
            
            usertransaction.Transmonth = payment.Transmonth;
            usertransaction.Transyear = payment.Transyear;
            payment.Outstanding = payment.Finalamount - payment.Paidamount;
            Receipt receipt = new Receipt();
            receipt.Billid = payment.Billid;
            receipt.Outstanding = payment.Outstanding;
            receipt.Paidamount = payment.Paidamount;
            receipt.Transdate = payment.Transdate;
            receipt.Transmonth = payment.Transmonth;
            receipt.Transyear = payment.Transyear;
            receipt.Userid = userid.Customerid;

            bool flag = false;
            try
            {
                command = "update billpaymentdetails set paidamount = '"+payment.Paidamount+"',outstanding = '"+payment.Outstanding+"' where billid = "+payment.Billid+";";
                dbcon.con.Open();
                transaction = dbcon.con.BeginTransaction();
                dbcon.cmd.Connection = dbcon.con;
                dbcon.cmd.Transaction = transaction;
                dbcon.cmd.CommandText = command;
                dbcon.cmd.ExecuteNonQuery();
                int lastreceiptid = 0;
                command = "select receiptid  from receiptid;";
                dbcon.cmd.CommandText = command;
                dbcon.dr = dbcon.cmd.ExecuteReader();
                if (dbcon.dr.HasRows)
                {
                    while (dbcon.dr.Read())
                    {
                        try
                        {
                            lastreceiptid = Int32.Parse(dbcon.dr["receiptid"].ToString());
                        }
                        catch (Exception e)
                        {
                        }
                    }
                }
                ++lastreceiptid;
                dbcon.dr.Close();
                //insert into receipt
                command = "insert into receipt (userid,billid,paidamount,outstanding,transdate,transmonth,transyear,receiptid) values";
                command += "("+receipt.Userid+","+receipt.Billid+",'"+receipt.Paidamount+"','"+receipt.Outstanding+"',"+receipt.Transdate+","+receipt.Transmonth+","+receipt.Transyear+","+lastreceiptid+");";
                dbcon.cmd.CommandText = command;
                dbcon.cmd.ExecuteNonQuery();
                //user transaction section
                if (userid.Customerid != 0)
                {
                    float useropeningbalance = 0;

                    command = "select last(closingbalance) as userclosing from usertransaction where userid = "+userid.Customerid+";";
                    dbcon.cmd.CommandText = command;
                    dbcon.dr = dbcon.cmd.ExecuteReader();
                    if (dbcon.dr.HasRows)
                    {
                        while (dbcon.dr.Read())
                        {
                            try
                            {
                                useropeningbalance = float.Parse(dbcon.dr["userclosing"].ToString());
                            }
                            catch (Exception e)
                            {
                            }
                        }
                    }
                    dbcon.dr.Close();
                    float userclosing = useropeningbalance + usertransaction.Credit;

                    command = "insert into usertransaction (userid,credit,debit,transdate,billid,receiptid,transmonth,transyear,opbalance,closingbalance)";
                    command += " values (" + usertransaction.Userid + ",'" + usertransaction.Credit + "','" + usertransaction.Debit + "',";
                    command += "" + usertransaction.Transdate + "," + usertransaction.Billid + "," + lastreceiptid + "," + usertransaction.Transmonth + "," + usertransaction.Transyear + ",'" + useropeningbalance + "','" + userclosing + "');";
                    dbcon.cmd.CommandText = command;
                    dbcon.cmd.ExecuteNonQuery();
                }
                //admin transaction section
                   float adminopeningbalance = 0;
                    command = "select last(closingbalance) as userclosing from admintransaction;";
                    dbcon.cmd.CommandText = command;
                    dbcon.dr = dbcon.cmd.ExecuteReader();
                    if (dbcon.dr.HasRows)
                    {
                        while (dbcon.dr.Read())
                        {
                            try
                            {
                                adminopeningbalance = float.Parse(dbcon.dr["userclosing"].ToString());
                            }
                            catch (Exception e)
                            {
                            }
                        }
                    }
                    dbcon.dr.Close();
                    
                    
                
                float adminclosing = adminopeningbalance + usertransaction.Credit;
                command = "insert into admintransaction (opbalance,credit,debit,description,method,billid,receiptid,transdate,chequeno,accno,transmonth,transyear,closingbalance)";
                command += "values ('" + adminopeningbalance+ "','" + admintransaction.Credit + "','" + admintransaction.Debit + "','" + admintransaction.Description + "',";
                command += "'" + admintransaction.Method + "','" + admintransaction.Billid + "','" + lastreceiptid.ToString() + "'," + admintransaction.Transdate + ",'" + admintransaction.Chequeno + "','" + admintransaction.Accno + "',"+admintransaction.Transmonth+","+admintransaction.Transyear+",'"+adminclosing+"');";
                dbcon.cmd.CommandText = command;
                dbcon.cmd.ExecuteNonQuery();
                //update lastreceiptid
                command = "update receiptid set receiptid = "+lastreceiptid+";";
                dbcon.cmd.CommandText = command;
                dbcon.cmd.ExecuteNonQuery();
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
                throw e;
            }
            finally
            {
                dbcon.con.Close();
            }
            return flag;
        }

        public bool payDueBill(BillPaymentDetails payment, Transaction trans, CustomerDetails userid)
        {
            String command = "";
            AdminTransaction admintransaction = new AdminTransaction();
            admintransaction.Billid = payment.Billid.ToString();
            admintransaction.Credit = payment.Paidamount;
            admintransaction.Debit = 0;
            admintransaction.Description = trans.Description;
            admintransaction.Method = trans.Method;
            admintransaction.Transdate = createdate.createDate(DateTime.Today.ToShortDateString());
            admintransaction.Transmonth = payment.Transmonth;
            admintransaction.Transyear = payment.Transyear;
            UserTransaction usertransaction = new UserTransaction();
            usertransaction.Credit = payment.Paidamount;
            usertransaction.Billid = payment.Billid;
            usertransaction.Userid = userid.Customerid;
            usertransaction.Transdate = createdate.createDate(DateTime.Today.ToShortDateString());


            usertransaction.Transmonth = payment.Transmonth;
            usertransaction.Transyear = payment.Transyear;
            bool flag = false;
            try
            {
                dbcon.con.Open();
                transaction = dbcon.con.BeginTransaction();
                dbcon.cmd.Connection = dbcon.con;
                dbcon.cmd.Transaction = transaction;
                //read previous paidamount  and outstanding
                command = "select * from billpaymentdetails where billid = "+payment.Billid+";";
                dbcon.cmd.CommandText = command;
                dbcon.dr = dbcon.cmd.ExecuteReader();
                float paidamount = 0;
                float outstanding = 0;
                if (dbcon.dr.HasRows)
                {
                    while (dbcon.dr.Read())
                    {
                        paidamount =float.Parse( dbcon.dr["paidamount"].ToString());
                        outstanding = float.Parse(dbcon.dr["outstanding"].ToString());
                    }
                }
                dbcon.dr.Close();
                paidamount += payment.Paidamount;
                outstanding -= payment.Paidamount;
                command = "update billpaymentdetails set paidamount = '" + paidamount + "',outstanding = '" + outstanding+ "' where billid = " + payment.Billid + ";";
                dbcon.cmd.CommandText = command;
                dbcon.cmd.ExecuteNonQuery();
                Receipt receipt = new Receipt();
                receipt.Billid = payment.Billid;
                receipt.Outstanding = outstanding;
                receipt.Paidamount = payment.Paidamount;
                receipt.Transdate = usertransaction.Transdate;
                receipt.Transmonth = usertransaction.Transmonth;
                receipt.Transyear = usertransaction.Transyear;
                receipt.Userid = userid.Customerid;
                int lastreceiptid = 0;
                command = "select receiptid  from receiptid;";
                dbcon.cmd.CommandText = command;
                dbcon.dr = dbcon.cmd.ExecuteReader();
                if (dbcon.dr.HasRows)
                {
                    while (dbcon.dr.Read())
                    {
                        try
                        {
                            lastreceiptid = Int32.Parse(dbcon.dr["receiptid"].ToString());
                        }
                        catch (Exception e)
                        {
                        }
                    }
                }
                ++lastreceiptid;
                dbcon.dr.Close();
                //insert into receipt
                command = "insert into receipt (userid,billid,paidamount,outstanding,transdate,transmonth,transyear) values";
                command += "(" + receipt.Userid + "," + receipt.Billid + ",'" + receipt.Paidamount + "','" + receipt.Outstanding + "'," + receipt.Transdate + "," + receipt.Transmonth + "," + receipt.Transyear + ");";
                dbcon.cmd.CommandText = command;
                dbcon.cmd.ExecuteNonQuery();
                float useropeningbalance = 0;
                float adminopeningbalance = 0;
                command = "select last(closingbalance) as userclosing from usertransaction where userid = "+userid.Customerid+";";
                dbcon.cmd.CommandText = command;
                dbcon.dr = dbcon.cmd.ExecuteReader();
                if (dbcon.dr.HasRows)
                {
                    while (dbcon.dr.Read())
                    {
                         try
                        {
                        useropeningbalance = float.Parse(dbcon.dr["userclosing"].ToString());
                        }
                         catch (Exception e)
                         {
                         }
                    }
                }
                dbcon.dr.Close();
                command = "select last(closingbalance) as userclosing from admintransaction;";
                dbcon.cmd.CommandText = command;
                dbcon.dr = dbcon.cmd.ExecuteReader();
                if (dbcon.dr.HasRows)
                {
                    while (dbcon.dr.Read())
                    {
                        try
                        {
                            adminopeningbalance = float.Parse(dbcon.dr["userclosing"].ToString());
                        }
                        catch (Exception e)
                        {
                        }
                    }
                }
                dbcon.dr.Close();
                float userclosing = useropeningbalance + usertransaction.Credit;
                float adminclosing = adminopeningbalance + usertransaction.Credit;
                command = "insert into usertransaction (userid,credit,debit,transdate,billid,receiptid,transmonth,transyear,opbalance,closingbalance)";
                command += " values (" + usertransaction.Userid + ",'" + usertransaction.Credit + "','" + usertransaction.Debit + "',";
                command += "" + usertransaction.Transdate + "," + usertransaction.Billid + "," + lastreceiptid + "," + usertransaction.Transmonth + "," + usertransaction.Transyear + ",'" + useropeningbalance + "','" + userclosing + "');";
                dbcon.cmd.CommandText = command;
                dbcon.cmd.ExecuteNonQuery();
                command = "insert into admintransaction (opbalance,credit,debit,description,method,billid,receiptid,transdate,chequeno,accno,transmonth,transyear,closingbalance)";
                command += "values ('" + adminopeningbalance + "','" + admintransaction.Credit + "','" + admintransaction.Debit + "','" + admintransaction.Description + "',";
                command += "'" + admintransaction.Method + "','" + admintransaction.Billid + "','" + lastreceiptid.ToString() + "'," + admintransaction.Transdate + ",'" + admintransaction.Chequeno + "','" + admintransaction.Accno + "'," + admintransaction.Transmonth + "," + admintransaction.Transyear + ",'" + adminclosing + "');";
                dbcon.cmd.CommandText = command;
                dbcon.cmd.ExecuteNonQuery();
                //update lastreceiptid
                command = "update receiptid set receiptid = " + lastreceiptid + ";";
                dbcon.cmd.CommandText = command;
                dbcon.cmd.ExecuteNonQuery();
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
                    throw (em);
                }
                throw e;
            }
            finally
            {
                dbcon.con.Close();
            }
            return flag;
        }


        public bool refundBill(Bill bill)
        {
            //read paidamount,outstanding and totalamount
            //set bill status to refunded
            //insert into usertransaction as debit if any amount paid against this bill
            //insert into usertransaction as credit
            //if paid against the bill then insert debit into admin transaction
            bool flag = false;
            String command = "";
            try
            {
                dbcon.con.Open();
                transaction = dbcon.con.BeginTransaction();
                dbcon.cmd.Connection = dbcon.con;
                dbcon.cmd.Transaction = transaction;
                float paidamount = 0;
                float outstanding = 0;
                float finalamount = 0;
                command = "select * from billpaymentdetails where id = "+bill.Id+";";
                dbcon.cmd.CommandText = command;
                dbcon.dr =  dbcon.cmd.ExecuteReader();
                if (dbcon.dr.HasRows)
                {
                    while (dbcon.dr.Read())
                    {
                        finalamount = float.Parse(dbcon.dr["finalamount"].ToString());
                        outstanding = float.Parse(dbcon.dr["outstanding"].ToString());
                        paidamount = float.Parse(dbcon.dr["paidamount"].ToString());

                    }
                }
                dbcon.dr.Close();
                
                command = "update bill set status = 'refunded' where billid = "+bill.Id+";";
                dbcon.cmd.CommandText = command;
                dbcon.cmd.ExecuteNonQuery();
                AdminTransaction admintransaction = new AdminTransaction();
                admintransaction.Billid = bill.Id.ToString();
                admintransaction.Credit = 0;
                admintransaction.Debit = paidamount;
                admintransaction.Description = "REFUND";
                admintransaction.Method = "CASH";
                admintransaction.Transdate = createdate.createDate(DateTime.Today.ToShortDateString()) ;
                admintransaction.Transmonth = DateTime.Today.Month;
                admintransaction.Transyear = DateTime.Today.Year;
                UserTransaction usertransaction = new UserTransaction();
                usertransaction.Credit = finalamount;
                usertransaction.Billid = bill.Id;
                usertransaction.Userid = bill.Customer.Customerid;
                usertransaction.Transdate = createdate.createDate(DateTime.Today.ToShortDateString());


                usertransaction.Transmonth = DateTime.Today.Month;
                usertransaction.Transyear = DateTime.Today.Year;
                float useropeningbalance = 0;
                float adminopeningbalance = 0;
                command = "select last(closingbalance) as userclosing from usertransaction where userid = "+bill.Customer.Customerid+";";
                dbcon.cmd.CommandText = command;
                dbcon.dr = dbcon.cmd.ExecuteReader();
                if (dbcon.dr.HasRows)
                {
                    while (dbcon.dr.Read())
                    {
                        try
                        {
                            useropeningbalance = float.Parse(dbcon.dr["userclosing"].ToString());
                        }
                        catch (Exception e)
                        {
                        }
                    }
                }
                dbcon.dr.Close();
                
                float userclosing = useropeningbalance + usertransaction.Credit;
                
                
                
                if (paidamount != 0)
                {
                    command = "select last(closingbalance) as userclosing from admintransaction;";
                    dbcon.cmd.CommandText = command;
                    dbcon.dr = dbcon.cmd.ExecuteReader();
                    if (dbcon.dr.HasRows)
                    {
                        while (dbcon.dr.Read())
                        {
                            try
                            {
                                adminopeningbalance = float.Parse(dbcon.dr["userclosing"].ToString());
                            }
                            catch (Exception e)
                            {
                            }
                        }
                    }
                    dbcon.dr.Close();
                    float adminclosing = adminopeningbalance - paidamount;
                    command = "insert into admintransaction (opbalance,credit,debit,description,method,billid,transdate,chequeno,accno,transmonth,transyear,closingbalance)";
                    command += "values ('" + adminopeningbalance + "','" + admintransaction.Credit + "','" + admintransaction.Debit + "','" + admintransaction.Description + "',";
                    command += "'" + admintransaction.Method + "','" + admintransaction.Billid + "'," + admintransaction.Transdate + ",'" + admintransaction.Chequeno + "','" + admintransaction.Accno + "'," + admintransaction.Transmonth + "," + admintransaction.Transyear + ",'" + adminclosing + "');";
                    dbcon.cmd.CommandText = command;
                    dbcon.cmd.ExecuteNonQuery();
                    useropeningbalance = userclosing;
                    userclosing = useropeningbalance - paidamount;
                    usertransaction.Debit = paidamount;
                    usertransaction.Credit = 0;
                    command = "insert into usertransaction (userid,credit,debit,transdate,billid,transmonth,transyear,opbalance,closingbalance)";
                    command += " values (" + usertransaction.Userid + ",'" + usertransaction.Credit + "','" + usertransaction.Debit + "',";
                    command += "" + usertransaction.Transdate + "," + usertransaction.Billid + "," + usertransaction.Transmonth + "," + usertransaction.Transyear + ",'" + useropeningbalance + "','" + userclosing + "');";
                    dbcon.cmd.ExecuteNonQuery();

                }
                flag = true;
                transaction.Commit();
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
                throw e;
            }
            finally
            {
                dbcon.con.Close();
            }
            return flag;
        }

    }
}
