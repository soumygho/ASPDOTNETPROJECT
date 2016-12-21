using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace offsetLibrary
{
   public class ProfitReport
    {
        private DatabaseOperation dbops = null;
        public DbConnection dbcon = null;
        private CreateDateClass createdate = null;
        public ProfitReport()
        {
            dbops = new DatabaseOperation();
            dbcon = new DbConnection();
            createdate = new CreateDateClass();
        }

        public List<Bill> getProfitList()
        {
            List<Bill> bills = null;
            try
            {
                dbops.getConnection();
                string command = "select bill.billid,bill.billdate,billpaymentdetails.finalamount,billpaymentdetails.paidamount,billpaymentdetails.outstanding,profittable.profit,profittable.loss,profittable.actualcost from bill,billpaymentdetails,profittable where bill.billid = profittable.billid and bill.billid = billpaymentdetails.billid;";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Bill>();
                    while (dbops.dbcon.dr.Read())
                    {
                        Bill bill = new Bill();
                        BillPaymentDetails payment = new BillPaymentDetails();
                        ProfitTable profit = new ProfitTable();
                        payment.Finalamount = float.Parse(dbops.dbcon.dr["finalamount"].ToString());
                        payment.Paidamount = float.Parse(dbops.dbcon.dr["paidamount"].ToString());
                        payment.Outstanding = float.Parse(dbops.dbcon.dr["outstanding"].ToString());
                        bill.Payment = payment;
                        profit.Profit = float.Parse(dbops.dbcon.dr["profit"].ToString());
                        profit.Loss = float.Parse(dbops.dbcon.dr["loss"].ToString());
                        profit.Actualcost = float.Parse(dbops.dbcon.dr["actualcost"].ToString());
                        bill.Profit = profit;
                        bill.Billdate = dbops.dbcon.dr["billdate"].ToString();
                        bill.Id = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
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

        public List<Bill> getProfitListFilterByMonth(int month)
        {
            List<Bill> bills = null;
            try
            {
                dbops.getConnection();
                string command = "select bill.billid,bill.billdate,billpaymentdetails.finalamount,billpaymentdetails.paidamount,billpaymentdetails.outstanding,profittable.profit,profittable.loss,profittable.actualcost from bill,billpaymentdetails,profittable where bill.billid = profittable.billid and bill.billid = billpaymentdetails.billid and bill.transmonth = " + month + ";";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Bill>();
                    while (dbops.dbcon.dr.Read())
                    {
                        Bill bill = new Bill();
                        BillPaymentDetails payment = new BillPaymentDetails();
                        ProfitTable profit = new ProfitTable();
                        payment.Finalamount = float.Parse(dbops.dbcon.dr["finalamount"].ToString());
                        payment.Paidamount = float.Parse(dbops.dbcon.dr["paidamount"].ToString());
                        payment.Outstanding = float.Parse(dbops.dbcon.dr["outstanding"].ToString());
                        bill.Payment = payment;
                        profit.Profit = float.Parse(dbops.dbcon.dr["profit"].ToString());
                        profit.Loss = float.Parse(dbops.dbcon.dr["loss"].ToString());
                        profit.Actualcost = float.Parse(dbops.dbcon.dr["actualcost"].ToString());
                        bill.Profit = profit;
                        bill.Billdate = dbops.dbcon.dr["billdate"].ToString();
                        bill.Id = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
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
        public List<Bill> getProfitListByYear(int year)
        {
            List<Bill> bills = null;
            try
            {
                dbops.getConnection();
                string command = "select bill.billid,bill.billdate,billpaymentdetails.finalamount,billpaymentdetails.paidamount,billpaymentdetails.outstanding,profittable.profit,profittable.loss,profittable.actualcost from bill,billpaymentdetails,profittable where bill.billid = profittable.billid and bill.billid = billpaymentdetails.billid and bill.transyear = " + year + ";";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Bill>();
                    while (dbops.dbcon.dr.Read())
                    {
                        Bill bill = new Bill();
                        BillPaymentDetails payment = new BillPaymentDetails();
                        ProfitTable profit = new ProfitTable();
                        payment.Finalamount = float.Parse(dbops.dbcon.dr["finalamount"].ToString());
                        payment.Paidamount = float.Parse(dbops.dbcon.dr["paidamount"].ToString());
                        payment.Outstanding = float.Parse(dbops.dbcon.dr["outstanding"].ToString());
                        bill.Payment = payment;
                        profit.Profit = float.Parse(dbops.dbcon.dr["profit"].ToString());
                        profit.Loss = float.Parse(dbops.dbcon.dr["loss"].ToString());
                        profit.Actualcost = float.Parse(dbops.dbcon.dr["actualcost"].ToString());
                        bill.Profit = profit;
                        bill.Billdate = dbops.dbcon.dr["billdate"].ToString();
                        bill.Id = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
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
        public List<Bill> getProfitListByDate(string date)
        {
            List<Bill> bills = null;
            try
            {
                date = createdate.createDate(date);
                dbops.getConnection();
                string command = "select bill.billid,bill.billdate,billpaymentdetails.finalamount,billpaymentdetails.paidamount,billpaymentdetails.outstanding,profittable.profit,profittable.loss,profittable.actualcost from bill,billpaymentdetails,profittable where bill.billid = profittable.billid and bill.billid = billpaymentdetails.billid and bill.billdate = "+date+";";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    bills = new List<Bill>();
                    while (dbops.dbcon.dr.Read())
                    {
                        Bill bill = new Bill();
                        BillPaymentDetails payment = new BillPaymentDetails();
                        ProfitTable profit = new ProfitTable();
                        payment.Finalamount = float.Parse(dbops.dbcon.dr["finalamount"].ToString());
                        payment.Paidamount = float.Parse(dbops.dbcon.dr["paidamount"].ToString());
                        payment.Outstanding = float.Parse(dbops.dbcon.dr["outstanding"].ToString());
                        bill.Payment = payment;
                        profit.Profit = float.Parse(dbops.dbcon.dr["profit"].ToString());
                        profit.Loss = float.Parse(dbops.dbcon.dr["loss"].ToString());
                        profit.Actualcost = float.Parse(dbops.dbcon.dr["actualcost"].ToString());
                        bill.Profit = profit;
                        bill.Billdate = dbops.dbcon.dr["billdate"].ToString();
                        bill.Id = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
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
        public DataTable generateTable(List<Bill> bills)
        {
            DataTable data = null;

            if (bills != null && bills.Count > 0)
            {
                data = new DataTable();
                DataColumn col = new DataColumn("BILL ID");
                data.Clear();
                data.Columns.Add(col);
                col = new DataColumn("BILLDATE");
                data.Columns.Add(col);
                col = new DataColumn("FINALAMOUNT");
                data.Columns.Add(col);
                col = new DataColumn("PAIDAMOUNT");
                data.Columns.Add(col);
                col = new DataColumn("OUTSTANDING");
                data.Columns.Add(col);
                col = new DataColumn("PROFIT");
                data.Columns.Add(col);
                col = new DataColumn("LOSS");
                data.Columns.Add(col);
                col = new DataColumn("ACTUALCOST");
                data.Columns.Add(col);
                

                for (int i = 0; i < bills.Count; i++)
                {
                    DataRow dr = data.NewRow();
                    dr["BILL ID"] = bills[i].Id;
                    dr["BILLDATE"] = bills[i].Billdate;
                    dr["FINALAMOUNT"] = bills[i].Payment.Finalamount;
                    dr["PAIDAMOUNT"] = bills[i].Payment.Paidamount;
                    dr["ACTUALCOST"] = bills[i].Profit.Actualcost;
                    dr["LOSS"] = bills[i].Profit.Loss;
                    dr["OUTSTANDING"] = bills[i].Payment.Outstanding;
                    dr["PROFIT"] = bills[i].Profit.Profit;
                    
                    data.Rows.Add(dr);
                }
            }
            return data;
        }
    }
}
