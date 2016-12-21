using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace offsetLibrary
{
    public class DtpOperation
    {
        private DatabaseOperation dbops = null;
        public DtpOperation()
        {
            dbops = new DatabaseOperation();
        }
        public bool insertIntoDtp(Dtp dtp)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "insert into dtp (papersize,rateperpage,type)";
                command += "values ('" + dtp.Papersize + "','" + dtp.Rateperpage + "','"+dtp.Type+"');";
                
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

        public bool upadteDtp(Dtp dtp)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "update dtp set rateperpage = '" + dtp.Rateperpage + "' where papersize = '" + dtp.Papersize + "' and type = '" + dtp.Type + "' ";
              

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

        public List<Dtp> readxeroxDtp()
        {
            bool flag = false;
            List<Dtp> dtps = null;
            try
            {
                dbops.getConnection();
                string command = "select * from dtp where type = 'XEROX';";
                dbops.executeReader(command);
                if (dbops.dbcon.dr != null)
                {
                    dtps = new List<Dtp>();
                    while (dbops.dbcon.dr.Read())
                    {
                        Dtp dtp = new Dtp();
                        dtp.Rateperpage = float.Parse(dbops.dbcon.dr["rateperpage"].ToString());
                        dtp.Papersize = dbops.dbcon.dr["papersize"].ToString();
                        dtp.Type = dbops.dbcon.dr["type"].ToString();
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
        public List<Dtp> readColorxeroxDtp()
        {
            bool flag = false;
            List<Dtp> dtps = null;
            try
            {
                dbops.getConnection();
                string command = "select * from dtp where type = 'COLORXEROX';";
                dbops.executeReader(command);
                if (dbops.dbcon.dr != null)
                {
                    dtps = new List<Dtp>();
                    while (dbops.dbcon.dr.Read())
                    {
                        Dtp dtp = new Dtp();
                        dtp.Rateperpage = float.Parse(dbops.dbcon.dr["rateperpage"].ToString());
                        dtp.Papersize = dbops.dbcon.dr["papersize"].ToString();
                        dtp.Type = dbops.dbcon.dr["type"].ToString();
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
        public DataTable generateTable(List<Dtp> dtps)
        {
            DataTable table = null;
            if (dtps != null && dtps.Count > 0)
            {
                table = new DataTable();
                
                DataColumn col = new DataColumn("PAPER SIZE");
                table.Columns.Add(col);
                
                col = new DataColumn("RATE/PAGE");
                table.Columns.Add(col);
                col = new DataColumn("TYPE");
                table.Columns.Add(col);
                for (int i = 0; i < dtps.Count; i++)
                {
                    DataRow row = table.NewRow();
                    row["TYPE"] = dtps[i].Type;
                    row["PAPER SIZE"] = dtps[i].Papersize;
                    
                    row["RATE/PAGE"] = dtps[i].Rateperpage;
                    table.Rows.Add(row);
                }

            }
            return table;
        }
        public List<Dtp> readDtp(Dtp dtp1)
        {
            bool flag = false;
            List<Dtp> dtps = null;
            try
            {
                dbops.getConnection();
                string command = "select * from dtp where type = '"+dtp1.Type+"' and papersize = '"+dtp1.Papersize+"'";
                dbops.executeReader(command);
                if (dbops.dbcon.dr != null)
                {
                    dtps = new List<Dtp>();
                    while (dbops.dbcon.dr.Read())
                    {
                        Dtp dtp = new Dtp();
                        dtp.Rateperpage = float.Parse(dbops.dbcon.dr["rateperpage"].ToString());
                        dtp.Papersize = dbops.dbcon.dr["papersize"].ToString();
                        dtp.Type = dbops.dbcon.dr["type"].ToString();
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
        public List<Dtp> readDtp()
        {
            bool flag = false;
            List<Dtp> dtps = null;
            try
            {
                dbops.getConnection();
                string command = "select * from dtp;";
                dbops.executeReader(command);
                if (dbops.dbcon.dr != null)
                {
                    dtps = new List<Dtp>();
                    while (dbops.dbcon.dr.Read())
                    {
                        Dtp dtp = new Dtp();
                        dtp.Rateperpage = float.Parse(dbops.dbcon.dr["rateperpage"].ToString());
                        dtp.Papersize = dbops.dbcon.dr["papersize"].ToString();
                        dtp.Type = dbops.dbcon.dr["type"].ToString();
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

        
        
    }
}
