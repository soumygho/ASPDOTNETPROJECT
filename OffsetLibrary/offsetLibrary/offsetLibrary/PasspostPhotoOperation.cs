using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class PasspostPhotoOperation
    {
         private DatabaseOperation dbops = null;
         public PasspostPhotoOperation()
        {
            dbops = new DatabaseOperation();
        }
        public bool insertIntoPassport(PassportPhoto passport)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "insert into passpostphoto (rateperphoto)";
                command += "values ('" + passport.Rateperphoto + "');";
                
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

        public bool upadtePassport(PassportPhoto passport)
        {
            bool flag = false;
            try
            {
                dbops.getConnection();
                string command = "update passpostphoto set rateperphoto = '" + passport.Rateperphoto + "';";
              

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

        public List<PassportPhoto> readPassport()
        {
            bool flag = false;
            List<PassportPhoto> passports = null;
            try
            {
                dbops.getConnection();
                string command = "select * from passpostphoto ";
                dbops.executeReader(command);
                if (dbops.dbcon.dr != null)
                {
                    passports = new List<PassportPhoto>();
                    while (dbops.dbcon.dr.Read())
                    {
                        PassportPhoto passport = new PassportPhoto();
                        passport.Rateperphoto = float.Parse(dbops.dbcon.dr["rateperphoto"].ToString());
                        passports.Add(passport);
                        
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
            return passports;
        }
    }
}
