using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.OleDb;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|" + "\\" + "Productlisence.accdb");
    OleDbCommand cmd = new OleDbCommand();
    OleDbDataReader dr;
    CreateDateClass create = new CreateDateClass();
    
    [WebMethod]
    public ClassLisence getActivationStatus(ClassLisence lisence)
    {

        ClassLisence lisenceObj = null;
        // bool flag = false;
        String status = "no";
        try
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from lisence where productkey = '" + lisence.Productkey+"'";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                lisenceObj = new ClassLisence();
                while (dr.Read())
                {
                    lisenceObj.Productkey = dr["productkey"].ToString();
                    lisenceObj.Uniqueid = dr["uniqueid"].ToString();
                    lisenceObj.Status = dr["status"].ToString();
                    lisenceObj.Softwaretype = dr["softwaretype"].ToString();
                    lisenceObj.Email = dr["email"].ToString();
                    lisenceObj.Name = dr["name"].ToString();
                    lisenceObj.Activationdate = dr["activationdate"].ToString();
                    lisenceObj.Deactivationdate = dr["deactivationdate"].ToString();
                    lisenceObj.Id =Int32.Parse( dr["id"].ToString());
                }
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
        return lisenceObj;
    }
    [WebMethod]
    public ClassLisence activate(ClassLisence lisence)
    {
        lisence.Status = "true";
        bool flag = false;
        ClassLisence lisenceObj = null;
        // bool flag = false;
        String status = "no";
        try
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT ID, productkey, status, uniqueid, name, email, activationdate, deactivationdate, softwaretype FROM            lisence WHERE        (productkey = '" + lisence.Productkey + "')";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                lisenceObj = new ClassLisence();
                while (dr.Read())
                {
                    lisenceObj.Productkey = dr["productkey"].ToString();
                    lisenceObj.Uniqueid = dr["uniqueid"].ToString();
                    lisenceObj.Status = dr["status"].ToString();
                    lisenceObj.Softwaretype = dr["softwaretype"].ToString();
                    lisenceObj.Email = dr["email"].ToString();
                    lisenceObj.Name = dr["name"].ToString();
                    lisenceObj.Activationdate = dr["activationdate"].ToString();
                    lisenceObj.Deactivationdate = dr["deactivationdate"].ToString();
                    lisenceObj.Id =Int32.Parse( dr["id"].ToString());
                }
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
        if(lisenceObj!=null&&lisenceObj.Uniqueid.Equals("")&&lisenceObj.Status.Equals("false"))
        {
            lisenceObj = lisence;
           // CreateDateClass create = new CreateDateClass();
            lisenceObj.Activationdate = create.createDate(DateTime.Now.Date.ToShortDateString());
            DateTime dt = DateTime.Now.Date;
            dt+=new TimeSpan(365,0,0,0);
            lisenceObj.Deactivationdate = create.createDate(dt.Date.ToShortDateString());
            lisenceObj.Status="true";
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "update [lisence] set  [status] = '"+lisenceObj.Status+"',[uniqueid] = '" + lisenceObj.Uniqueid + "' , [name] = '" + lisenceObj.Name + "',[email] = '" + lisenceObj.Email + "',activationdate = " + lisenceObj.Activationdate + ",deactivationdate = "+lisenceObj.Deactivationdate+",softwaretype='"+lisenceObj.Softwaretype+"' where [productkey] = '" + lisenceObj.Productkey + "';";
                cmd.ExecuteNonQuery();
                status = "yes";

            }
            catch (Exception ee)
            {
                lisenceObj = null;
            }
            finally
            {
                con.Close();
            }
        }
        else
        {
            lisenceObj = null;
        }
        
        return lisenceObj;
}
    [WebMethod]
    public ClassLisence reActivate(ClassLisence lisense)
    {
        ClassLisence lisenceObj = null;
        
        try
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from lisence where productkey = '" + lisense.Productkey + "'";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                lisenceObj = new ClassLisence();
                while (dr.Read())
                {
                    lisenceObj.Productkey = dr["productkey"].ToString();
                    lisenceObj.Uniqueid = dr["uniqueid"].ToString();
                    lisenceObj.Status = dr["status"].ToString();
                    lisenceObj.Softwaretype = dr["softwaretype"].ToString();
                    lisenceObj.Email = dr["email"].ToString();
                    lisenceObj.Name = dr["name"].ToString();
                    lisenceObj.Activationdate =create.createDate( dr["activationdate"].ToString());
                    lisenceObj.Deactivationdate =create.createDate( dr["deactivationdate"].ToString());
                    lisenceObj.Id = Int32.Parse(dr["id"].ToString());
                }
            }

        }
        catch (Exception ee)
        {
           
        }
        finally
        {
            con.Close();
        }
        if(lisenceObj.Status.Equals("false")||!(lisenceObj.Name.Equals(lisense.Name)&&lisenceObj.Productkey.Equals(lisenceObj.Productkey)&&lisenceObj.Softwaretype.Equals(lisense.Softwaretype)&&lisenceObj.Uniqueid.Equals(lisense.Uniqueid)))
        {
            lisenceObj = null;
        }
        else if (lisenceObj.Status.Equals("true") && lisenceObj.Email.Equals(lisense.Email) && lisenceObj.Name.Equals(lisense.Name) && lisenceObj.Softwaretype.Equals(lisense.Softwaretype)&&lisenceObj.Uniqueid.Equals(lisense.Uniqueid))
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "update lisence set  uniqueid = '" + lisense.Uniqueid + "' where productkey = '" + lisenceObj.Productkey + "';";
                cmd.ExecuteNonQuery();
                lisenceObj.Uniqueid = lisense.Uniqueid;
                //status = "yes";

            }
            catch (Exception ee)
            {
                lisenceObj = null;
            }
            finally
            {
                con.Close();
            }
        }
        return lisenceObj;
    }
    [WebMethod]
    public ClassLisence renew(ClassLisence lisense)
    {
        ClassLisence lisenceObj = null;
        try
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from lisence where productkey = '" + lisense.Productkey + "'";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                lisenceObj = new ClassLisence();
                while (dr.Read())
                {
                    lisenceObj.Productkey = dr["productkey"].ToString();
                    lisenceObj.Uniqueid = dr["uniqueid"].ToString();
                    lisenceObj.Status = dr["status"].ToString();
                    lisenceObj.Softwaretype = dr["softwaretype"].ToString();
                    lisenceObj.Email = dr["email"].ToString();
                    lisenceObj.Name = dr["name"].ToString();
                    lisenceObj.Activationdate = dr["activationdate"].ToString();
                    lisenceObj.Deactivationdate = dr["deactivationdate"].ToString();
                    lisenceObj.Id = Int32.Parse(dr["id"].ToString());
                }
            }

        }
        catch (Exception ee)
        {

        }
        finally
        {
            con.Close();
        }
        if (!(lisenceObj.Productkey.Equals(lisenceObj.Productkey)&&lisenceObj.Uniqueid.Equals(lisense.Uniqueid)))
        {
            lisenceObj = null;
        }
        else if ( lisenceObj.Productkey.Equals(lisenceObj.Productkey)  && lisenceObj.Uniqueid.Equals(lisense.Uniqueid))
        {
           // CreateDateClass create = new CreateDateClass();
             lisenceObj.Activationdate = create.createDate(DateTime.Now.Date.ToShortDateString());
            DateTime dt = DateTime.Now.Date;
            dt+=new TimeSpan(365,0,0,0);
            lisenceObj.Deactivationdate = create.createDate(dt.Date.ToShortDateString());
            lisenceObj.Status="true";

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "update lisence set  status = '" + lisenceObj.Status + "',activationdate = "+lisenceObj.Activationdate+",deactivationdate="+lisenceObj.Deactivationdate+" where productkey = '" + lisenceObj.Productkey + "';";
                cmd.ExecuteNonQuery();
                lisenceObj.Uniqueid = lisense.Uniqueid;
                //status = "yes";

            }
            catch (Exception ee)
            {
                lisenceObj = null;
            }
            finally
            {
                con.Close();
            }
        }
        return lisenceObj;
    }
}
    
    

