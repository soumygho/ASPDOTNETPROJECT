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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
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
                if (Session["size"] != null)
                {
                    Max = int.Parse(Session["size"].ToString());
                    int rowno = int.Parse(Session["totalrow"].ToString());
                    minimum1 = 1;
                    maximum1 = (rowno / 2) - 1;
                    minimum2 = (rowno / 2);
                    maximum2 = rowno;
                    // Max = 3;
                }
                else
                {
                    Response.Redirect("~/Select.aspx");
                }
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
                        k++;
                    }
                }
                Session["totaltime"] = Max * 60;
                Label3.Text = Session["totaltime"].ToString();
                Session["questionleft"] = int.Parse(Session["size"].ToString()) - int.Parse(Session["count"].ToString());
                Label9.Text = Session["questionleft"].ToString();
                Session["TIMELEFT"] = Max * 60;
                for (int j = 0; j < array.Length; j++)
                {
                    array[j] = 0;
                }
                int i = 0;
                while (i < Max)
                {
                    while (true)
                    {
                        //random number generator
                        Boolean flag = false;
                        int min = rd.Next(minimum1, maximum1);
                        int max = rd.Next(minimum2, maximum2);
                        while (min == max)
                        {
                            min = rd.Next(minimum1, maximum1);
                            max = rd.Next(minimum2, maximum2);
                        }
                        now = rd.Next(min, max);
                        //end of random number generator
                        int k = 0;
                        while (array[k] != 0)
                        {
                            if (now == array[k])
                            {
                                flag = true;
                                break;
                            }
                            k++;
                        }
                        if (!flag)
                            break;
                    }
                    array[i] = now;
                    i++;
                }
                ListBox1.Items.Add("-SELECT QUESTION NO-");
                int p = 0;
                while (array[p] != 0)
                {
                    int l = p + 1;
                    ListItem li = new ListItem(l.ToString(), array[p].ToString());
                    ListBox1.Items.Add(li);
                    p++;
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
                            if (data.dr["quesid"].ToString().Equals(array[0].ToString()))
                            {
                                int n = 1;
                                Label1.Text = n.ToString();
                                Label2.Text = data.dr["question"].ToString();
                                RadioButton1.Text = data.dr["optiona"].ToString();
                                RadioButton2.Text = data.dr["optionb"].ToString();
                                RadioButton3.Text = data.dr["optionc"].ToString();
                                RadioButton4.Text = data.dr["optiond"].ToString();
                                ListBox1.SelectedIndex = 1;
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
                    data.dr.Close();
                    data.con.Close();
                }
            }
            else
            {
                Session["questionleft"] = int.Parse(Session["size"].ToString()) - int.Parse(Session["count"].ToString());
                Label9.Text = Session["questionleft"].ToString();
                //Label5.Text = (int.Parse(Label5.Text) + 1).ToString();
                //RadioButton1.Checked = false;
                // RadioButton2.Checked = false;
                // RadioButton3.Checked = false;
                // RadioButton4.Checked = false;
                // Boolean FLAG = false;

            }
        }
        else
        {
            Response.Redirect("~/Select.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String right=null;
        String quesno=null;
        
       // Session["click"] = true;
        if (Session["ans"] != null)
        {
            String ans = Session["ans"].ToString();
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
                        if (data.dr["quesid"].ToString().Equals(ListBox1.SelectedValue.ToString()))
                        {
                            right = data.dr["ans"].ToString();
                            quesno = ListBox1.SelectedItem.Text;
                            break;
                        }
                    }
                }
                data.dr.Close();
                Session["ans"] = null;
                data.cmd.CommandText = "insert into " + Session["examid"].ToString() + "(question,questionno,rightans,ans) values('"+Label2.Text.ToString()+"','" + quesno + "','" + right + "','" + ans + "')";
                data.cmd.ExecuteNonQuery();
                Session["submitted"] += Label1.Text + "/";
                Session["count"] = int.Parse(Session["count"].ToString()) + 1;
                Button1.Enabled = false;
              //  ListBox1.Items.RemoveAt(int.Parse(quesno));
            }
            catch (Exception ee)
            {
                Label6.Visible = true;
                Label6.Text = ee.Message;
            }
            finally
            {
                //Label1.Text = array[0].ToString();
                data.con.Close();
            }
        }
        else
        {
            Label4.Visible = true;
            Label4.Text = "nothing selected please select an answer";
        }
    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
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
    }
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
            Button1.Enabled = false;
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
}
