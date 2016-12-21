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

public partial class STUDENTS : System.Web.UI.Page
{
    dbconnection cn = new dbconnection();
    protected void Page_Load(object sender, EventArgs e)
    {
       if (Session["userid"] == null)
        {
            Response.Redirect("~/Administrative_login.aspx");
        }
       // Panel1.Visible = false;
        Panel2.Visible = false;
        Label1.Visible = false;
        Label2.Visible = false;
       
        if (!IsPostBack)
        {
            Session["tablename"] = null;
        }
       /* try
        {
            cn.cmd.Connection = cn.con;
            cn.cmd.CommandText = "SELECT * from table_name";
            cn.con.Open();
            cn.dr = cn.cmd.ExecuteReader();
           if (IsPostBack)
            {
                if (!DropDownList3.SelectedItem.Text.Equals("-SELECT YEAR-") && !DropDownList4.SelectedItem.Text.Equals("-SELECT CLASS-"))
                {
                    Session["year"] = DropDownList3.SelectedItem.Text;
                    Session["class"] = DropDownList4.SelectedItem.Text;
                }
            }
            DropDownList3.Items.Clear();
            DropDownList4.Items.Clear();
            ListItem li = new ListItem("-SELECT YEAR-","-SELECT YEAR-");
            DropDownList3.Items.Add(li);
            DropDownList4.Items.Add(new ListItem("-SELECT CLASS-","-SELECT CLASS-"));
            if (cn.dr.HasRows)
            {
                while (cn.dr.Read())
                {
                    DropDownList3.Items.Add(new ListItem(cn.dr["year"].ToString(), cn.dr["year"].ToString()));
                    DropDownList4.Items.Add(new ListItem(cn.dr["class"].ToString(), cn.dr["class"].ToString()));
                }
                    Label1.Visible = true;
                    Label1.Text = "SUCCESSFULLY BINDED ";
                    cn.dr.Close();
            }
            

        }
        catch(Exception ee)
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
        if (!IsPostBack)
        {
        
            Panel1.Visible = false;
        }*/
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
        bool flag = true;
        Session["tablename"] = DropDownList1.SelectedValue.ToString() + DropDownList2.SelectedValue.ToString();
        string table_name = DropDownList1.SelectedValue.ToString();
        table_name += DropDownList2.SelectedValue.ToString();
        try
        {
            cn.cmd.Connection = cn.con;
            cn.cmd.CommandText = "select * from table_name";
            cn.con.Open();
            cn.dr = cn.cmd.ExecuteReader();
            if (cn.dr.HasRows)
            {
                while (cn.dr.Read())
                {
                    if (cn.dr["table_name"].ToString().Equals(table_name))
                    {
                        flag = false;
                        break;
                    }
                }
            }
            else
            {
                flag = true;
            }
            cn.dr.Close();
            if (flag)
            {
                Label1.Visible = true;
                Label1.Text = "TABLE NOT YET BEEN CREATED!!!";
                Session["class"] = DropDownList1.SelectedItem.Text;
                Panel2.Visible = true;
            }
            else
            {
                Label1.Visible = true;
                Session["tablename"] = null;
                Session["class"] = null;
                Label1.Text = "TABLE IS AVAILABLE PLEASE GOTO ADD STUDENT RESULT PAGE TO ADD RESULT!!!";
            }
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
       /* string sql_cmd="";
        string table_name = DropDownList1.SelectedValue.ToString();
        table_name += DropDownList2.SelectedValue.ToString();
        try
        {
            sql_cmd = "create table " + table_name + "(name varchar(max),roll int,beng varchar(max),eng varchar(max),hist varchar(max),geo varchar(max),phys varchar(max),math varchar(max),bios varchar(max),edu varchar(max),comp varchar(max),sans varchar(max),evs varchar(max) primary key(roll)) ";
            cn.cmd.Connection = cn.con;
            cn.cmd.CommandText = sql_cmd;
            cn.con.Open();
            cn.cmd.ExecuteNonQuery();
            cn.cmd.CommandText = "INSERT INTO "+table_name+" VALUES('X',1,'2','3','4','5','6','7','8','9','10','11','12')";
            cn.cmd.ExecuteNonQuery();
            cn.cmd.CommandText = "INSERT INTO TABLE_NAME VALUES('"+table_name+"','"+DropDownList1.SelectedValue.ToString()+"','"+DropDownList2.SelectedValue.ToString()+"')";
            cn.cmd.ExecuteNonQuery();
            Label1.Visible = true;
            Label1.Text = "TABLE CREATED TABLE NAME '"+table_name+"'";
        }
        catch (Exception ee)
        {
            Label1.Visible = true;
            Label1.Text = ee.Message;
        }
        finally
        {
            cn.con.Close();
        }*/
    }
  /*  protected void Button2_Click(object sender, EventArgs e)
    {
        //Session["year"] = DropDownList3.SelectedItem.Text;
        //Session["class"] = DropDownList4.SelectedItem.Text;
        Panel1.Visible = true;
       // Int32 a = Int32.Parse(Session["year"].ToString());
       // Label15.Text = a.ToString();
        //Label1.Visible = true;
        //Label1.Text = Session["year"].ToString()+Session["class"].ToString();
        try
        {
            cn.con.Open();
            cn.cmd.Connection = cn.con;
            cn.cmd.CommandText = "SELECT table_name FROM table_name where year='"+Session["year"].ToString()+"' and class='"+Session["class"]+"'";
            cn.dr = cn.cmd.ExecuteReader();
            if (cn.dr.HasRows)
            {
                while (cn.dr.Read())
                {
                    Session["table_name"] = cn.dr["table_name"].ToString();
                }
            }
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            cn.dr.Close();
            cn.con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
      //  GridView1.EditIndex = -1;
      //  BindGridData();
        }
    }*/
   /* protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Add")
        {
            TextBox roll = (TextBox)GridView1.FooterRow.FindControl("TextBox4");
            int ROLL = Convert.ToInt32(roll.Text);
            TextBox name = (TextBox)GridView1.FooterRow.FindControl("TextBox2");
            TextBox beng = (TextBox)GridView1.FooterRow.FindControl("TextBox6");
            TextBox eng = (TextBox)GridView1.FooterRow.FindControl("TextBox8");
            TextBox hist = (TextBox)GridView1.FooterRow.FindControl("TextBox10");
            TextBox geo = (TextBox)GridView1.FooterRow.FindControl("TextBox12");
            TextBox phys = (TextBox)GridView1.FooterRow.FindControl("TextBox14");
            TextBox math = (TextBox)GridView1.FooterRow.FindControl("TextBox16");
            TextBox bios = (TextBox)GridView1.FooterRow.FindControl("TextBox18");
            TextBox edu = (TextBox)GridView1.FooterRow.FindControl("TextBox20");
            TextBox comp = (TextBox)GridView1.FooterRow.FindControl("TextBox22");
            TextBox sans = (TextBox)GridView1.FooterRow.FindControl("TextBox24");
            TextBox evs = (TextBox)GridView1.FooterRow.FindControl("TextBox26");
            try
            {
                cn.cmd.Connection = cn.con;
                cn.cmd.CommandText = "INSERT INTO "+Session["table_name"].ToString()+" values('" + name.Text + "'," + ROLL + ",'" + beng.Text + "','" + eng.Text + "','" + hist.Text+ "','"+geo.Text+"','"+phys.Text+"','"+math.Text+"','"+bios.Text+"','"+edu.Text+"','"+comp.Text+"','"+sans.Text+"','"+evs.Text+"')";
                cn.con.Open();
                cn.cmd.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                Label1.Visible = true;
                Label1.Text = ee.Message;
            }
            finally
            {

                cn.con.Close();
                GridView1.EditIndex = -1;
                BindGridData();
            }

        }

    }
    protected void GridView1_Cancel(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex=-1;
        BindGridData();
    }
    protected void GridView1_Delete(object sender, GridViewDeleteEventArgs e)
    {
         int m = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
        try
        {
            cn.cmd.Connection = cn.con;
            cn.cmd.CommandText = "delete "+Session["table_name"].ToString()+" where roll="+m+"";
            cn.con.Open();
            cn.cmd.ExecuteNonQuery();
        }
        catch (Exception ee)
        {
            Label1.Visible = true;
            Label1.Text = ee.Message;
        }
        finally
        {

            cn.con.Close();
            GridView1.EditIndex = -1;
            BindGridData();
        }
    }
    protected void GridView1_Edit(object sender, GridViewEditEventArgs e)
    {
            GridView1.EditIndex=e.NewEditIndex;
            BindGridData();
    }
    protected void GridView1_Update(object sender, GridViewUpdateEventArgs e)
    {
         int roll =Convert.ToInt32( GridView1.DataKeys[e.RowIndex].Value.ToString());
            
            TextBox name = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox1");
       // int NAME=Convert.ToInt32(name.Text);
            TextBox beng = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox5");
        //int BENG=Convert.ToInt32(beng.Text);
        TextBox eng = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox7");
        //int ENG=Convert.ToInt32(eng.Text);
        TextBox hist = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox9");
        //int HIST=Convert.ToInt32(hist.Text);
        TextBox geo = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox11");
        //int GEO=Convert.ToInt32(geo.Text);
        TextBox phys = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox13");
        //int PHYS=Convert.ToInt32(phys.Text);
        TextBox math = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox15");
        //int MATH=Convert.ToInt32(math.Text);
        TextBox bios = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox17");
        //int BIOS=Convert.ToInt32(bios.Text);
        TextBox edu = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox19");
        //int EDU=Convert.ToInt32(edu.Text);
        TextBox comp = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox21");
       // int COMP=Convert.ToInt32(comp.Text);
        TextBox sans = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox23");
        //int SANS=Convert.ToInt32(sans.Text);
        TextBox evs = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox25");
        //int EVS=Convert.ToInt32(evs.Text);
         try
        {
            cn.cmd.Connection = cn.con;
            cn.cmd.CommandText = "update "+Session["table_name"].ToString()+" set name='"+name.Text+"',beng='"+beng.Text+"',eng='"+eng.Text+"',hist='"+hist.Text+"',geo='"+geo.Text+"',phys='"+phys.Text+"',math='"+math.Text+"',bios='"+bios.Text+"',edu='"+edu.Text+"',comp='"+comp.Text+"',sans='"+sans.Text+"',evs='"+evs.Text+"' where roll="+roll+"";
            cn.con.Open();
            cn.cmd.ExecuteNonQuery();
        }
        catch (Exception ee)
        {
            Label1.Visible = true;
            Label1.Text = ee.Message;
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
            cn.cmd.CommandText = "select * from "+Session["table_name"].ToString()+"";
            SqlDataAdapter da = new SqlDataAdapter(cn.cmd);
            DataSet ds = new DataSet();
            cn.cmd.ExecuteNonQuery();
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
            cn.con.Close();
        }
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("~/Home.aspx");
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }*/
    protected void Button3_Click(object sender, EventArgs e)
    {
        
        int subjectno = Int32.Parse(TextBox1.Text.Trim());
        Session["num"] = subjectno;
        Session["year"] = DropDownList2.SelectedItem.Text;
        Response.Redirect("~/insertsubject.aspx");
    }
  /*  protected void submit_Click(object sender, EventArgs e)
    {
        int i = Int32.Parse(Session["num"].ToString());
        int j = 1;
        string tablename = Session["tablename"].ToString();
        String sqlcmd = "create table " + tablename + "(name varchar(max),roll int,";
        while (j <= i)
        {
           TextBox sub =(TextBox) Panel1.FindControl("subjectname" + i.ToString());
           String subject = sub.Text;
           if (j < i)
           {
               sqlcmd += "'" + subject + "',";
           }
           else
           {
               sqlcmd += "'" + subject + "'";
           }
            j++;
        }
        try
        {
            cn.con.Open();
            cn.cmd.CommandText = sqlcmd;
            cn.cmd.Connection = cn.con;
            cn.cmd.ExecuteNonQuery();
            cn.cmd.CommandText = "INSERT INTO TABLE_NAME VALUES('" + tablename + "','" + DropDownList1.SelectedValue.ToString() + "','" + DropDownList2.SelectedValue.ToString() + "')";
            cn.cmd.ExecuteNonQuery();
            Label2.Visible = true;
            Label2.Text = "TABLE SUCCESSFULLY CREATED IN THE DATABASE!!" + Session["tablename"].ToString();
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
    }*/
    protected void LinkButton6_Click(object sender, EventArgs e)
    {

    }
}
