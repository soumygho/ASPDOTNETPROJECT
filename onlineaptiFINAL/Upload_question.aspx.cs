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

public partial class Upload_question : System.Web.UI.Page
{
    DatabaseConnection data = new DatabaseConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["adminid"] != null)
        {
            if (Session["count"] == null)
            {
                int COUNT = 0;
                try
                {
                    data.con.Open();
                    data.cmd.CommandText = "Select * from question";
                    data.cmd.Connection = data.con;
                    data.dr = data.cmd.ExecuteReader();
                    if (data.dr.HasRows)
                    {
                        while (data.dr.Read())
                        {
                            COUNT++;
                        }
                    }
                    Session["count"] = COUNT.ToString();
                }
                catch (Exception ee)
                {
                    Label7.Visible = true;
                    Label7.Text = ee.Message;
                }
                finally
                {
                    data.dr.Close();
                    data.con.Close();
                }
            }
            Label8.Text = Session["count"].ToString();
            if (!IsPostBack)
            {
                Label7.Visible = false;
                bindGridData();
            }
        }
        else
        {
            Response.Redirect("~/Admin_login.aspx");
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Cancel(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        bindGridData();
    }
    protected void Delete(object sender, GridViewDeleteEventArgs e)
    {
        int id = int.Parse(GridView1.DataKeys[e.RowIndex].Value.ToString());
        try
        {
            data.con.Open();
            data.cmd.CommandText = "delete question where quesid = "+ id.ToString();
            data.cmd.Connection = data.con;
            data.cmd.ExecuteNonQuery();
            Session["count"] = int.Parse(Session["count"].ToString()) - 1;
            Label8.Text = Session["count"].ToString();
        }
        catch (Exception ee)
        {
            Label7.Visible = true;
            Label7.Text = ee.Message;
        }
        finally
        {
            data.con.Close();
            GridView1.EditIndex = -1;
            bindGridData();
        }
    }
    protected void Edit(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        bindGridData();
    }
    protected void Update(object sender, GridViewUpdateEventArgs e)
    {
        TextBox TextBox1 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox2");
        TextBox TextBox2 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox4");
        TextBox TextBox3 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox6");
        TextBox TextBox4 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox8");
        TextBox TextBox5 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox10");
        TextBox TextBox6 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox12");
        int id = int.Parse(GridView1.DataKeys[e.RowIndex].Value.ToString());
        try
        {
            data.con.Open();
            data.cmd.CommandText = "update question set question='"+TextBox1.Text+"',optiona='"+TextBox2.Text+"',optionb='"+TextBox3.Text+"',optionc='"+TextBox4.Text+"',optiond='"+TextBox5.Text+"',ans='"+TextBox6.Text+"' where quesid ="+id.ToString();
            data.cmd.Connection = data.con;
            data.cmd.ExecuteNonQuery();
        }
        catch (Exception ee)
        {
            Label7.Visible = true;
            Label7.Text = ee.Message;
        }
        finally
        {
            data.con.Close();
            GridView1.EditIndex = -1;
            bindGridData();
        }
    }
    private void bindGridData()
    {
        try
        {
            data.con.Open();
            data.cmd.CommandText = "Select * from question";
            data.cmd.Connection = data.con;
            SqlDataAdapter da = new SqlDataAdapter(data.cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        catch (Exception ee)
        {
            Label7.Visible = true;
            Label7.Text = ee.Message;
        }
        finally
        {
            data.con.Close();
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("~/Admin_login.aspx");
    }
    protected void Add(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.ToString().Equals("Add"))
        {
            TextBox TextBox1 = (TextBox)GridView1.FooterRow.FindControl("TextBox3");
            TextBox TextBox2 = (TextBox)GridView1.FooterRow.FindControl("TextBox5");
            TextBox TextBox3 = (TextBox)GridView1.FooterRow.FindControl("TextBox7");
            TextBox TextBox4 = (TextBox)GridView1.FooterRow.FindControl("TextBox9");
            TextBox TextBox5 = (TextBox)GridView1.FooterRow.FindControl("TextBox11");
            TextBox TextBox6 = (TextBox)GridView1.FooterRow.FindControl("TextBox13");
            try
            {
                data.con.Open();
                data.cmd.CommandText = "insert into question (question,optiona,optionb,optionc,optiond,ans) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "') ";
                data.cmd.Connection = data.con;
                data.cmd.ExecuteNonQuery();
                Session["count"] = int.Parse(Session["count"].ToString()) + 1;
                Label8.Text = Session["count"].ToString();
            }
            catch (Exception ee)
            {
                Label7.Visible = true;
                Label7.Text = ee.Message;
            }
            finally
            {
                data.con.Close();
                GridView1.EditIndex = -1;
                bindGridData();
            }
        }
    }
}
