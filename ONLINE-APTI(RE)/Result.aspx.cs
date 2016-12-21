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

public partial class Result : System.Web.UI.Page
{
    DatabaseConnection data = new DatabaseConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null||Session["id"]==null)
        {
            Session["testvoid"] = null;
            Session["optional_main"] = null;
            Response.Redirect("~/HOMEPAGE.aspx");
        }
        if (Session["timetaken"] != null)
        {
            Session["optional_main"] = "false";
            Label8.Visible = false;
            int id = int.Parse(Session["id"].ToString());
            float right = 0;
            float wrong = 0;
            int total = int.Parse(Session["totalsize"].ToString());
            float score = 0;
            float per = 0;
            Label1.Text = total.ToString();
            Session["count"] = null;
            Session["totalsize"] = null;
            Session["submitted"] = null;
            Session["totaltime"] = null;
            Label7.Text = null;
            Label1.Text = total.ToString();
            Label4.Text = Session["timetaken"].ToString();
            try
            {
                data.con.Open();
                data.cmd.CommandText = "select * from " + Session["examid"].ToString();
                data.cmd.Connection = data.con;
                data.dr = data.cmd.ExecuteReader();
                if (data.dr.HasRows)
                {
                    while (data.dr.Read())
                    {
                        if (data.dr["rightans"].ToString().Equals(data.dr["ans"].ToString()))
                        {
                            Label7.Text += data.dr["questionno"].ToString() + ":" + data.dr["question"].ToString() + "<br/>";
                            Label7.Text += "<br/>";
                            Label7.Text += "ANSWER GIVEN :" + data.dr["ans"].ToString() + "<br/>";
                            Label7.Text += "<br/>";
                            Label7.Text += "RIGHT ANSWER :" + data.dr["rightans"].ToString() + "<br/>";
                            Label7.Text += "<br/>";
                            right++;
                        }
                        else
                        {
                            Label7.Text += data.dr["questionno"].ToString() + ":" + data.dr["question"].ToString() + "<br/>";
                            Label7.Text += "<br/>";
                            Label7.Text += "ANSWER GIVEN :" + data.dr["ans"].ToString() + "<br/>";
                            Label7.Text += "<br/>";
                            Label7.Text += "RIGHT ANSWER :" + data.dr["rightans"].ToString() + "<br/>";
                            Label7.Text += "<br/>";
                            wrong++;
                        }
                    }
                    score = right * 1;
                    per = (float)((float)(right / total) * 100.00);
                    Label2.Text = right.ToString();
                    Label3.Text = wrong.ToString();
                    Label5.Text = score.ToString();
                    Label6.Text = per.ToString();
                }
                else
                {
                    score = right * 1;
                    per = (float)((float)(right / total) * 100.00);
                    Label2.Text = right.ToString();
                    Label3.Text = wrong.ToString();
                    Label5.Text = score.ToString();
                    Label6.Text = per.ToString();
                    Label7.Visible = false;

                }
                data.dr.Close();
                data.cmd.CommandText = "drop table "+Session["examid"].ToString().Trim();
                data.cmd.ExecuteNonQuery();
                data.cmd.CommandText = "insert into examdet (id,date,examid,rightans,wrongans,score,total,per,time) values (" + id + ",'" + Session["date"].ToString() + "','" + Session["examid"].ToString() + "','" + right.ToString() + "','" + wrong.ToString() + "','" + score.ToString() + "','" + total.ToString() + "','" + per.ToString() + "','" + Session["timetaken"].ToString() + "')";
                data.cmd.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                Label8.Visible = true;
                Label8.Text = ee.Message;
            }
            finally
            {
                
                Session["timetaken"] = null;
                Session["examid"] = null;
                data.con.Close();
            }
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("~/HOMEPAGE.aspx");
    }
}
