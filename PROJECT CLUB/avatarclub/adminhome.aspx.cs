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

public partial class adminhome : System.Web.UI.Page
{
    DatabaseConnection db = new DatabaseConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null)
        {
            Response.Redirect("~/adminlogin.aspx");
        }
        Label1.Visible = false;
        Label2.Visible = false;
        Label3.Visible = false;
        userid.Text = Session["userid"].ToString().Trim();
        bindData("NOT REGISTERED",data,Label1);
        bindData("VALID",DataPagerRepeater1,Label2);
        bindData("INVALID",DataPagerRepeater2,Label3);
    }
    private void bindData(String status,DataPagerRepeater.DataPagerRepeater obj,Label lab)
    {
        try
        {
            db.con.Open();
            db.cmd.CommandText = "select * from userdetails where status = '"+status+"'";
            db.cmd.Connection = db.con;
            SqlDataAdapter da = new SqlDataAdapter(db.cmd);
            DataSet ds = new DataSet();
            int rowno = da.Fill(ds);
            if (rowno > 0)
            {
                obj.DataSource = ds;
                obj.DataBind();
            }
            else
            {
                lab.Visible = true;
                lab.Text = "NO DATA AVAILABLE!!!";
                obj.Visible = false;
            }
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            db.con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("~/adminlogin.aspx");
    }
}
