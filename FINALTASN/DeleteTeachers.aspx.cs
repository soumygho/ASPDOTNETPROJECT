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

public partial class DeleteTeachers : System.Web.UI.Page
{
    private dbconnection database = new dbconnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null)
        {
            Response.Redirect("~/Administrative_login.aspx");
        }
        Label4.Visible = false;
        bindData();
    }
    private void bindData()
    {
        try
        {
            database.con.Open();
            database.cmd.CommandText = "select * from teacher";
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool FLAG = false;
        try
        {
            String name = "";
            database.con.Open();
            database.cmd.CommandText = "select * from teacher where path= @path";
            database.cmd.Parameters.AddWithValue("path", TextBox1.Text.ToString().Trim());
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
                Label4.Visible = true;
                Label4.Text = "RECORD NOT FOUND";
            }
            database.dr.Close();
            if (!name.Equals(""))
            {
                bool delete = false;
                if (!FLAG)
                {
                    String path = Server.MapPath("~/TEACHER PIC");
                    path += "\\" + name;
                    File.Delete(path);
                    delete = true;
                }
                if (delete)
                {
                    database.cmd.CommandText = "delete from teacher where path = '" + name + "'";
                    database.cmd.ExecuteNonQuery();
                    Label4.Visible = true;
                    Label4.Text = "FILE SUCCESSFULLY DELETED!!!";
                }
                else
                {
                    Label4.Visible = true;
                    Label4.Text = "FILE OPERATION UNSUCCESSFUL!!!";
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
}
