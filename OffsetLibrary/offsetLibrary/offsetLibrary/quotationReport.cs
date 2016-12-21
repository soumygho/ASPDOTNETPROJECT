using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace offsetLibrary
{
   public class quotationReport
    {
       private DatabaseOperation dbops = null;
        public DbConnection dbcon = null;
        private CreateDateClass createdate = null;
        public quotationReport()
        {
            dbops = new DatabaseOperation();
            dbcon = new DbConnection();
            createdate = new CreateDateClass();
        }

       
        //get only non-onspot bills

        public DataTable generateTableForQuotation(List<Quotation> bills)
        {
            DataTable data = null;

            if (bills!=null&&bills.Count>0)
            {
                data = new DataTable();
                DataColumn col = new DataColumn("QUOTATION ID");
                data.Clear();
                data.Columns.Add(col);
                col = new DataColumn("CUSTOMER NAME");
                data.Columns.Add(col);
                col = new DataColumn("DATE");
                data.Columns.Add(col);
                col = new DataColumn("TOTAL AMOUNT");
                data.Columns.Add(col);
                
                
                for (int i = 0; i < bills.Count; i++)
                {
                    DataRow dr = data.NewRow();
                    dr["QUOTATION ID"] = bills[i].Id;
                    dr["DATE"] = bills[i].Quotedate;
                    dr["TOTAL AMOUNT"] = bills[i].Totalamount;
                    dr["CUSTOMER NAME"] = bills[i].Customer.Customername;
                    
                    data.Rows.Add(dr);
                }
            }
            return data;
        }

        public List<Quotation> readQuotation()
        {
            List<Quotation> bills = null;
            try
            {
                dbops.getConnection();
                string command = "select quotation.*,customerdetails.custname from quotation,customerdetails where  customerdetails.id = quotation.userid;";

                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Quotation>();
                    Quotation bill = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        bill = new Quotation();
                        bill.Quotedate = dbops.dbcon.dr["quotedate"].ToString();
                        bill.Id = Int32.Parse(dbops.dbcon.dr["quoteid"].ToString());
                        bill.Totalamount = float.Parse(dbops.dbcon.dr["totalamount"].ToString());
                        
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
        public List<Quotation> readQuotation(int quoteid)
        {
            List<Quotation> bills = null;
            try
            {
                dbops.getConnection();
                string command = "select quotation.*,customerdetails.custname from quotation,customerdetails where  customerdetails.id = quotation.userid and quotation.quoteid = "+quoteid+";";

                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Quotation>();
                    Quotation bill = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        bill = new Quotation();
                        bill.Quotedate = dbops.dbcon.dr["quotedate"].ToString();
                        bill.Id = Int32.Parse(dbops.dbcon.dr["quoteid"].ToString());
                        bill.Totalamount = float.Parse(dbops.dbcon.dr["totalamount"].ToString());

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
        public List<Quotation> readQuotationByMonth(int month)
        {
            List<Quotation> bills = null;
            try
            {
                dbops.getConnection();
                string command = "select quotation.*,customerdetails.custname from quotation,customerdetails where customerdetails.id = quotation.userid and quotation.transmonth = " + month + ";";

                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Quotation>();
                    Quotation bill = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        bill = new Quotation();
                        bill.Quotedate = dbops.dbcon.dr["quotedate"].ToString();
                        bill.Id = Int32.Parse(dbops.dbcon.dr["quoteid"].ToString());
                        bill.Totalamount = float.Parse(dbops.dbcon.dr["totalamount"].ToString());

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
        public List<Quotation> readQuotationByYear(int year)
        {
            List<Quotation> bills = null;
            try
            {
                dbops.getConnection();
                string command = "select quotation.*,customerdetails.custname from quotation,customerdetails where  customerdetails.id = quotation.userid and quotation.transyear = " + year + ";";

                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Quotation>();
                    Quotation bill = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        bill = new Quotation();
                        bill.Quotedate = dbops.dbcon.dr["quotedate"].ToString();
                        bill.Id = Int32.Parse(dbops.dbcon.dr["quoteid"].ToString());
                        bill.Totalamount = float.Parse(dbops.dbcon.dr["totalamount"].ToString());

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
        public List<Quotation> readQuotationByUser(int userid)
        {
            List<Quotation> bills = null;
            try
            {
                dbops.getConnection();
                string command = "select quotation.*,customerdetails.custname from quotation,customerdetails where  customerdetails.id = quotation.userid and quotation.userid = " + userid + ";";

                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Quotation>();
                    Quotation bill = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        bill = new Quotation();
                        bill.Quotedate = dbops.dbcon.dr["quotedate"].ToString();
                        bill.Id = Int32.Parse(dbops.dbcon.dr["quoteid"].ToString());
                        bill.Totalamount = float.Parse(dbops.dbcon.dr["totalamount"].ToString());

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
        public List<Quotation> readQuotationByDate(string date)
        {
            List<Quotation> bills = null;
            try
            {
                date = createdate.createDate(date);
                dbops.getConnection();
                string command = "select quotation.*,customerdetails.custname from quotation,customerdetails where  customerdetails.id = quotation.userid and quotation.quotedate = " + date + ";";

                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Quotation>();
                    Quotation bill = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        bill = new Quotation();
                        bill.Quotedate = dbops.dbcon.dr["quotedate"].ToString();
                        bill.Id = Int32.Parse(dbops.dbcon.dr["quoteid"].ToString());
                        bill.Totalamount = float.Parse(dbops.dbcon.dr["totalamount"].ToString());

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
    }
}
