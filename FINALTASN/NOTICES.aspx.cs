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
using System.IO;
using System.Net;

public partial class NOTICES : System.Web.UI.Page
{
    dbconnection cn = new dbconnection();
    protected void Page_Load(object sender, EventArgs e)
    {
       /* Label6.Visible = false;
        if (!IsPostBack)
            BindGridData();*/
        Label1.Visible = false;
        if (Session["userid"] == null)
        {
            Response.Redirect("~/Administrative_login.aspx");
        }


    }
   /* protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Add")
        {
            TextBox id = (TextBox)GridView1.FooterRow.FindControl("TextBox1");
            int ID = Convert.ToInt32(id.Text);
            TextBox sub = (TextBox)GridView1.FooterRow.FindControl("TextBox3");
            TextBox body = (TextBox)GridView1.FooterRow.FindControl("TextBox5");
            TextBox date = (TextBox)GridView1.FooterRow.FindControl("TextBox7");
            TextBox frm = (TextBox)GridView1.FooterRow.FindControl("TextBox9");
            try
            {
                cn.cmd.Connection = cn.con;
                cn.cmd.CommandText = "INSERT INTO notice values('"+ID+"','"+sub.Text+"','"+body.Text+"','"+date.Text+"','"+frm.Text+"')";
                SqlDataAdapter da = new SqlDataAdapter(cn.cmd);
                DataSet ds = new DataSet();
                cn.con.Open();
                cn.cmd.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                Label6.Visible = true;
                Label6.Text = ee.Message;
            }
            finally
            {

                cn.con.Close();
                GridView1.EditIndex = -1;
                BindGridData();
            }

        }
    }
    protected void GridView1_RowDelete(object sender, GridViewDeleteEventArgs e)
    {
        int m = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
        try
        {
            cn.cmd.Connection = cn.con;
            cn.cmd.CommandText = "delete notice where id='"+m+"'";
            cn.con.Open();
            cn.cmd.ExecuteNonQuery();
        }
        catch (Exception ee)
        {
            Label6.Visible = true;
            Label6.Text = ee.Message;
        }
        finally
        {

            cn.con.Close();
            GridView1.EditIndex = -1;
            BindGridData();
        }
    }
    protected void GridView1_RowEdit(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        BindGridData();
    }
    protected void GridView1_RowUpdate(object sender, GridViewUpdateEventArgs e)
    {
        int m = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
        TextBox sub = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox2");
        TextBox body = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox4");
        TextBox date = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox6");
        TextBox frm = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox8");
        try
        {
            cn.cmd.Connection = cn.con;
            cn.cmd.CommandText = "update notice set sub='"+sub.Text+"',body='"+body.Text+"',date='"+date.Text+"',frm='"+frm.Text+"' where id='"+m+"'";
            cn.con.Open();
            cn.cmd.ExecuteNonQuery();
        }
        catch (Exception ee)
        {
            Label6.Visible = true;
            Label6.Text = ee.Message;
        }
        finally
        {

            cn.con.Close();
            GridView1.EditIndex = -1;
            BindGridData();
        }

    }
    protected void BindGridData()
    {
        try
        {
            cn.con.Open();
            cn.cmd.Connection = cn.con;
            cn.cmd.CommandText = "SELECT * FROM notice";
            SqlDataAdapter da = new SqlDataAdapter(cn.cmd);
            DataSet ds = new DataSet();
            cn.cmd.ExecuteNonQuery();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        catch(Exception ee)
        {
            Label6.Visible = true;
            Label6.Text = ee.Message;
        }
        finally
        {
            cn.con.Close();
        }
    }
    protected void GridView1_Cancel(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        BindGridData();
    }*/
    protected void Submit_Click(object sender, EventArgs e)
    {
       
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        bool flag = false;
        if (FileUpload1.HasFile)
        {
            try
            {
                String ext = Path.GetExtension(FileUpload1.FileName);
                String path = TextBox1.Text + DateTime.Today.ToShortDateString().ToString().Replace('/', '_');
                FileUpload1.SaveAs(Server.MapPath("~/NOTICES") + "\\" + path + ext);
                path = path + ext;
                Label1.Visible = true;
                Label1.Text = "SUCCESSFULLY UPLOADED!!!";
                flag = true;
                if (flag)
                {
                    try
                    {
                        cn.con.Open();
                        cn.cmd.CommandText = "insert into notice (path,date,sub) values('" + path + "','" + DateTime.Today.ToShortDateString().ToString() + "','" + TextBox1.Text + "')";
                        cn.cmd.Connection = cn.con;
                        cn.cmd.ExecuteNonQuery();
                    }
                    catch (Exception ee)
                    {
                        Session["error"] = ee.Message;
                    }
                    finally
                    {
                        cn.con.Close();
                        if (Session["error"] != null)
                        {
                            Response.Redirect("~/error.aspx");
                        }
                    }
                }
            }
            catch (Exception ee)
            {
                Session["error"] = ee.Message;
            }
            finally
            {
                if (Session["error"] != null)
                {
                    Response.Redirect("~/error.aspx");
                }
            }

        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "NO FILE SELECTED";
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("~/index.aspx");
    }
}
