using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace offsetLibrary
{
    public class SellReport
    {
        private DatabaseOperation dbops = null;
        public DbConnection dbcon = null;
        private CreateDateClass createdate = null;
        public SellReport()
        {
            dbops = new DatabaseOperation();
            dbcon = new DbConnection();
            createdate = new CreateDateClass();
        }

        //get only onspot bills
        public List<Bill> readOnspotBill()
        {
            List<Bill> bills = null;
            try
            {
                dbops.getConnection();
                string command = "select * from bill where userid = 0 and status IS NULL;";

                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Bill>();
                    Bill bill = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        bill = new Bill();
                        bill.Billdate = dbops.dbcon.dr["billdate"].ToString();
                        try
                        {
                            bill.Id = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        }
                        catch (Exception m)
                        {
                            bill.Id = 0;
                        }
                        bill.Totalamount = float.Parse(dbops.dbcon.dr["totalamount"].ToString());
                        bill.Cons = float.Parse(dbops.dbcon.dr["cons"].ToString());
                        bill.Finalamount = float.Parse(dbops.dbcon.dr["finalamount"].ToString());
                        bills.Add(bill);
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
            return bills;
        }
        public List<Bill> readOnspotBillByMonth(int month)
        {
            List<Bill> bills = null;
            try
            {
                dbops.getConnection();
                string command = "select * from bill where userid = 0 and status IS NULL and transmonth = "+month+";";

                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Bill>();
                    Bill bill = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        bill = new Bill();
                        bill.Billdate = dbops.dbcon.dr["billdate"].ToString();
                        try
                        {
                            bill.Id = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        }
                        catch (Exception m)
                        {
                            bill.Id = 0;
                        }
                        bill.Totalamount = float.Parse(dbops.dbcon.dr["totalamount"].ToString());
                        bill.Cons = float.Parse(dbops.dbcon.dr["cons"].ToString());
                        bill.Finalamount = float.Parse(dbops.dbcon.dr["finalamount"].ToString());
                        bills.Add(bill);
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
            return bills;
        }
        public List<Bill> readOnspotBillByYear(int year)
        {
            List<Bill> bills = null;
            try
            {
                dbops.getConnection();
                string command = "select * from bill where userid = 0 and status IS NULL and transyear = " + year + ";";

                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Bill>();
                    Bill bill = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        bill = new Bill();
                        bill.Billdate = dbops.dbcon.dr["billdate"].ToString();
                        try
                        {
                            bill.Id = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        }
                        catch (Exception m)
                        {
                            bill.Id = 0;
                        }
                        bill.Totalamount = float.Parse(dbops.dbcon.dr["totalamount"].ToString());
                        bill.Cons = float.Parse(dbops.dbcon.dr["cons"].ToString());
                        bill.Finalamount = float.Parse(dbops.dbcon.dr["finalamount"].ToString());
                        bills.Add(bill);
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
            return bills;
        }
        public List<Bill> readOnspotBillByDate(String date)
        {
            List<Bill> bills = null;
            try
            {
                dbops.getConnection();
                date = createdate.createDate(date);
                string command = "select * from bill where userid = 0 and status IS NULL and billdate = " + date + ";";

                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Bill>();
                    Bill bill = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        bill = new Bill();
                        bill.Billdate = dbops.dbcon.dr["billdate"].ToString();
                        try
                        {
                            bill.Id = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        }
                        catch (Exception m)
                        {
                            bill.Id = 0;
                        }
                        bill.Totalamount = float.Parse(dbops.dbcon.dr["totalamount"].ToString());
                        bill.Cons = float.Parse(dbops.dbcon.dr["cons"].ToString());
                        bill.Finalamount = float.Parse(dbops.dbcon.dr["finalamount"].ToString());
                        bills.Add(bill);
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
            return bills;
        }
        //get only non-onspot bills

        public DataTable generateTableForOnspotBill(List<Bill> bills)
        {
            DataTable data = null;

            if (bills!=null&&bills.Count>0)
            {
                data = new DataTable();
                DataColumn col = new DataColumn("BILL ID");
                data.Clear();
                data.Columns.Add(col);
                col = new DataColumn("DATE");
                data.Columns.Add(col);
                col = new DataColumn("TOTAL AMOUNT");
                data.Columns.Add(col);
                col = new DataColumn("CONS");
                data.Columns.Add(col);
                col = new DataColumn("FINAL AMOUNT");
                data.Columns.Add(col);
                
                for (int i = 0; i < bills.Count; i++)
                {
                    DataRow dr = data.NewRow();
                    dr["BILL ID"] = bills[i].Id;
                    dr["DATE"] = bills[i].Billdate;
                    dr["TOTAL AMOUNT"] = bills[i].Totalamount;
                    dr["CONS"] = bills[i].Cons;
                    dr["FINAL AMOUNT"] = bills[i].Finalamount;
                    data.Rows.Add(dr);
                }
            }
            return data;
        }

        public List<Bill> readNonOnspotBill()
        {
            List<Bill> bills = null;
            try
            {
                dbops.getConnection();
                string command = "select bill.*,customerdetails.custname from bill,customerdetails where bill.userid <> 0 and bill.status IS NULL and customerdetails.id = bill.userid;";

                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Bill>();
                    Bill bill = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        bill = new Bill();
                        bill.Billdate = dbops.dbcon.dr["billdate"].ToString();
                        bill.Id = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        bill.Totalamount = float.Parse(dbops.dbcon.dr["totalamount"].ToString());
                        bill.Cons = float.Parse(dbops.dbcon.dr["cons"].ToString());
                        bill.Finalamount = float.Parse(dbops.dbcon.dr["finalamount"].ToString());
                        bill.Customer = new CustomerDetails();
                        bill.Customer.Customername = dbops.dbcon.dr["custname"].ToString();
                        bills.Add(bill);
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
            return bills;
        }
        public List<Bill> readNonOnspotBillByBillid(int billid)
        {
            List<Bill> bills = null;
            try
            {
                dbops.getConnection();
                string command = "select bill.*,customerdetails.custname from bill,customerdetails where bill.userid <> 0 and bill.status IS NULL and customerdetails.id = bill.userid and bill.billid = "+billid+";";

                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Bill>();
                    Bill bill = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        bill = new Bill();
                        bill.Billdate = dbops.dbcon.dr["billdate"].ToString();
                        bill.Id = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        bill.Totalamount = float.Parse(dbops.dbcon.dr["totalamount"].ToString());
                        bill.Cons = float.Parse(dbops.dbcon.dr["cons"].ToString());
                        bill.Finalamount = float.Parse(dbops.dbcon.dr["finalamount"].ToString());
                        bill.Customer = new CustomerDetails();
                        bill.Customer.Customername = dbops.dbcon.dr["custname"].ToString();
                        bills.Add(bill);
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
            return bills;
        }
        public List<Bill> readNonOnspotBillByMonth(int month)
        {
            List<Bill> bills = null;
            try
            {
                dbops.getConnection();
                string command = "select bill.*,customerdetails.custname from bill,customerdetails where bill.userid <> 0 and bill.status IS NULL and customerdetails.id = bill.userid and transmonth = "+month+";";

                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Bill>();
                    Bill bill = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        bill = new Bill();
                        bill.Billdate = dbops.dbcon.dr["billdate"].ToString();
                        bill.Id = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        bill.Totalamount = float.Parse(dbops.dbcon.dr["totalamount"].ToString());
                        bill.Cons = float.Parse(dbops.dbcon.dr["cons"].ToString());
                        bill.Finalamount = float.Parse(dbops.dbcon.dr["finalamount"].ToString());
                        bill.Customer = new CustomerDetails();
                        bill.Customer.Customername = dbops.dbcon.dr["custname"].ToString();
                        bills.Add(bill);
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
            return bills;
        }
        public List<Bill> readNonOnspotBillByDate(String date)
        {
            List<Bill> bills = null;
            try
            {
                date = createdate.createDate(date);
                dbops.getConnection();
                string command = "select bill.*,customerdetails.custname from bill,customerdetails where bill.userid <> 0 and bill.status IS NULL and customerdetails.id = bill.userid and billdate = " + date + ";";

                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Bill>();
                    Bill bill = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        bill = new Bill();
                        bill.Billdate = dbops.dbcon.dr["billdate"].ToString();
                        bill.Id = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        bill.Totalamount = float.Parse(dbops.dbcon.dr["totalamount"].ToString());
                        bill.Cons = float.Parse(dbops.dbcon.dr["cons"].ToString());
                        bill.Finalamount = float.Parse(dbops.dbcon.dr["finalamount"].ToString());
                        bill.Customer = new CustomerDetails();
                        bill.Customer.Customername = dbops.dbcon.dr["custname"].ToString();
                        bills.Add(bill);
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
            return bills;
        }
        public List<Bill> readNonOnspotBillByYear(int year)
        {
            List<Bill> bills = null;
            try
            {
                dbops.getConnection();
                string command = "select bill.*,customerdetails.custname from bill,customerdetails where bill.userid <> 0 and bill.status IS NULL and customerdetails.id = bill.userid and transyear = " + year + ";";

                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Bill>();
                    Bill bill = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        bill = new Bill();
                        bill.Billdate = dbops.dbcon.dr["billdate"].ToString();
                        bill.Id = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        bill.Totalamount = float.Parse(dbops.dbcon.dr["totalamount"].ToString());
                        bill.Cons = float.Parse(dbops.dbcon.dr["cons"].ToString());
                        bill.Finalamount = float.Parse(dbops.dbcon.dr["finalamount"].ToString());
                        bill.Customer = new CustomerDetails();
                        bill.Customer.Customername = dbops.dbcon.dr["custname"].ToString();
                        bills.Add(bill);
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
            return bills;
        }
    
    public List<Bill> readNonOnspotBill(CustomerDetails customer)
        {
            List<Bill> bills = null;
            try
            {
                dbops.getConnection();
                string command = "select bill.*,customerdetails.custname from bill,customerdetails where bill.userid <> 0 and bill.status IS NULL and bill.userid = " + customer.Customerid + " and customerdetails.id = bill.userid ;";

                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Bill>();
                    Bill bill = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        bill = new Bill();
                        bill.Billdate = dbops.dbcon.dr["billdate"].ToString();
                        bill.Id = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        bill.Totalamount = float.Parse(dbops.dbcon.dr["totalamount"].ToString());
                        bill.Cons = float.Parse(dbops.dbcon.dr["cons"].ToString());
                        bill.Finalamount = float.Parse(dbops.dbcon.dr["finalamount"].ToString());
                        bill.Customer = new CustomerDetails();
                        bill.Customer.Customername = dbops.dbcon.dr["custname"].ToString();
                        bills.Add(bill);
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
            return bills;
        }
    public List<Bill> readBill(int billid)
    {
        List<Bill> bills = null;
        try
        {
            dbops.getConnection();
            string command = "select * from bill where billid = "+billid+";";

            dbops.executeReader(command);
            if (dbops.dbcon.dr.HasRows)
            {
                bills = new List<Bill>();
                Bill bill = null;
                while (dbops.dbcon.dr.Read())
                {
                    bill = new Bill();
                    bill.Billdate = dbops.dbcon.dr["billdate"].ToString();
                    try
                    {
                        bill.Id = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                    }
                    catch (Exception m)
                    {
                        bill.Id = 0;
                    }
                    bill.Totalamount = float.Parse(dbops.dbcon.dr["totalamount"].ToString());
                    bill.Cons = float.Parse(dbops.dbcon.dr["cons"].ToString());
                    bill.Finalamount = float.Parse(dbops.dbcon.dr["finalamount"].ToString());
                    bills.Add(bill);
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
        return bills;
    }
    public DataTable generateTableForNOnOnspotBill(List<Bill> bills)
    {
        DataTable data = null;

        if (bills != null && bills.Count > 0)
        {
            data = new DataTable();
            DataColumn col = new DataColumn("BILL ID");
            data.Clear();
            data.Columns.Add(col);
            col = new DataColumn("NAME");
            data.Columns.Add(col);
            col = new DataColumn("DATE");
            data.Columns.Add(col);
            col = new DataColumn("TOTAL AMOUNT");
            data.Columns.Add(col);
            col = new DataColumn("CONS");
            data.Columns.Add(col);
            col = new DataColumn("FINAL AMOUNT");
            data.Columns.Add(col);

            for (int i = 0; i < bills.Count; i++)
            {
                DataRow dr = data.NewRow();
                dr["NAME"] = bills[i].Customer.Customername;
                dr["BILL ID"] = bills[i].Id;
                dr["DATE"] = bills[i].Billdate;
                dr["TOTAL AMOUNT"] = bills[i].Totalamount;
                dr["CONS"] = bills[i].Cons;
                dr["FINAL AMOUNT"] = bills[i].Finalamount;
                data.Rows.Add(dr);
            }
        }
        return data;
    }
    }
}
