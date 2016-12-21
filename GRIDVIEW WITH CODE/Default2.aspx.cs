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
using System.Web.Configuration;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    DbConnection db = new DbConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        if (!IsPostBack)
            GriddataBind();
    }
    protected void GriddataBind()
    {
        try
        {
            db.cmd.CommandText = "SELECT * FROM STU";
            db.cmd.Connection = db.con;
            SqlDataAdapter da = new SqlDataAdapter(db.cmd);
            DataSet ds = new DataSet();
            db.con.Open();
            db.cmd.ExecuteNonQuery();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        catch (Exception ee)
        {
            Label1.Visible = true;
            Label1.Text = ee.Message;
        }
        finally
        {

            db.con.Close();
        }

    }
    protected void GridView1_command(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Add")
        {
          TextBox cls =(TextBox) GridView1.FooterRow.FindControl("TextBox4");
          TextBox roll = (TextBox)GridView1.FooterRow.FindControl("TextBox5");
          TextBox name = (TextBox)GridView1.FooterRow.FindControl("TextBox2");
          try
          {
              db.cmd.Connection = db.con;
              db.cmd.CommandText = "INSERT INTO STU VALUES('" + roll.Text + "','" + name.Text + "','" + cls.Text + "')";
              db.con.Open();
              db.cmd.ExecuteNonQuery();
              db.con.Close();
              Label1.Visible = true;
              Label1.Text = "RECORD SUCCESSFULLY ADDED";
          }
          catch (Exception ee)
          {
              Label1.Visible = true;
              Label1.Text = ee.Message;
          }
          finally
          {
              GridView1.EditIndex = -1;
              GriddataBind();
          }

 
        }
    }
    protected void GridView1_Delete(object sender, GridViewDeleteEventArgs e)
    {
        int roll = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
        try
        {
            db.cmd.Connection = db.con;
            db.cmd.CommandText = "delete stu where roll='" + roll + "'";
            db.con.Open();
            db.cmd.ExecuteNonQuery();
            db.con.Close();
            Label1.Visible = true;
            Label1.Text = "SUCCESSFULLY DELETED";
        }
        catch (Exception ee)
        {
            Label1.Visible = true;
            Label1.Text = ee.Message;
        }
        finally
        {
            GridView1.EditIndex = -1;
            GriddataBind();
        }

    }
    protected void GridView1_Edit(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        GriddataBind();

    }
    protected void GridView1_Update(object sender, GridViewUpdateEventArgs e)
    {
        int roll = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
        TextBox cls = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox3");
        TextBox name = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox1");
        try
        {
            db.cmd.Connection = db.con;
            db.cmd.CommandText = "update stu set class='"+cls.Text+"',name='"+name.Text+"'where roll='"+roll+"'";
            db.con.Open();
            db.cmd.ExecuteNonQuery();
            db.con.Close();
            Label1.Visible = true;
            Label1.Text = "RECORD SUCCESSFULLY UPDATED";
        }
        catch (Exception ee)
        {
            Label1.Visible = true;
            Label1.Text = ee.Message;
        }
        finally
        {
            GridView1.EditIndex = -1;
            GriddataBind();
        }
    }
    protected void GridView1_Cancel(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        GriddataBind();
    }
}
