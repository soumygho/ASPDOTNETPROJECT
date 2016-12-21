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

public partial class RECOVERY_1 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\ACCOUNT_LOGIN.mdf;Integrated Security=True;User Instance=True");
  //  SqlConnection cc = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionstring"].ToString());
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dr;
    string a, b, c, d,r,f,g,h,i;
    int k=0,y;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UNAME"].ToString()== null)
        {
            Response.Redirect("LOGIN.aspx");
        }
        Label5.Visible = false;
        try
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from FORM";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["USERID"].ToString() == Session["UNAME"].ToString())
                {
                    a = dr["EMAIL"].ToString();
                    b = dr["MOB"].ToString();
                    c = dr["SEC_QUES_1"].ToString();
                    d = dr["SEC_QUES_2"].ToString();
                    h = dr["ANS_1"].ToString();
                    i = dr["ANS_2"].ToString();
                    break;
                }
            }
            dr.Close();
            Label1.Text = b;
            Label2.Text = a;
            y = a.Length;
            for (k = 1; k <= y; k++)
            {
                if (a[k] == '@')
                {
                    break;
                }
            }
            r = a.Substring(0,4);
            f=a.Substring(k,(y-k));
            Label2.Text = r + "***********" + f;
            g = b.Substring(9,4);
            Label1.Text = "*******" + g;
            Label3.Text = c;
            Label4.Text = d;
            
        }
        catch(Exception ee)
        {
            Label5.Visible = true;
            Label5.Text = ee.Message;
        }
        finally
        {
            con.Close();
        }

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (a == TextBox2.Text && b == TextBox1.Text && h == TextBox3.Text && i == TextBox4.Text)
        {
            Response.Redirect("RECOVERY_2.aspx");
        }
        else
        {
            Label5.Visible = true;
            Label5.Text = "INCORRECT INFORMATION TRY AGAIN";
        }
    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
}
