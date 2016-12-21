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
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=F:\\SOUMYA\\gridview\\App_Data\\STUDENT.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlCommand cmd = new SqlCommand();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GridBind();
        }
    }
    protected void GridBind()
    {
        con.Open();
        cmd.CommandText = "SELECT * FROM STU";
        SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText,con);
        da.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        GridBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
      //  string stuid = GridView1.DataKeys[e.RowIndex].Values["Label5"].ToString();//
        string stuid =GridView1.DataKeys[e.RowIndex].Value.ToString();

        TextBox stuname = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox1");
        TextBox stuaddress = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox3");
        TextBox sturoll = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox5");
        TextBox stucourse = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox9");
        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "update STU set st_name='"+stuname.Text+"',st_address='"+stuaddress.Text+"',st_roll='"+sturoll.Text+"',st_course='"+stucourse.Text+"' where st_id='"+stuid+"'";
        cmd.ExecuteNonQuery();
        GridView1.EditIndex = -1;
        con.Close();
        GridBind();


    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        GridBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
