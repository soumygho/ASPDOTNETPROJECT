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
using System.Windows.Forms;
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool flag = false;
        if (FileUpload1.HasFile)
        {
            try
            {
                String ext = Path.GetExtension(FileUpload1.FileName);
                String path = TextBox1.Text + DateTime.Today.ToShortDateString().ToString().Replace('/','.'); ;
                FileUpload1.SaveAs(Server.MapPath("~/NOTICES") + "/" + path+"."+ext);
                path = Server.MapPath("~/NOTICES") + "/" + path;
                MessageBox.Show("SUCCESSFULLY UPLOADED!!!");
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
                        MessageBox.Show("Error occured:" + ee.Message);
                    }
                    finally
                    {
                        cn.con.Close();
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("ERROR OCCURED: " + ee.Message);
            }

        }
        else
        {
            MessageBox.Show("NO FILE SELECTED!!");
        }
    }
}
