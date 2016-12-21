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

public partial class updateresultstatus : System.Web.UI.Page
{
    dbconnection data = new dbconnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null)
        {
            Response.Redirect("~/Administrative_login.aspx");
        }
        Label1.Visible = false;
        try
        {
            data.con.Open();
            data.cmd.CommandText = "select * from filerecord";
            data.cmd.Connection = data.con;
            SqlDataAdapter da = new SqlDataAdapter(data.cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            resultRecord.DataSource = ds;
            resultRecord.DataBind();
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            data.con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            data.con.Open();
            data.cmd.CommandText = "update filerecord set status = '"+statusDropdown.SelectedItem.Text.Trim()+"' where id = "+Int32.Parse(idText.Text.ToString().Trim());
            data.cmd.Connection = data.con;
            data.cmd.ExecuteNonQuery();
            Label1.Visible = true;
            Label1.Text = "SUCCESSFULLY UPDATED!!!";
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            data.con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
}
