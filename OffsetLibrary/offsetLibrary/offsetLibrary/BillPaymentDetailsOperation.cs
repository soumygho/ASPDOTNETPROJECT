using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace offsetLibrary
{
    public class BillPaymentDetailsOperation
    {
        private DatabaseOperation dbops = null;
        public BillPaymentDetailsOperation()
        {
            dbops = new DatabaseOperation();
        }

        public bool insertIntoBillpaymentDetails(BillPaymentDetails payment)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "insert into billpaymentdetails (billid,finalamount,paidamount,outstanding)";
                command += "values ('" + payment.Billid + "','" + payment.Finalamount + "','" + payment.Paidamount + "','" + payment.Outstanding + "'";
                command += "');";
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


        public bool updateBillpaymentdetails(BillPaymentDetails payment)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "update billpaymentdetails set billid = '" + payment.Billid + "' , finalamount = '" + payment.Finalamount + "' , paidamount = '" + payment.Paidamount + "'";
                command += ",outstanding = '" + payment.Outstanding + "' where id = "+payment.Id+";";
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

        public BillPaymentDetails readPaymentDetails(int billid)
        {
            BillPaymentDetails payment = null;
            try
            {
                dbops.getConnection();
                string command = "select * from billpaymentdetails where billid = "+billid;
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    payment = new BillPaymentDetails();
                    while (dbops.dbcon.dr.Read())
                    {
                        payment.Billid = billid;
                        payment.Paidamount = float.Parse(dbops.dbcon.dr["paidamount"].ToString());
                        payment.Outstanding = float.Parse(dbops.dbcon.dr["outstanding"].ToString());
                        payment.Finalamount = float.Parse(dbops.dbcon.dr["finalamount"].ToString());
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
            return payment;
        }
        public DataTable generatePaymentDetailstable(List<BillPaymentDetails> payments)
        {
            DataTable data = null;

            if (payments != null && payments.Count > 0)
            {
                data = new DataTable();
                DataColumn col = new DataColumn("BILL ID");
                data.Clear();
                data.Columns.Add(col);
                col = new DataColumn("PAIDAMOUNT");
                data.Columns.Add(col);
                col = new DataColumn("OUTSTANDING");
                data.Columns.Add(col);
                col = new DataColumn("FINALAMOUNT");
                data.Columns.Add(col);
               
                

                for (int i = 0; i < payments.Count; i++)
                {
                    DataRow dr = data.NewRow();
                    dr["BILL ID"] = payments[i].Billid;
                    dr["PAIDAMOUNT"] = payments[i].Paidamount;
                    dr["OUTSTANDING"] = payments[i].Outstanding;
                    dr["FINALAMOUNT"] = payments[i].Finalamount;
                    
                    data.Rows.Add(dr);
                }
            }
            return data;
        }

        }
        
    }

