using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class RubberStampOperation
    {
         private DatabaseOperation dbops = null;
         public RubberStampOperation()
        {
            dbops = new DatabaseOperation();
        }
        public bool insertIntoRubberStamp(RubberStamp stamp)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "insert into rubberstamp (modelno,rate)";
                command += "values ('" + stamp.Modelno + "','" + stamp.Rate + "');";
                
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

        public bool upadteRubberStamp(RubberStamp stamp)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "update rubberstamp set rate = '" + stamp.Rate + "' where modelno = '"+stamp.Modelno+"'; ";
              

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

        public List<RubberStamp> readRubberStamp()
        {
            bool flag = false;
            List<RubberStamp> stamps = null;
            try
            {
                dbops.getConnection();
                string command = "select * from rubberstamp ; ";
                dbops.executeReader(command);
                if (dbops.dbcon.dr != null)
                {
                    stamps = new List<RubberStamp>();
                    while (dbops.dbcon.dr.Read())
                    {
                        RubberStamp stamp = new RubberStamp();
                        stamp.Rate = float.Parse(dbops.dbcon.dr["rate"].ToString());
                        stamp.Modelno = dbops.dbcon.dr["modelno"].ToString();
                        stamps.Add(stamp);
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
            return stamps;
        }

        public List<RubberStamp> readRubberStamp(RubberStamp stamp1)
        {
            bool flag = false;
            List<RubberStamp> stamps = null;
            try
            {
                dbops.getConnection();
                string command = "select * from rubberstamp where modelno = '"+stamp1.Modelno+"' ; ";
                dbops.executeReader(command);
                if (dbops.dbcon.dr != null)
                {
                    stamps = new List<RubberStamp>();
                    while (dbops.dbcon.dr.Read())
                    {
                        RubberStamp stamp = new RubberStamp();
                        stamp.Rate = float.Parse(dbops.dbcon.dr["rate"].ToString());
                        stamp.Modelno = dbops.dbcon.dr["modelno"].ToString();
                        stamps.Add(stamp);
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
            return stamps;
        }
    }
}
