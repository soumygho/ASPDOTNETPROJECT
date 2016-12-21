using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace offsetLibrary
{
   public class BindingCostOperation
    {
         private DatabaseOperation dbops = null;
         public BindingCostOperation()
        {
            dbops = new DatabaseOperation();
        }

         public bool insertIntoBindingCost(BindingCost printcost)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "insert into binding (description,mincount,maxcount,price) ";
                command += "values ('"+printcost.Description+"',"+printcost.Min+","+printcost.Max+",'"+printcost.Rateperunit+"'";
                command += ");";
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

        public bool updateBindingCost(BindingCost printcost)
        {

            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "update binding set price = '"+printcost.Rateperunit+"' where mincount = "+printcost.Min+" and maxcount = "+printcost.Max+" and description = '"+printcost.Description+"';";
                
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

        public List<BindingCost> getBindingCost()
        {
            List<BindingCost> costs = null;
            try
            {
                dbops.getConnection();
                string command = "select * from binding ;";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    costs = new List<BindingCost>();
                    while (dbops.dbcon.dr.Read())
                    {
                        BindingCost cost = new BindingCost();
                        
                        cost.Min = Int32.Parse(dbops.dbcon.dr["mincount"].ToString());
                        cost.Max = Int32.Parse(dbops.dbcon.dr["maxcount"].ToString());
                        cost.Rateperunit = float.Parse(dbops.dbcon.dr["price"].ToString());
                        cost.Description = dbops.dbcon.dr["description"].ToString();
                        costs.Add(cost);
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
        public List<BindingCost> getBindingCost(BindingCost pcost)
        {
            List<BindingCost> costs = null;
            try
            {
                dbops.getConnection();
                string command = "select * from binding where mincount = " + pcost.Min + " and maxcount = " + pcost.Max + " and description = '" + pcost.Description + "';";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    costs = new List<BindingCost>();
                    while (dbops.dbcon.dr.Read())
                    {
                        BindingCost cost = new BindingCost();

                        cost.Min = Int32.Parse(dbops.dbcon.dr["mincount"].ToString());
                        cost.Max = Int32.Parse(dbops.dbcon.dr["maxcount"].ToString());
                        cost.Rateperunit = float.Parse(dbops.dbcon.dr["price"].ToString());
                        cost.Description = dbops.dbcon.dr["description"].ToString();
                        costs.Add(cost);
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

        public DataTable generateTable(List<BindingCost> costs)
        {
            DataTable dt = null;
            if (costs != null && costs.Count > 0)
            {
                dt = new DataTable();
                dt.Columns.Add("MINIMUM QTY");
                dt.Columns.Add("MAXIMUM QTY");
                dt.Columns.Add("BINDING RATE");
                dt.Columns.Add("DESCRIPTION");
                DataRow dr = null;
                for (int i = 0; i < costs.Count; i++)
                {
                    dr = dt.NewRow();
                    dr["MINIMUM QTY"] = costs[i].Min;
                    dr["MAXIMUM QTY"] = costs[i].Max;
                    dr["BINDING RATE"] = costs[i].Rateperunit;
                    dr["DESCRIPTION"] = costs[i].Description;
                    dt.Rows.Add(dr);
                }
            }
                return dt;
        }

        public BindingCost getBindingcostByQty(List<BindingCost> cost, int qty)
        {
            BindingCost printcost = null;
             if (cost != null && cost.Count > 0)
                {
            try
            {
                
               
                    dbops.getConnection();
                    printcost = new BindingCost();
                    printcost.Rateperunit = 0;
                    for (int i = 0; i < cost.Count; i++)
                    {
                        
                        string command = "select * from binding where mincount <= " + qty + " and maxcount >= " + qty + " and description = '" + cost[i].Description + "';";
                        dbops.executeReader(command);
                        if (dbops.dbcon.dr.HasRows)
                        {

                            while (dbops.dbcon.dr.Read())
                            {


                                printcost.Min = Int32.Parse(dbops.dbcon.dr["mincount"].ToString());
                                printcost.Max = Int32.Parse(dbops.dbcon.dr["maxcount"].ToString());
                                printcost.Rateperunit += float.Parse(dbops.dbcon.dr["price"].ToString());
                                printcost.Description = dbops.dbcon.dr["description"].ToString();

                            }
                        }
                        dbops.dbcon.dr.Close();
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
                }
            return printcost;
        }
    }
}
