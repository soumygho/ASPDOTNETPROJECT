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
public partial class RECOVERY_2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DBCONNECTION cn = new DBCONNECTION();
        try
        {
            cn.con.Open();
            cn.cmd.Connection = cn.con;
            cn.cmd.CommandText = "update form set PASSWORD='" + TextBox1.Text + "' WHERE USERID='" + Session["UNAME"].ToString() + "'";
            cn.cmd.ExecuteNonQuery();
            Response.Redirect("LOGIN.aspx");
        }
        catch (Exception ee)
        {
            Label1.Visible = true;
            Label1.Text = ee.Message;

        }
        finally
        {
            cn.con.Close();
        }
    }
}
