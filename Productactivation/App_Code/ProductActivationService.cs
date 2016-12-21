using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.OleDb;

// NOTE: If you change the class name "ProductActivationService" here, you must also update the reference to "ProductActivationService" in Web.config.
public class ProductActivationService : IProductActivationService
{
    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|"+"\\"+"Imslisence.accdb");
    OleDbCommand cmd = new OleDbCommand();
    OleDbDataReader dr;

    #region IIMSActivationService Members

    public string getActivationStatus(string productKey)
    {


        // bool flag = false;
        String status = "no";
        try
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select status from lisence where productkey = " + productKey;
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    status = dr["status"].ToString();
                }
            }
            else
            {
                status = " INVALID PRODUCT KEY!!!";
            }
        }
        catch (Exception ee)
        {
            status = ee.Message;
        }
        finally
        {
            con.Close();
        }
        return status;
    }

    public string activate(string productKey, string name, string emailaddress, string id)
    {
        bool flag = false;
        String status = "no";
        try
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select status from lisence where productkey = '" + productKey + "'";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    status = dr["status"].ToString();
                }
            }
            else
            {
                status = " INVALID PRODUCT KEY!!!";
            }
        }
        catch (Exception ee)
        {
            status = ee.Message;
        }
        finally
        {
            con.Close();
        }
        if (status.Equals("no"))
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "update lisence set  status = 'true',uniqueid = '" + id + "' , name = '" + name + "',email = '" + emailaddress + "',activationdate = '" + DateTime.Now.ToShortDateString() + "',deactivationdate = 'NIL' where productkey = '" + productKey + "';";
                cmd.ExecuteNonQuery();
                status = "yes";

            }
            catch (Exception ee)
            {
                status = ee.Message;
            }
            finally
            {
                con.Close();
            }
        }
        return status;
    }
    #endregion
}
