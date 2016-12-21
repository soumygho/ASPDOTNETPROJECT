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

public partial class recovery : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=F:\\SOUMYA\\ASP.NET PROJECT\\REGISTRATION\\App_Data\\ACCOUNT_LOGIN.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Label1.Visible = false;

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
    }
    protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
    {

        if (RadioButton4.Checked == true)
        {
            Panel1.Visible = true;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool flag = false;
        if (RadioButton4.Checked == true)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select USERID from FORM";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (TextBox1.Text == dr["USERID"].ToString())
                    {
                        flag = true;
                        break;
                    }
                }
                dr.Close();
                if (flag)
                {
                    Session["UNAME"] = TextBox1.Text;
                    Response.Redirect("RECOVERY_1.aspx");
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "USERNAME NOT MATCHED";
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
        else if (RadioButton2.Checked == true)
        {
            Response.Redirect("RECOVERY_2_TRUE.aspx");
        }
        else
        {
            Response.Redirect("RECOVERY_3.aspx");

        }
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }
}
