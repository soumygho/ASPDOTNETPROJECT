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

public partial class LOGIN : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|ACCOUNT_LOGIN.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label3.Visible = false;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool flag = false;
        try
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select USERID,PASSWORD from FORM";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (TextBox1.Text == dr["USERID"].ToString() && TextBox2.Text == dr["PASSWORD"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            dr.Close();
            if (flag)
            {
                Session["USERNAME"] = TextBox1.Text;
                Response.Redirect("WELCOME.aspx");
            }
            else
            {
                Label3.Visible = true;
                Label3.Text = "USERNAME OR PASSWORD NOT MATCHED";
            }
        }
        catch (Exception ee)
        {
            Label3.Visible = true;
            Label3.Text = ee.Message;
        }
        finally
        {
            con.Close();
        }

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
