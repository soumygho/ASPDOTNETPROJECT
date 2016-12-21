using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.IO;
using System.Data.Sql;

public partial class TEACHERS_DETAILS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String trade = Request.QueryString["trade"].ToString();
        dbconnection database = new dbconnection();
        try
        {
            database.con.Open();
            database.cmd.CommandText = "select * from teacher where trade= @trade";
            database.cmd.Parameters.AddWithValue("trade",trade);
            database.cmd.Connection = database.con;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(database.cmd);
            da.Fill(ds);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
            
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            database.con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
}
