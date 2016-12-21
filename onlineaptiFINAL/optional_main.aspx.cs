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

public partial class optional_main : System.Web.UI.Page
{
    DatabaseConnection data = new DatabaseConnection();
    int[] array = new int[70];
    char[] submit;
    ArrayList<QuestionDeatails> questiondetailslist = new ArrayList();
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["testvoid"] = "false";
        if (Session["username"] == null)
        {
            Session["testvoid"] = null;
            Response.Redirect("~/HOMEPAGE.aspx");
        }
        if (Session["size"] != null)
        {
            if (!IsPostBack)
            {

                Timer1.Enabled = true;
                Timer2.Enabled = true;
                Label7.Text = DateTime.UtcNow.ToString();
                Label8.Text = DateTime.Now.TimeOfDay.ToString();
                Button3.Visible = true;
                Session["optional_main"] = "true";
                Session["timetaken"] = null;
                if (Session["count"] == null)
                    Session["count"] = 0;
                // Session["click"] =   false;
                // Session["test"] = 1;
                int lm = 1;
                Button2.Visible = false;
                Label6.Visible = false;
                Label4.Visible = false;
                // Label5.Text = lm.ToString();
                Random rd = new Random();
                int minimum1 = 0;
                int maximum1 = 0;
                int minimum2 = 0;
                int maximum2 = 0;
                int Max = 0;
                int now = 0;
                
                if (Session["submitted"] != null)
                {

                }
                else
                {
                    Label4.Visible = true;
                    Label4.Text = "nothing selected please select an answer";
                }
            }
        }
    }
   /* protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int m;
        try
        {
             m = int.Parse(ListBox1.SelectedItem.Value.ToString());
            // Label5.Text = m.ToString();
        }
        catch
        {
             ListBox1.SelectedIndex = 1;
             m =int.Parse( ListBox1.SelectedValue.ToString());
        }
        try
        {
            data.con.Open();
            data.cmd.CommandText = "Select * from QUESTION ";
            data.cmd.Connection = data.con;
            data.dr = data.cmd.ExecuteReader();
            if (data.dr.HasRows)
            {
                while (data.dr.Read())
                {
                    if (data.dr["quesid"].ToString().Equals(m.ToString()))
                    {
                       // int n = 1;
                        Label1.Text = ListBox1.SelectedItem.Text;
                        Label2.Text = data.dr["question"].ToString();
                        RadioButton1.Text = data.dr["optiona"].ToString();
                        RadioButton2.Text = data.dr["optionb"].ToString();
                        RadioButton3.Text = data.dr["optionc"].ToString();
                        RadioButton4.Text = data.dr["optiond"].ToString();
                        break;
                    }
                }
            }
        }
        catch (Exception ee)
        {
            Label4.Visible = true;
            Label4.Text = ee.Message;
        }
        finally
        {
            //Label1.Text = array[0].ToString();
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
           // UpdatePanel4.Update();
            data.dr.Close();
            data.con.Close();
        }
    }*/
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        if (int.Parse(Session["totaltime"].ToString()) > 0)
        {
            Label3.Text = Session["totaltime"].ToString();
            Session["totaltime"] = int.Parse(Session["totaltime"].ToString()) - 1;
            if (Session["submitted"] != null)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    array[j] = 0;
                }
                submit = Session["submitted"].ToString().ToCharArray();
                int m = 0;
                String temp = null;
                int k = 0;
                while (m != submit.Length)
                {
                    if (submit[m] == '/')
                    {
                        array[k] = int.Parse(temp);
                        temp = null;
                        m++;
                        k++;
                        continue;
                    }
                    temp += submit[m].ToString();
                    m++;
                }
                k = 0;
                while (array[k] != 0)
                {
                    if (int.Parse(Label1.Text) == array[k])
                    {
                        Button1.Enabled = false;
                        Label4.Visible = true;
                        Label4.Text = "YOU HAVE SUBMITTED THIS ONE PLEASE SELECT ANOTHER";
                        break;
                    }
                    else
                    {
                        Button1.Enabled = true;
                        Label4.Visible = false;
                    }
                    k++;
                }
                if (int.Parse(Session["count"].ToString()) == int.Parse(Session["size"].ToString()))
                {
                    Label4.Visible = true;
                    Label4.Text = "ALL HAS BEEN SUBMITTED PLEASE SEE THE RESULT";
                    Timer1.Enabled = false;
                    Button1.Visible = false;
                    Button2.Visible = true;
                    Button3.Visible = false;
                    Session["timetaken"] = (int.Parse(Session["totaltime"].ToString())-int.Parse(Label3.Text)).ToString();
                    Response.Redirect("~/Result.aspx");
                }
            }
            else
            {
                //Timer1.Enabled = false;
                Label4.Visible = false;
                
                Button1.Visible = true;
                Button1.Enabled = true;
                Button2.Visible = false;
            }

        }
        else if (int.Parse(Session["totaltime"].ToString())==0)
        {
            //ListBox1.Enabled = false;
            Timer1.Enabled = false;
            Button3.Visible = false;
            UpdatePanel4.Update();
            Label4.Visible = true;
            Label4.Text = "YOU ARE TIME OUT PLEASE SEE THE RESULT";
            Button2.Visible = true;
            Label3.Text = Session["totaltime"].ToString();
            Session["timetaken"] = Session["totaltime"].ToString();
            Button1.Enabled = false;
            Response.Redirect("~/Result.aspx");
        }
    }
  /*  protected void Timer2_Tick(object sender, EventArgs e)
    {
       // Label4.Text = Session["test"].ToString();
       // Session["test"] = int.Parse(Session["test"].ToString()) + 1;
       // Label4.Text = Session["test"].ToString();
        if (int.Parse(Session["totaltime"].ToString())==1)
        {
           // UpdatePanel5.Update();
            ListBox1.Enabled = false;
        }
    }*/
 /*  protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int m;
        try
        {
            m = int.Parse(ListBox1.SelectedItem.Value.ToString());
        }
        catch
        {
            ListBox1.SelectedIndex = 1;
            m = int.Parse(ListBox1.SelectedValue.ToString());
        }
        try
        {
            data.con.Open();
            data.cmd.CommandText = "Select * from QUESTION ";
            data.cmd.Connection = data.con;
            data.dr = data.cmd.ExecuteReader();
            if (data.dr.HasRows)
            {
                while (data.dr.Read())
                {
                    if (data.dr["quesid"].ToString().Equals(m.ToString()))
                    {
                        // int n = 1;
                        Label1.Text = ListBox1.SelectedItem.Text;
                        Label2.Text = data.dr["question"].ToString();
                        RadioButton1.Text = data.dr["optiona"].ToString();
                        RadioButton2.Text = data.dr["optionb"].ToString();
                        RadioButton3.Text = data.dr["optionc"].ToString();
                        RadioButton4.Text = data.dr["optiond"].ToString();
                        break;
                    }
                }
            }
        }
        catch (Exception ee)
        {
            Label3.Visible = true;
            Label3.Text = ee.Message;
        }
        finally
        {
            //Label1.Text = array[0].ToString();
            data.dr.Close();
            data.con.Close();
        }
    }*/
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        Session["ans"] = RadioButton1.Text;
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        Session["ans"] = RadioButton2.Text;
    }
    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {
        Session["ans"] = RadioButton3.Text;
    }
    protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
    {
        Session["ans"] = RadioButton4.Text;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["timetaken"] = int.Parse(Session["TIMELEFT"].ToString()) - int.Parse(Label3.Text);
        Response.Redirect("~/Result.aspx");
    }
    protected void Timer2_Tick(object sender, EventArgs e)
    {
        Label7.Text = DateTime.UtcNow.ToString();
        Label8.Text = DateTime.Now.TimeOfDay.ToString();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Session["timetaken"] = int.Parse(Session["TIMELEFT"].ToString()) - int.Parse(Label3.Text);
        Response.Redirect("~/Result.aspx");
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int m;
        try
        {
            m = int.Parse(RadioButtonList1.SelectedItem.Value.ToString());
            // Label5.Text = m.ToString();
        }
        catch
        {
            RadioButtonList1.SelectedIndex = 1;
            m = int.Parse(RadioButtonList1.SelectedValue.ToString());
        }
        try
        {
            data.con.Open();
            data.cmd.CommandText = "Select * from QUESTION ";
            data.cmd.Connection = data.con;
            data.dr = data.cmd.ExecuteReader();
            if (data.dr.HasRows)
            {
                while (data.dr.Read())
                {
                    if (data.dr["quesid"].ToString().Equals(m.ToString()))
                    {
                        // int n = 1;
                        Label1.Text = RadioButtonList1.SelectedItem.Text;
                        Label2.Text = data.dr["question"].ToString();
                        RadioButton1.Text = data.dr["optiona"].ToString();
                        RadioButton2.Text = data.dr["optionb"].ToString();
                        RadioButton3.Text = data.dr["optionc"].ToString();
                        RadioButton4.Text = data.dr["optiond"].ToString();
                        break;
                    }
                }
            }
        }
        catch (Exception ee)
        {
            Label4.Visible = true;
            Label4.Text = ee.Message;
        }
        finally
        {
            //Label1.Text = array[0].ToString();
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
            // UpdatePanel4.Update();
            data.dr.Close();
            data.con.Close();
        }
    }
   
}
