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

public partial class Default2 : System.Web.UI.Page
{
    DBCONNECTION CN = new DBCONNECTION();
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\DELL\\REGISTRATION\\App_Data\\ACCOUNT_LOGIN.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dr;
    bool flag = false;
    string name,user,email,rel,nat,mob,pass,gen,lang,add,zip,dob,alt_email,ans_1,ans_2;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        Label6.Visible = false;
        Label8.Visible = false;
        if (!IsPostBack)
        {
            Panel2.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Label1.Visible = false;
            Label2.Visible = true;
            Panel1.Visible = false;
            TextBox22.Enabled = false;
            TextBox7.Enabled = false;
            TextBox9.Enabled = false;
        }

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {
        int len;
        len = TextBox4.Text.Length;
        if (len < 8)
        {
            Label2.Text = "PLEASE ENTER ATLEAST 8 CHARACTERS";
        }
        else if (len >= 8 && len <= 10)
        {
            Label2.Text = "PASSWORD STRENGTH : GOOD";
        }
        else
        {
            Label2.Text = "PASSWORD STRENGTH : STRONG";
        }
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex != 9)
        {
            Session["a"] = DropDownList1.SelectedItem.Text.Replace("'", "''");
        }
        else
        {
            Panel2.Visible = true;
            Session["a"] = TextBox12.Text.Replace("'","''");
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList2.SelectedIndex != 9)
        {
            Session["b"] = DropDownList2.SelectedItem.Text.Replace("'", "''");
        }
        else
        {
            Panel5.Visible = true;
            Session["b"] = TextBox21.Text.Replace("'","''");
        }
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        name = TextBox1.Text + TextBox2.Text;
        email = TextBox22.Text;
        user = TextBox3.Text;
        mob = TextBox9.Text;
        pass = TextBox4.Text;
        dob = DropDownList3.SelectedItem.Text+"-"+ DropDownList4.SelectedItem.Text+"-"+ DropDownList5.SelectedItem.Text;
        gen = RadioButtonList1.SelectedItem.Text;
        lang =CheckBoxList1.SelectedItem.Text ;
        add = TextBox19.Text;
        zip = TextBox20.Text;
        rel = TextBox17.Text;
        nat = TextBox18.Text;
        alt_email = TextBox7.Text;
        ans_1 = TextBox11.Text;
        ans_2 = TextBox14.Text;
        Session["PASSWORD"] = pass;
        try
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO FORM (NAME,EMAIL,USERID,ALT_EMAIL,MOB,GENDER,LANG,SEC_QUES_1,ANS_1,SEC_QUES_2,ANS_2,REL,NAT,ADDRESS,ZIP,DOB,PASSWORD)VALUES('"+name+"','"+email+"','"+user+"','"+alt_email+"','"+mob+"','"+gen+"','"+lang+"','"+Session["a"].ToString()+"','"+ans_1+"','"+Session["b"].ToString()+"','"+ans_2+"','"+rel+"','"+nat+"','"+add+"','"+zip+"','"+dob+"','"+pass+"')";
            cmd.ExecuteNonQuery();
            Label6.Visible = false;
            Response.Redirect("SHOW.aspx");
        }
        catch (Exception ee)
        {
            Label6.Visible = true;
            Label6.Text = ee.Message;
        }
        finally
        {
            con.Close();
        }

    }
    protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox2.Checked == true)
            Panel4.Visible = true;
        else
            Panel4.Visible = false;
    }
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox3_TextChanged1(object sender, EventArgs e)
    {
       

    }
    protected void CHECK_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT USERID FROM FORM";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (TextBox3.Text == dr["USERID"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            dr.Close();
            if (flag)
            {
                Label1.Visible = true;
                Label1.Text = "THIS USER ID HAS BEEN USED!!!";
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "CONGRATS!!! THIS USER-ID IS AVAILABLE";
                Panel1.Visible=true;
                TextBox7.Enabled = true;
                TextBox9.Enabled = true;
                TextBox22.Enabled = true;
                Session["UNAME"] = TextBox3.Text;
            }
        }
        catch (Exception ee)
        {
            Label1.Visible = true;
            Label1.Text = ee.Message;
        }
        finally
        {
            con.Close();
        }

    }
    protected void TextBox9_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {

    }
    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
protected void  TextBox10_TextChanged(object sender, EventArgs e)
{
    bool flag = false;
    try
    {
        CN.con.Open();
        CN.cmd.Connection = CN.con;
        CN.cmd.CommandText = "SELECT EMAIL FROM FORM";
        CN.dr = CN.cmd.ExecuteReader();
        while (CN.dr.Read())
        {
            if (CN.dr["EMAIL"].ToString() == TextBox22.Text)
            {
                flag = true;
                break;
            }

        }
         CN.dr.Close();
        if (flag)
        {
            Label8.Visible = true;
            Label8.Text = "THIS EMAIL ID IS ALREADY USED";

        }
        else
        {
            Label8.Visible = true;
            Label8.Text = "EMAIL ID AVAILABLE";
        }
    }
    catch (Exception ee)
    {
        Label8.Visible = true;
        Label8.Text = ee.Message;
    }
    finally
    {
        CN.con.Close();
    }
}
}
