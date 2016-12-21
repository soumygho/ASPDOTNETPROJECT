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
public partial class ACCOUNT : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["USERNAME"].ToString() != null)
        {



            Label1.Visible = false;
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\DELL\\REGISTRATION\\App_Data\\ACCOUNT_LOGIN.mdf;Integrated Security=True;User Instance=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM FORM where USERID ='" + Session["USERNAME"] + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr["USERID"].ToString();
                    TextBox2.Text = dr["NAME"].ToString();
                    TextBox3.Text = dr["EMAIL"].ToString();
                    TextBox4.Text = dr["MOB"].ToString();
                    TextBox5.Text = dr["GENDER"].ToString();
                    TextBox6.Text = dr["LANG"].ToString();
                    TextBox7.Text = dr["REL"].ToString();
                    TextBox8.Text = dr["NAT"].ToString();
                    TextBox9.Text = dr["ADDRESS"].ToString();
                    TextBox10.Text = dr["ZIP"].ToString();
                    TextBox11.Text = dr["DOB"].ToString();
                }
                dr.Close();
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
        else
        {
            Response.Redirect("LOGIN.aspx");
        }
      
            
    }
    protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("LOGIN.aspx");
    }
}
