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

public partial class viewResult : System.Web.UI.Page
{
    dbconnection cn = new dbconnection();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (Session["userid"] == null)
        {
            Response.Redirect("~/Administrative_login.aspx");
        }
        if (!IsPostBack)
        {
            try
            {
                cn.con.Open();
                cn.cmd.CommandText = "select * from table_name";
                cn.cmd.Connection = cn.con;
                cn.dr = cn.cmd.ExecuteReader();
                DropDownList1.Items.Add("--SELECT CLASS--");
                DropDownList2.Items.Add("--SELECT YEAR--");
                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        DropDownList1.Items.Add(new ListItem(cn.dr["class"].ToString().Trim(), cn.dr["class"].ToString().Trim()));
                        DropDownList2.Items.Add(new ListItem(cn.dr["year"].ToString().Trim(), cn.dr["year"].ToString().Trim()));
                    }
                    DropDownList1.DataBind();
                    DropDownList2.DataBind();
                }
                else
                {
                    DropDownList1.Visible = false;
                    DropDownList2.Visible = false;
                   // panel2.Visible = false;
                   // Label17.Visible = true;
                   // Button1.Visible = false;
                   // Label17.Text = "NO RESULT IS UPLOADED YET!!!";
                }
            }
            catch (Exception ee)
            {
                Session["error"] = ee.Message;
            }
            finally
            {
                cn.con.Close();
                if (Session["error"] != null)
                {
                    Response.Redirect("~/error.aspx");
                }
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool flag = false;
        String table_name = null;
        try
        {
            cn.con.Open();
            cn.cmd.CommandText = "select * from table_name where class='"+DropDownList1.SelectedItem.Text.Trim()+"' and year = '"+DropDownList2.SelectedItem.Text.Trim()+"';";
            cn.cmd.Connection = cn.con;
            cn.dr = cn.cmd.ExecuteReader();
            if (cn.dr.HasRows)
            {
                while (cn.dr.Read())
                {
                    table_name=cn.dr["table_name"].ToString().Trim();
                }
            }
            Session["tablename"] = table_name;
            cn.dr.Close();
            cn.cmd.CommandText = "select * from "+table_name+";";
            cn.dr = cn.cmd.ExecuteReader();
            int num = 0;
            if (cn.dr.HasRows)
            {
                flag = true;
                while (cn.dr.Read())
                {
                    num++;
                }
            }
            Session["maxrecord"] = num;
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            cn.con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
            if (flag)
            {
                if (Int32.Parse(Session["maxrecord"].ToString().Trim()) > 20)
                {
                    Response.Redirect("~/view.aspx?min=1&max=20");
                }
                else
                {
                    Response.Redirect("~/view.aspx?min=1&max="+Int32.Parse(Session["maxrecord"].ToString().Trim()));
                }
            }
        }
    }
}
