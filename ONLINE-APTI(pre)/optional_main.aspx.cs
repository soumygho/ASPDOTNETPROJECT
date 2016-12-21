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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Button2.Visible=false;
            Random rd = new Random();
            int Max = 0;
            int now=0;
            if (Session["size"] != null)
            {
                Max = int.Parse(Session["size"].ToString());
               // Max = 3;
            }
            else
            {
               Response.Redirect("~/Select.aspx");
            }
            Session["totaltime"] = Max * 60;
            int[] array = new int[10];
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
                    int min = rd.Next(1, 3);
                    int max = rd.Next(4, 7);
                    while (min == max)
                    {
                        min = rd.Next(1, 3);
                        max = rd.Next(3, 5);
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
            DropDownList1.Items.Add("-SELECT QUESTION NO-");
            int p = 0;
            while(array[p]!=0)
            {
                int l = p+1;
            ListItem li = new ListItem(l.ToString(),array[p].ToString());
            DropDownList1.Items.Add(li);
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
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int m;
        try
        {
             m = int.Parse(DropDownList1.SelectedItem.Value.ToString());
        }
        catch
        {
             DropDownList1.SelectedIndex = 1;
             m =int.Parse( DropDownList1.SelectedValue.ToString());
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
                        Label1.Text = DropDownList1.SelectedItem.Text;
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
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        if (int.Parse(Session["totaltime"].ToString()) > 0)
        {
            Label3.Text = Session["totaltime"].ToString();
            Session["totaltime"] = int.Parse(Session["totaltime"].ToString()) - 1;

        }
        else if (int.Parse(Session["totaltime"].ToString())==0)
        {
            //DropDownList1.Enabled = false;
            Timer1.Enabled = false;
            Button2.Visible = true;
            Label3.Text = Session["totaltime"].ToString();
            Button1.Enabled = false;
        }
    }
    protected void Timer2_Tick(object sender, EventArgs e)
    {
        if (int.Parse(Session["totaltime"].ToString())==1)
        {
            DropDownList1.Enabled = false;
        }
        else
        {
            DropDownList1.Enabled = true;
        }
    }
}
