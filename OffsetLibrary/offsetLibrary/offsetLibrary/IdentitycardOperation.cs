using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class IdentitycardOperation
    {
         private DatabaseOperation dbops = null;
         public IdentitycardOperation()
        {
            dbops = new DatabaseOperation();
        }
        public bool insertIntoIdentityCard(Identitycard card)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "insert into identitycard (ratepercard)";
                command += "values ('" + card.Ratepercard + "');";
                
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

        public bool upadteIdentitycard(Identitycard card)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "update identitycard set ratepercard = '" + card.Ratepercard + "'";
              

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

        public List<Identitycard> readIdentityCard()
        {
            bool flag = false;
            List<Identitycard> cards = null;
            try
            {
                dbops.getConnection();
                string command = "select * from identitycard; ";
                dbops.executeReader(command);
                if (dbops.dbcon.dr != null)
                {
                    cards = new List<Identitycard>();
                    while (dbops.dbcon.dr.Read())
                    {
                        Identitycard card = new Identitycard();
                        card.Ratepercard = float.Parse(dbops.dbcon.dr["ratepercard"].ToString());

                        cards.Add(card);
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
            return cards;
        }
    }
}
