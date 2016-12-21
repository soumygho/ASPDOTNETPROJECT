using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace offsetLibrary
{
   public class OrderDetailsReport
    {
        private DatabaseOperation dbops = null;
        public DbConnection dbcon = null;
        private CreateDateClass createdate = null;
        public OrderDetailsReport()
        {
            dbops = new DatabaseOperation();
            dbcon = new DbConnection();
            createdate = new CreateDateClass();
        }
        public List<OrderDetails> getOrdersForBill(Bill bill)
        {
            List<OrderDetails> orders = null;
            try
            {
                dbops.getConnection();
                string command = "select * from orderdetails where billid = "+bill.Id;
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    orders = new List<OrderDetails>();
                    OrderDetails order = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        order = new OrderDetails();
                        order.Billid = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        order.Description = dbops.dbcon.dr["description"].ToString();
                        order.Color = dbops.dbcon.dr["color"].ToString();
                        order.Printside = dbops.dbcon.dr["printside"].ToString();
                        order.Flexsize = dbops.dbcon.dr["flexsize"].ToString();
                        order.Stampmodelno = dbops.dbcon.dr["stampmodelno"].ToString();
                        order.Papername = dbops.dbcon.dr["paper"].ToString();
                        order.Size = dbops.dbcon.dr["size"].ToString();
                        order.Qty = Int32.Parse(dbops.dbcon.dr["qty"].ToString());
                        order.Id = Int32.Parse(dbops.dbcon.dr["orderid"].ToString());
                        orders.Add(order);
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
            return orders;
        }

        public List<CostTable> getCostTable(List<OrderDetails> order)
        {
            List<CostTable> costs = null;
            try
            {
                dbops.getConnection();
                if (order != null && order.Count > 0)
                {
                    costs = new List<CostTable>();
                    CostTable cost = null;
                    for (int i = 0; i < order.Count; i++)
                    {
                        string command = "select * from costtable where orderid = "+order[i].Id;
                        dbops.executeReader(command);
                        if (dbops.dbcon.dr.HasRows)
                        {
                            while (dbops.dbcon.dr.Read())
                            {
                                cost = new CostTable();
                                cost.Orderid = order[i].Id;
                                cost.Pagecost = float.Parse(dbops.dbcon.dr["pagecost"].ToString());
                                cost.Colorcost = float.Parse(dbops.dbcon.dr["colorcost"].ToString());
                                cost.Bindingcost = float.Parse(dbops.dbcon.dr["bindingcost"].ToString());
                                cost.Dtpcost = float.Parse(dbops.dbcon.dr["dtpcost"].ToString());
                                cost.Deliverycost = float.Parse(dbops.dbcon.dr["deliverycost"].ToString());
                                cost.Additionalprofit = float.Parse(dbops.dbcon.dr["additionalprofit"].ToString());
                                cost.Printcost = float.Parse(dbops.dbcon.dr["printcost"].ToString());
                                cost.Totalcost = float.Parse(dbops.dbcon.dr["totalcost"].ToString());
                                order[i].Cost = cost;
                                costs.Add(cost);
                            }
                        }
                        dbops.dbcon.dr.Close();
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
            return costs;
        }

        public List<OrderDetails> getOrdersForQuotation(Quotation quotation)
        {
            List<OrderDetails> orders = null;
            try
            {
                dbops.getConnection();
                string command = "select * from orderdetails where quoteid = "+quotation.Id;
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    orders = new List<OrderDetails>();
                    OrderDetails order = null;
                    while (dbops.dbcon.dr.Read())
                    {
                        order = new OrderDetails();
                        order.Billid = Int32.Parse(dbops.dbcon.dr["billid"].ToString());
                        order.Description = dbops.dbcon.dr["description"].ToString();
                        order.Color = dbops.dbcon.dr["color"].ToString();
                        order.Printside = dbops.dbcon.dr["printside"].ToString();
                        order.Flexsize = dbops.dbcon.dr["flexsize"].ToString();
                        order.Stampmodelno = dbops.dbcon.dr["stampmodelno"].ToString();
                        order.Papername = dbops.dbcon.dr["paper"].ToString();
                        order.Size = dbops.dbcon.dr["size"].ToString();
                        order.Qty = Int32.Parse(dbops.dbcon.dr["qty"].ToString());
                        order.Id = Int32.Parse(dbops.dbcon.dr["orderid"].ToString());
                        orders.Add(order);
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
            return orders;
        }

        public DataTable generateTableForOrders(List<OrderDetails> orders)
        {
            DataTable data = null;

            if (orders != null && orders.Count > 0)
            {
                data = new DataTable();
                DataColumn col = new DataColumn("ORDER ID");
                data.Clear();
                data.Columns.Add(col);
                col = new DataColumn("DESCRIPTION");
                data.Columns.Add(col);
                col = new DataColumn("COLOR");
                data.Columns.Add(col);
                col = new DataColumn("PRINTSIDE");
                data.Columns.Add(col);
                col = new DataColumn("FLEX SIZE");
                data.Columns.Add(col);
                col = new DataColumn("STAMP MODELNO");
                data.Columns.Add(col);
                col = new DataColumn("PAPER NAME");
                data.Columns.Add(col);
                col = new DataColumn("PAPER SIZE");
                data.Columns.Add(col);
                col = new DataColumn("QTY");
                data.Columns.Add(col);

                for (int i = 0; i < orders.Count; i++)
                {
                    DataRow dr = data.NewRow();
                    dr["ORDER ID"] = orders[i].Id;
                    dr["DESCRIPTION"] = orders[i].Description;
                    dr["COLOR"] = orders[i].Color;
                    dr["PRINTSIDE"] = orders[i].Printside;
                    dr["FLEX SIZE"] = orders[i].Flexsize;
                    dr["STAMP MODELNO"] = orders[i].Stampmodelno;
                    dr["PAPER NAME"] = orders[i].Papername;
                    dr["PAPER SIZE"] = orders[i].Size;
                    dr["QTY"] = orders[i].Qty;
                    data.Rows.Add(dr);
                }
            }
            return data;
        }

        public DataTable generateTableForCost(List<CostTable> costs)
        {
            DataTable data = null;

            if (costs != null && costs.Count > 0)
            {
                data = new DataTable();
                DataColumn col = new DataColumn("ORDER ID");
                data.Clear();
                data.Columns.Add(col);
                col = new DataColumn("PAGECOST");
                data.Columns.Add(col);
                col = new DataColumn("COLORCOST");
                data.Columns.Add(col);
                col = new DataColumn("PRINTCOST");
                data.Columns.Add(col);
                col = new DataColumn("BINDINGCOST");
                data.Columns.Add(col);
                col = new DataColumn("DTPCOST");
                data.Columns.Add(col);
                col = new DataColumn("DELIVERYCOST");
                data.Columns.Add(col);
                col = new DataColumn("PROFIT");
                data.Columns.Add(col);
                col = new DataColumn("TOTALCOST");
                data.Columns.Add(col);

                for (int i = 0; i < costs.Count; i++)
                {
                    DataRow dr = data.NewRow();
                    dr["ORDER ID"] = costs[i].Orderid;
                    dr["PAGECOST"] = costs[i].Pagecost;
                    dr["COLORCOST"] = costs[i].Colorcost;
                    dr["PRINTCOST"] =costs[i].Printcost;
                    dr["BINDINGCOST"] = costs[i].Bindingcost;
                    dr["DTPCOST"] =costs[i].Dtpcost;
                    dr["DELIVERYCOST"] = costs[i].Deliverycost;
                    dr["PROFIT"] = costs[i].Additionalprofit;
                    dr["TOTALCOST"] = costs[i].Totalcost;
                    data.Rows.Add(dr);
                }
            }
            return data;
        }

        
    }
}
