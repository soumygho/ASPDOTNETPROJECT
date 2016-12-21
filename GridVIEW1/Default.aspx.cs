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

public partial class _Default : System.Web.UI.Page 
{
    Connection cn = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label4.Visible = false;

    }
    private void GridDataBind()
    {
        try
        {
            cn.con.Open();
            cn.cmd.CommandText = "SELECT * FROM STUDENT";
            cn.cmd.ExecuteNonQuery();
            cn.Adapter(cn.cmd.CommandText);
            GridView1.DataSource = cn.ds;
            GridView1.DataBind();
        }
        catch (Exception ee)
        {
            Label4.Visible = true;
            Label4.Text = ee.Message;
        }
        finally
        {
            cn.con.Close();
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_Cancel(object sender, GridViewCancelEditEventArgs e)
    {


    }
    protected void GridView1_Add(object sender, GridViewCommandEventArgs e)
    {

    }
    protected void GridView1_Delete(object sender, GridViewDeleteEventArgs e)
    {

    }
    protected void GridView1_Edit(object sender, GridViewEditEventArgs e)
    {

    }
    protected void GridView1_Update(object sender, GridViewUpdateEventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
}
