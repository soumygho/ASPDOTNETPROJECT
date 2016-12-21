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

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Text = null;
        dbconnection();
    }
    protected void dbconnection()
    {
        string cn = ConfigurationManager.ConnectionStrings["CONNECTION1"].ConnectionString;
        SqlConnection con = new SqlConnection(cn);
        SqlCommand cmd = new SqlCommand("SELECT * FROM BOOKID",con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        try
        {
            da.Fill(ds, "id");
            cmd.CommandText = "SELECT * FROM bookdet";
            da.Fill(ds, "det");
            DataRelation id_det = new DataRelation("FK_bookdet_BOOKID", ds.Tables["id"].Columns["id"], ds.Tables["det"].Columns["id"]);
            ds.Relations.Add(id_det);
            foreach (DataRow rowid in ds.Tables["id"].Rows)
            {
                Label2.Text += "<b>" + rowid["id"] + "<br/>";
                //}
                foreach (DataRow rowdet in rowid.GetChildRows(id_det))
                //foreach(DataRow rowdet in ds.Tables["det"].Rows)
                {
                    Label2.Text += "<img src='"+rowdet["url"]+"'/>"+"<br/>";
                    Label2.Text += rowdet["name"].ToString() + "<br/>";
                    Label2.Text += rowdet["isbn"].ToString() + "<br/>";
                    Label2.Text += rowdet["cat"].ToString() + "<br/>" + rowdet["auth_name"].ToString() + "<br/>" + rowdet["pub_date"].ToString() + "<br/>" + rowdet["edit"].ToString() + "<br/></b>";
                }
            }
        }
        catch (Exception ee)
        {
            Label2.Text += ee.Message;
        }
        finally
        {
            con.Close();
        }
    }
}
