using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
   public class DigitalPrintingOperation
    {
        private DatabaseOperation dbops = null;
        public DigitalPrintingOperation()
        {
            dbops = new DatabaseOperation();
        }

        public bool insertIntoDigitalPrintingCost(DigitalPrintingCost cost)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "insert into digitalprinitingcost (rateperpage)";
                command += "values ('" + cost.Rateperpage + "'";
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

        public bool updatePrintCost(DigitalPrintingCost cost)
        {

            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "update digitalprinitingcost set rateperpage = '"+cost.Rateperpage+"';";
                
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

        public List<DigitalPrintingCost> getPrintingCost()
        {
            List<DigitalPrintingCost> costs = null;
            try
            {
                dbops.getConnection();
                string command = "select * from digitalprinitingcost;";
                dbops.executeReader(command);
                if (dbops.dbcon.dr.HasRows)
                {
                    costs = new List<DigitalPrintingCost>();
                    while (dbops.dbcon.dr.Read())
                    {
                        DigitalPrintingCost cost = new DigitalPrintingCost();
                        cost.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                        cost.Rateperpage =float.Parse( dbops.dbcon.dr["rateperpage"].ToString());
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
    }
}
