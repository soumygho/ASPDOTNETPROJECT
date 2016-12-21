using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    class ProfitTableOperation
    {
        private DatabaseOperation dbops = null;

        public ProfitTableOperation()
        {
            dbops = new DatabaseOperation();
        }

        public bool insertIntoProfitTable(ProfitTable profit)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "insert into profittable (receiptid,actualcost,finalamount,profit,loss,billid,transdate)";
                command += "values (" + profit.Receiptid + ",'" + profit.Actualcost + "','" + profit.Finalamount + "','" + profit.Profit + "',";
                command += "'" + profit.Loss +"'," + profit.Billid + ",'" + profit.Transdate + "') ;";
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

        public bool updateProfitTable(ProfitTable profit)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "update profittable set  receiptid = " + profit.Receiptid + ",actualcost = '" + profit.Actualcost + "',finalamount='" + profit.Finalamount + "',profit = '" + profit.Profit + "',loss = '" + profit.Loss + "',billid = " + profit.Billid + ",transdate = '" + profit.Transdate + "' where id = "+profit.Id+"";
               
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
    }
}
