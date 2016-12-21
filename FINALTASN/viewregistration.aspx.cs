using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class viewregistration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String path = Server.MapPath("~/Registration") + "//" + "registrationdb.accdb";
        String connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path;
        OleDbConnection con = new OleDbConnection(connectionstring);
        System.Data.DataSet ds = new System.Data.DataSet();
        OleDbCommand cmd = new OleDbCommand();
        try
        {
            con.Open();
            cmd.CommandText = "select * from REGISTRATION ;";
            cmd.Connection = con;
            OleDbDataAdapter dr = new OleDbDataAdapter(cmd);
            dr.Fill(ds);
            int count = ds.Tables[0].Rows.Count;
            if (count != 0)
            {
               
                registrationGrid.DataSource = ds;
                registrationGrid.DataBind();
            }
            
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
}
