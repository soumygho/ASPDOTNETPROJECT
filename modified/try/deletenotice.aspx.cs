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

public partial class deletenotice : System.Web.UI.Page
{
    private dbconnection database = new dbconnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null)
        {
            Response.Redirect("~/Administrative_login.aspx");
        }
        Label2.Visible = false;
        bindData();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool FLAG = false;
        try
        {
            String name = "";
            database.con.Open();
            database.cmd.CommandText = "select * from notice where id = @id";
            database.cmd.Parameters.AddWithValue("id", TextBox1.Text);
            database.cmd.Connection = database.con;
            database.dr = database.cmd.ExecuteReader();
            if (database.dr.HasRows)
            {
                while (database.dr.Read())
                {
                    name = database.dr["path"].ToString();
                }
            }
            else
            {
                Label2.Visible = true;
                Label2.Text = "NOTICE NOT FOUND";
            }
            database.dr.Close();
            if (!name.Equals(""))
            {
                bool delete = false;
                if (!FLAG)
                {
                    String path = Server.MapPath("~/NOTICES");
                    path += "\\" + name;
                    File.Delete(path);
                    delete = true;
                }
                if (delete)
                {
                    database.cmd.CommandText = "delete from notice where path = '" + name + "'";
                    database.cmd.ExecuteNonQuery();
                    Label2.Visible = true;
                    Label2.Text = "FILE SUCCESSFULLY DELETED!!!";
                }
                else
                {
                    Label2.Visible = true;
                    Label2.Text = "FILE OPERATION UNSUCCESSFUL!!!";
                }
            }

        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            database.con.Close();
            bindData();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
    private void bindData()
    {
        try
        {
            database.con.Open();
            database.cmd.CommandText = "select * from notice";
            database.cmd.Connection = database.con;
            SqlDataAdapter da = new SqlDataAdapter(database.cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            database.con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
}
