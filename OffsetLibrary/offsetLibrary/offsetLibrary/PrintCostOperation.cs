using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace offsetLibrary
{
  public  class PrintCostOperation
    {
        private DatabaseOperation dbops = null;
        public PrintCostOperation()
        {
            dbops = new DatabaseOperation();
        }

         public bool insertIntoPrintCost(PrintCost printcost)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "insert into printcost (minqty,maxqty,printrate,color) ";
                command += "values ("+printcost.Min+","+printcost.Max+",'" + printcost.Printrate + "','"+printcost.Color+"'";
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

        public bool updatePrintCost(PrintCost printcost)
        {

            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "update printcost set printrate = '"+printcost.Printrate+"' where minqty = "+printcost.Min+" and maxqty = "+printcost.Max+" and color = '"+printcost.Color+"';";
                
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

        public List<PrintCost> getPrintCost()
        {
            List<PrintCost> costs = null;
            try
            {
                dbops.getConnection();
                string command = "select * from printcost ;";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    costs = new List<PrintCost>();
                    while (dbops.dbcon.dr.Read())
                    {
                        PrintCost cost = new PrintCost();
                        
                        cost.Min = Int32.Parse(dbops.dbcon.dr["minqty"].ToString());
                        cost.Max = Int32.Parse(dbops.dbcon.dr["maxqty"].ToString());
                        cost.Printrate = float.Parse(dbops.dbcon.dr["printrate"].ToString());
                        cost.Color = dbops.dbcon.dr["color"].ToString();
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
        public List<PrintCost> getPrintCost(PrintCost pcost)
        {
            List<PrintCost> costs = null;
            try
            {
                dbops.getConnection();
                string command = "select * from printcost where minqty = " + pcost.Min + " and maxqty = " + pcost.Max + " and color = '" + pcost.Color + "';";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    costs = new List<PrintCost>();
                    while (dbops.dbcon.dr.Read())
                    {
                        PrintCost cost = new PrintCost();

                        cost.Min = Int32.Parse(dbops.dbcon.dr["minqty"].ToString());
                        cost.Max = Int32.Parse(dbops.dbcon.dr["maxqty"].ToString());
                        cost.Printrate = float.Parse(dbops.dbcon.dr["printrate"].ToString());
                        cost.Color = dbops.dbcon.dr["color"].ToString();
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

        public DataTable generateTable(List<PrintCost> costs)
        {
            DataTable dt = null;
            if (costs != null && costs.Count > 0)
            {
                dt = new DataTable();
                dt.Columns.Add("MINIMUM QTY");
                dt.Columns.Add("MAXIMUM QTY");
                dt.Columns.Add("PRINT RATE");
                dt.Columns.Add("COLOR DETAILS");
                DataRow dr = null;
                for (int i = 0; i < costs.Count; i++)
                {
                    dr = dt.NewRow();
                    dr["MINIMUM QTY"] = costs[i].Min;
                    dr["MAXIMUM QTY"] = costs[i].Max;
                    dr["PRINT RATE"] = costs[i].Printrate;
                    dr["COLOR DETAILS"] = costs[i].Color;
                    dt.Rows.Add(dr);
                }
            }
                return dt;
        }

        public PrintCost getPrintcostByQty(List<PrintCost> cost, int qty)
        {
            PrintCost printcost = null;
             if (cost != null && cost.Count > 0)
                {
            try
            {
                
               
                    dbops.getConnection();
                    printcost = new PrintCost();
                    printcost.Printrate = 0;
                    for (int i = 0; i < cost.Count; i++)
                    {
                        
                        string command = "select * from printcost where minqty <= " + qty + " and maxqty >= " + qty + " and color = '" + cost[i].Color + "';";
                        dbops.executeReader(command);
                        if (dbops.dbcon.dr.HasRows)
                        {

                            while (dbops.dbcon.dr.Read())
                            {


                                printcost.Min = Int32.Parse(dbops.dbcon.dr["minqty"].ToString());
                                printcost.Max = Int32.Parse(dbops.dbcon.dr["maxqty"].ToString());
                                printcost.Printrate += float.Parse(dbops.dbcon.dr["printrate"].ToString());
                                printcost.Color = dbops.dbcon.dr["color"].ToString();

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
