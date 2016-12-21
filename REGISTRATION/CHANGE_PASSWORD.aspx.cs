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

public partial class CHANGE_PASSWORD : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\DELL\\REGISTRATION\\App_Data\\ACCOUNT_LOGIN.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dr;
    bool flag = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["USERNAME"] == null)
        {
            Response.Redirect("LOGIN.aspx");
        }
        Label1.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select password from FORM  where USERID='" + Session["USERNAME"] + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (TextBox1.Text == dr["password"].ToString() && TextBox2.Text != dr["password"].ToString())
                {
                   flag = true;
                   break;
                }
            }
            dr.Close();
            if (flag)
            {
                cmd.CommandText = "update FORM set password='" + TextBox2.Text + "' where USERID='" + Session["USERNAME"] + "'";
                cmd.ExecuteNonQuery();
                Label1.Visible = true;
                Label1.Text = "PASSWORD SUCCESSFULLY CHANGED";
                Response.Redirect("LOGIN.aspx");
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "PASSWORD INCORRECT";
            }

        }
        catch (Exception ee)
        {
            Label1.Visible = true;
            Label1.Text = ee.Message;
        }
        finally
        {
            con.Close();
        }
    }
}
