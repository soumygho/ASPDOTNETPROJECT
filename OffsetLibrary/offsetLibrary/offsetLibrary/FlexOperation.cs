using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class FlexOperation
    {
         private DatabaseOperation dbops = null;
         public FlexOperation()
         {
            dbops = new DatabaseOperation();
         }

         public bool insertActualCost(Flex flex)
         {
             bool flag = false;
             try
             {
                 dbops.getConnection();
                 string command = "insert into flex (ratepersqft) values('"+flex.Ratepersquarefeet+"');";
                 
                 
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
         public bool updateActualCost(Flex flex)
         {
             bool flag = false;
             try
             {
                 dbops.getConnection();
                 string command = "update flex set ratepersqft = '" + flex.Ratepersquarefeet + "' where id = "+flex.Id+";";


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

         public List<Flex> readFlex()
         {
             List<Flex> flexs = null;
             try
             {
                 dbops.getConnection();
                 string command = "select * from flex;";
                 dbops.executeReader(command);
                 if (dbops.dbcon.dr.HasRows)
                 {
                     flexs = new List<Flex>();
                     while (dbops.dbcon.dr.Read())
                     {
                         Flex flex = new Flex();
                         flex.Id = Int32.Parse(dbops.dbcon.dr["id"].ToString());
                         flex.Ratepersquarefeet = float.Parse(dbops.dbcon.dr["ratepersqft"].ToString());
                         flexs.Add(flex);
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
             return flexs;
         }
    }
}
