using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace offsetLibrary
{
   public class ReceiptOperation
    {
        private DatabaseOperation dbops = null;
        public ReceiptOperation()
        {
            dbops = new DatabaseOperation();
        }

        public List<Receipt> readReceipt(Bill bill)
        {
            bool flag = false;
            List<Receipt> dtps = null;
            try
            {
                dbops.getConnection();
                string command = "select * from receipt where  billid = "+bill.Id+" ;";
                dbops.executeReader(command);
                if (dbops.dbcon.dr != null)
                {
                    dtps = new List<Receipt>();
                    while (dbops.dbcon.dr.Read())
                    {
                        Receipt dtp = new Receipt();
                        dtp.Userid = Int32.Parse(dbops.dbcon.dr["userid"].ToString());
                        dtp.Billid =Int32.Parse( dbops.dbcon.dr["billid"].ToString());
                        dtp.Paidamount = float.Parse(dbops.dbcon.dr["paidamount"].ToString());
                        dtp.Outstanding = float.Parse(dbops.dbcon.dr["outstanding"].ToString());
                        dtp.Transdate = dbops.dbcon.dr["transdate"].ToString();
                        dtp.Transmonth = Int32.Parse(dbops.dbcon.dr["transmonth"].ToString());
                        dtp.Transyear = Int32.Parse(dbops.dbcon.dr["transyear"].ToString());
                        dtp.Id = Int32.Parse(dbops.dbcon.dr["receiptid"].ToString());
                        dtps.Add(dtp);
                    }
                }


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
            return dtps;
        }
        public List<Receipt> readReceipt(int receiptid)
        {
            bool flag = false;
            List<Receipt> dtps = null;
            try
            {
                dbops.getConnection();
                string command = "select * from receipt where receiptid = " + receiptid + " ;";
                dbops.executeReader(command);
                if (dbops.dbcon.dr != null)
                {
                    dtps = new List<Receipt>();
                    while (dbops.dbcon.dr.Read())
                    {
                        Receipt dtp = new Receipt();
                        dtp.Userid = Int32.Parse(dbops.dbcon.dr["userid"].ToString());
                        dtp.Billid = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        dtp.Paidamount = float.Parse(dbops.dbcon.dr["paidamount"].ToString());
                        dtp.Outstanding = float.Parse(dbops.dbcon.dr["outstanding"].ToString());
                        dtp.Transdate = dbops.dbcon.dr["transdate"].ToString();
                        dtp.Transmonth = Int32.Parse(dbops.dbcon.dr["transmonth"].ToString());
                        dtp.Transyear = Int32.Parse(dbops.dbcon.dr["transyear"].ToString());
                        dtp.Id = Int32.Parse(dbops.dbcon.dr["receiptid"].ToString());
                        dtps.Add(dtp);
                    }
                }


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
            return dtps;
        }
        public DataTable generateTable(List<Receipt> dtps)
        {
            DataTable table = null;
            if (dtps != null && dtps.Count > 0)
            {
                table = new DataTable();
                DataColumn col = new DataColumn("Paid Amount");
                table.Columns.Add(col);

                col = new DataColumn("Outstanding");
                table.Columns.Add(col);
                col = new DataColumn("Date");
                table.Columns.Add(col);
                for (int i = 0; i < dtps.Count; i++)
                {
                    DataRow row = table.NewRow();
                    row["Paid Amount"] = dtps[i].Paidamount;

                    row["Outstanding"] = dtps[i].Outstanding;
                    row["Date"] = dtps[i].Transdate;
                    table.Rows.Add(row);
                }

            }
            return table;
        }
    }
}
