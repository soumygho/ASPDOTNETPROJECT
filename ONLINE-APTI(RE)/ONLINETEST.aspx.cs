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

public partial class ONLINETEST : System.Web.UI.Page
{
    DatabaseConnection dataconnection = new DatabaseConnection();
    Random rd = new Random();
    int i;
     int MAX = 5;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label11.Visible = false;
            Label2.Visible = false;
            Label14.Visible = false;
           // Button3.Visible = false;
            Button4.Visible = false;
            Label5.Visible = false;
            Label13.Visible = false;
        }
            int[] array = new int[70];
            int[] unattempt = new int[70];
            for (int l = 0; l < array.Length; l++)
                array[l] = 0;
            String num;
            char[] am = new char[30];
            char[] ap = new char[30];
            int k = 0;
            int j = 0;
            int m = 0;
            int min;
            int max;
            int max_go = 0;
        int left=0;
        if (!IsPostBack)
        {
            if (Session["skipped"] != null)//test skipped questions
            {
                Label5.Visible = true;
                Label5.Text = Session["skipped"].ToString();
            }
            if (Session["time"] == null)
            {
                Session["time"] = 0;
            }
            if (Session["attemptedno"] == null)
            {
                Session["attemptedno"] = 0;
            }
            if (Session["reached"] == null)
            {
                Session["reached"] = "no";
            }
            /* else
             {
                 Session.Abandon();
                 Session.Clear();
                 Response.Redirect("~/HOMEPAGE.aspx");
             }*/
            if (Session["prev"] == null)
                Session["prev"] = 0;
            if (Session["totaltime"] == null)
                Session["totaltime"] = (60 * MAX);
            if (Session["num"] != null)
            {
                if (int.Parse(Session["num"].ToString()) == MAX)
                {
                    Button2.Enabled = false;
                    //Button3.Visible = false;
                }
            }
            else
            {
                Session["num"] = 1;
            }
        }
        if (!IsPostBack)
        {
            if (Session["reached"].ToString().Equals("yes"))
            {
                Button1.Visible = true;
                Button2.Enabled = true;
                Button4.Visible = false;
                //Button4.Enabled = true;
            }
            if (int.Parse(Session["attemptedno"].ToString()) == 0 && Session["reached"].ToString().Equals("yes") == true)
            {
                Response.Redirect("~/Result.aspx");
            }
            if ((int.Parse(Session["attemptedno"].ToString())+1) == int.Parse(Session["num"].ToString()) && Session["reached"].ToString().Equals("yes") == true)
            {
                Response.Redirect("~/Result.aspx");
            }
        }
        if (!IsPostBack)
        {
            if (int.Parse(Session["totaltime"].ToString()) > 0)
            {
                if (Session["reached"].ToString().Equals("no"))
                {
                    if (Session["id"] != null)
                    {
                        char[] arr = Session["id"].ToString().ToCharArray();
                        while (j < arr.Length)
                        {
                            if (arr[j] == '/')
                            {
                                num = new String(am);
                                k = 0;
                                array[m] = int.Parse(num);
                                m++;
                                j++;
                                continue;
                            }
                            am[k] = arr[j];
                            k++;
                            j++;
                        }
                        while (true)
                        {
                            bool flag = false;
                            i = rd.Next(1, 8);
                            m = 0;
                            while (array[m] != 0)
                            {
                                if (array[m] == i)
                                {
                                    flag = true;
                                    break;
                                }
                                m++;
                            }
                            if (flag == false)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                            min = rd.Next(1, 3);
                            max = rd.Next(3, 8);
                            while (min == max)
                            {
                                min = rd.Next(1, 3);
                                max = rd.Next(3, 5);
                            }
                            i = rd.Next(min, max);

                    }
                }
                //see the unattempted
                if (Session["skipped"] != null)
                {
                        j = 0;
                        m = 0;
                        k = 0;
                        for (int l = 0; l < unattempt.Length; l++)
                            unattempt[l] = 0;
                        char[] arr = Session["skipped"].ToString().ToCharArray();
                        while (j < arr.Length)
                        {
                            if (arr[j] == '/')
                            {
                                num = new String(ap);
                                k = 0;
                                unattempt[m] = int.Parse(num);
                                m++;
                                j++;
                                continue;
                            }
                            ap[k] = arr[j];
                            k++;
                            j++;
                        }
                        //skipped question accessed after displaying all questions
                        if (Session["reached"].ToString().Equals("yes"))
                        {
                            Session["id"] = null;
                            if (Session["now"] == null)
                            {
                                Session["now"] = 0;
                                i = 0;
                                Session["now"] = 1;
                            }
                            else
                            {
                                i = int.Parse(Session["now"].ToString());
                                if (unattempt[i] != 0)
                                    Session["now"] = int.Parse(Session["now"].ToString()) + 1;
                            }
                        //i = int.Parse(Session["now"].ToString());
                        i = unattempt[i];
                        Label14.Visible = true;
                        Label14.Text = i.ToString();
                    }
                    if (Session["attemptedno"] != null && Session["reached"].ToString().Equals("no"))
                    {
                        int d = 0;
                        while (unattempt[d] != 0)
                        {
                            d++;
                            Session["attemptedno"] = d;
                        }
                    }
                    if (Session["reached"].ToString().Equals("yes") && int.Parse(Session["attemptedno"].ToString()) != 0)
                    {
                        max_go = int.Parse(Session["attemptedno"].ToString());
                    }
                }
                try
                {
                    dataconnection.con.Open();
                    dataconnection.cmd.CommandText = "Select * from QUESTION";
                    dataconnection.cmd.Connection = dataconnection.con;
                    dataconnection.dr = dataconnection.cmd.ExecuteReader();
                    if (dataconnection.dr.HasRows)
                    {
                        while (dataconnection.dr.Read())
                        {
                            if (dataconnection.dr["quesid"].ToString().Equals(i.ToString()))
                            {
                                //Label14.Text = i.ToString();
                                if (Session["reached"].ToString().Equals("no"))
                                {
                                    if (int.Parse(Session["prev"].ToString()) != MAX)
                                    {
                                        if (Session["id"] == null)
                                        {
                                            Session["id"] = dataconnection.dr["quesid"].ToString() + "/";
                                        }
                                        else
                                        {
                                            Session["id"] += dataconnection.dr["quesid"].ToString() + "/";
                                        }
                                    }
                                }
                                else
                                {
                                    Session["id"] = null;
                                }
                                if (Session["reached"].ToString().Equals("no"))
                                {
                                     left = MAX - (int.Parse(Session["num"].ToString()));
                                }
                                else
                                {
                                    left = max_go - (int.Parse(Session["num"].ToString()));
                                }
                                Label3.Text = left.ToString();
                                Label1.Text = Session["num"].ToString();
                                Label6.Text = Session["num"].ToString();
                                Session["prev"] = Session["num"];
                                Session["current"] = dataconnection.dr["quesid"].ToString();
                                if (int.Parse(Session["num"].ToString()) == MAX&&Session["reached"].ToString().Equals("no"))
                                {
                                    Session["reached"] = "yes";
                                    Session["num"] = 0;
                                }
                                
                                Session["num"] = int.Parse(Session["num"].ToString()) + 1;
                                Label4.Text = dataconnection.dr["question"].ToString();
                                RadioButton1.Text = dataconnection.dr["optiona"].ToString();
                                RadioButton2.Text = dataconnection.dr["optionb"].ToString();
                                RadioButton3.Text = dataconnection.dr["optionc"].ToString();
                                RadioButton4.Text = dataconnection.dr["optiond"].ToString();
                                break;
                            }
                        }
                    }
                }
                catch (Exception ee)
                {
                    Label5.Visible = true;
                    Label5.Text = ee.Message;
                }
                finally
                {
                    dataconnection.con.Close();
                }
            }
            else
            {
                Response.Redirect("~/Result.aspx");
            }
            }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("HOMEPAGE.aspx");
    }
   /* protected void Timer2_Tick(object sender, EventArgs e)
    {
        Timer2.Enabled = true;
        try
        {
            if (int.Parse(Session["timeen"].ToString()) <= 60)
            {
                Label9.Text = Session["timeen"].ToString();
                Session["timeen"] = int.Parse(Session["timeen"].ToString()) + 1;
            }
            else
            {
                Timer2.Enabled = false;
                Session["time"] = null;
                LinkButton1.Enabled = false;
            }
        }
        catch (Exception ee)
        {
            Timer2.Enabled = false;
        }
    }*/
    protected void Timer1_Tick(object sender, EventArgs e)//button update and label update
    {
        Label2.Visible = true;
        Label11.Visible = true;
        Timer1.Enabled = true;
        try
        {

            if (int.Parse(Session["time"].ToString()) <= 60)
            {
                if (int.Parse(Session["prev"].ToString()) == MAX)
                {
                    Button1.Visible = true;
                    //Button3.Visible = false;
                    Button2.Enabled = false;
                    Label13.Visible = true;
                }
                else
                {
                    Label13.Visible = false;
                    Button1.Visible = true;
                    //Button3.Visible = false;
                    Button2.Enabled = true;
                }
                Label2.Text = Session["time"].ToString();
                Label11.Text = Session["totaltime"].ToString();
                Session["time"] = int.Parse(Session["time"].ToString()) + 1;
                Session["totaltime"] = int.Parse(Session["totaltime"].ToString()) - 1;
            }
            else
            {
                Label3.Visible = false;
                    if (int.Parse(Session["prev"].ToString()) == MAX)
                    {
                        Button1.Visible = false;
                        //Button3.Visible = true;
                        Button2.Enabled = false;
                        if (Session["Skipped"] != null)
                            Button4.Visible = true;
                    }
                    else
                    {
                        Button1.Visible = false;
                        // Button3.Visible = false;
                        Button2.Enabled = true;
                    }
                Timer1.Enabled = false;
                Session["time"] = null;
            }
        }
        catch(Exception ee)
        {
            Timer1.Enabled = false;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //Session["totaltime"] = Label11.Text;
        if(Session["reached"].ToString().Equals("no"))
        Session["skipped"] += Session["current"].ToString() + "/";
        Session["time"] = null;
        Response.Redirect("~/testvoid.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (Session["reached"].ToString().Equals("yes"))
            {
                Session["id"] = null;
               // Session["num"] = null;
               // MAX = int.Parse(Session["skipped"].ToString());
            }
        }
        catch (Exception ee)
        {
            Label13.Visible = true;
            Label13.Text = "YOU HAVE TO SELECT AN OPTION";
        }
        Session["time"] = null;
        //access database to input the answers
       // Session["totaltime"] = Label11.Text;
        //if ((Session["reached"].ToString().Equals("yes") && (int.Parse(Session["num"].ToString()) == int.Parse(Session["attemptedno"].ToString()))) || (Session["reached"].ToString().Equals("yes") &&( int.Parse(Session["attemptedno"].ToString())==0)))
            //
        //else
        Response.Redirect("~/testvoid.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Session["id"] = null;
        Session["time"] = null;
        Response.Redirect("~/testvoid.aspx");
    }
}
