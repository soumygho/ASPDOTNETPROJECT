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

public partial class deleteResult : System.Web.UI.Page
{
    dbconnection con = new dbconnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        try
        {
            con.con.Open();
            con.cmd.CommandText = "delete from "+Request.QueryString["tablename"].ToString().Trim()+" where roll="+Request.QueryString["roll"].ToString().Trim()+";";
            con.cmd.Connection = con.con;
            con.cmd.ExecuteNonQuery();
            Label1.Visible = true;
            Label1.Text = "SUCCESSFULLY DELETED!!!";
            HyperLink1.NavigateUrl = "view.aspx?min="+Request.QueryString["min"].ToString().Trim()+"&max="+Request.QueryString["max"].ToString().Trim();
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            con.con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
}
