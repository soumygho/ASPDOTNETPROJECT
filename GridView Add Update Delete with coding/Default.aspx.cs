using System;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class _Default : System.Web.UI.Page 
{
    DatabaseConnection cn = new DatabaseConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGridData();
        }
    }
    protected void BindGridData()
    {
        try
        {
            cn.con.Open();
            cn.cmd.Connection = cn.con;
            cn.cmd.CommandText = "Select *from student";
            cn.dr = cn.cmd.ExecuteReader();
            GridView1.DataSource = cn.dr;
            GridView1.DataBind();
        }
        catch (Exception pm)
        {
            Label5.Text = pm.Message;
        }
        finally
        {
            cn.dr.Close();
            cn.con.Close();
        }
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        BindGridData();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {

        GridView1.EditIndex  = e.NewEditIndex;
        BindGridData();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int roll = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
        TextBox name = GridView1.Rows[e.RowIndex].FindControl("TextBox1") as TextBox;
        TextBox cls = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox3");
        TextBox sec = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox4");

        try
        {
            cn.con.Open();
            cn.cmd.Connection = cn.con;
            cn.cmd.CommandText = "Update student set stuname='" + name.Text + "',class='" + cls.Text + "',sec='" + sec.Text + "' where roll='" + roll + "'";
            cn.cmd.ExecuteNonQuery();
            cn.con.Close();
            Label5.Text = "Update Successfully";
            GridView1.EditIndex = -1;
            BindGridData();


        }
        catch (Exception pm)
        {
            Label5.Text = pm.Message;
        }
        finally
        {
            cn.con.Close();
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("AddData"))
        {
            TextBox name = (TextBox)GridView1.FooterRow.FindControl("TextBox5");
            TextBox rol = (TextBox)GridView1.FooterRow.FindControl("TextBox6");

            TextBox cls = (TextBox)GridView1.FooterRow.FindControl("TextBox7");

            TextBox sec = (TextBox)GridView1.FooterRow.FindControl("TextBox8");
            try
            {
                cn.con.Open();
                cn.cmd.Connection = cn.con;
                cn.cmd.CommandText = "insert into student values('" + name.Text + "','" + rol.Text + "','" + cls.Text + "','" + sec.Text + "') ";

                cn.cmd.ExecuteNonQuery();
                cn.con.Close();
                Label5.Text = "Insert Successfully";
                GridView1.EditIndex = -1;
                BindGridData();
            }
            catch (Exception pm)
            {
                Label5.Text = pm.Message;

            }
            finally
            {
                cn.con.Close();
            }

        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
