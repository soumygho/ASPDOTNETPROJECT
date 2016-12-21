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
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection1"].ConnectionString.ToString());
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        try
        {
             con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM login";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Label1.Text = dr["username"].ToString();
                Label2.Text = dr["password"].ToString();
            }

        }
        catch (Exception ee)
        {
            Label3.Visible = true;
            Label3.Text = ee.Message;
        }
        finally
        {
            //db.dr.Close();
            con.Close();
        }
    }
}
