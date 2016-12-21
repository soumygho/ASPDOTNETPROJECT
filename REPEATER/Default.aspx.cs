using System;
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
using System.Web.Configuration;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection1"].ConnectionString.ToString());
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        if (!IsPostBack)
        {
            Repeater1_DataBind();
        }
        Label5.Text = Application["VISITS"].ToString();


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO MSG VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + DateTime.Now + "')";
            cmd.ExecuteNonQuery();
            Label1.Visible = true;
            Label1.Text = "YOUR MESSAGE HAS BEEN POSTED SUCCESSFULLY";
        }
        catch (Exception ee)
        {
            Label1.Visible = true;
            Label1.Text = ee.Message;
        }
        finally
        {
            con.Close();
            TextBox1.Text = null;
            TextBox2.Text = null;
            TextBox3.Text = null;
            Repeater1_DataBind();
        }
    }
    protected void Repeater1_DataBind()
    {
        try
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM MSG ORDER BY DATE DESC";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                    Repeater1.Visible = true;
                    Repeater1.DataSource = dr;
                    Repeater1.DataBind();
                    dr.Close();
            }
            else
            {
                Repeater1.Visible = false;
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
