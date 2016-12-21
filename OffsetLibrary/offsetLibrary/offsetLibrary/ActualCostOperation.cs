using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class ActualCostOperation
    {

        private DatabaseOperation dbops = null;
        public ActualCostOperation()
        {
            dbops = new DatabaseOperation();
        }

        public bool insertActualCost(ActualCost actualcost)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "insert into actualcost (categoryid,dtpcostperpage,bindingcost,profit,deliverycostperunit)";
                command+= "values (" + actualcost.Categoryid + ",'" + actualcost.Dtpcostperpage + "','" + actualcost.Bindingcost + "',";
                command+="'"+actualcost.Profit+"','"+actualcost.Deliverycostperunit+"');";
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

        public bool updateActualCost(ActualCost actualcost)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "update actualcost set dtpcostperpage = '" + actualcost.Dtpcostperpage + "',bindingcost = '" + actualcost.Bindingcost + "',profit = '" + actualcost.Profit + "',deliverycostperunit = '" + actualcost.Deliverycostperunit + "' where categoryid = "+actualcost.Categoryid+";";
                
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


        public List<ActualCost> readActualcost(Category category)
        {
            bool flag = false;
            List<ActualCost> actualcosts = null;
            try
            {
                dbops.getConnection();
                string command = "select * from actualcost where categoryid = "+category.Id+" ; ";
                dbops.executeReader(command);
                if (dbops.dbcon.dr != null)
                {
                    actualcosts = new List<ActualCost>();
                    while (dbops.dbcon.dr.Read())
                    {
                        ActualCost cost = new ActualCost();
                        
                        cost.Dtpcostperpage = float.Parse(dbops.dbcon.dr["dtpcostperpage"].ToString());
                        cost.Bindingcost = float.Parse(dbops.dbcon.dr["bindingcost"].ToString());
                        //cost.Colorcostperpage = float.Parse(dbops.dbcon.dr["colorcostperpage"].ToString());
                        cost.Profit = float.Parse(dbops.dbcon.dr["profit"].ToString());
                        cost.Deliverycostperunit = float.Parse(dbops.dbcon.dr["deliverycostperunit"].ToString());
                        cost.Categoryid = Int32.Parse(dbops.dbcon.dr["categoryid"].ToString());
                        actualcosts.Add(cost);
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
            return actualcosts;
        }

        public List<ActualCost> readAllActualcost()
        {
            bool flag = false;
            List<ActualCost> actualcosts = null;
            try
            {
                dbops.getConnection();
                string command = "select * from actualcost  ; ";
                dbops.executeReader(command);
                if (dbops.dbcon.dr != null)
                {
                    actualcosts = new List<ActualCost>();
                    while (dbops.dbcon.dr.Read())
                    {
                        ActualCost cost = new ActualCost();
                        
                        cost.Dtpcostperpage = float.Parse(dbops.dbcon.dr["dtpcostperpage"].ToString());
                        cost.Bindingcost = float.Parse(dbops.dbcon.dr["bindingcostperpage"].ToString());
                        //cost.Colorcostperpage = float.Parse(dbops.dbcon.dr["colorcostperpage"].ToString());
                        cost.Profit = float.Parse(dbops.dbcon.dr["profit"].ToString());
                        cost.Deliverycostperunit = float.Parse(dbops.dbcon.dr["deliverycostperunit"].ToString());
                        cost.Categoryid = Int32.Parse(dbops.dbcon.dr["categoryid"].ToString());
                        actualcosts.Add(cost);
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
            return actualcosts;
        }
    }


}
