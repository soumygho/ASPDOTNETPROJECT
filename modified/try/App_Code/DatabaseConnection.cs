using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

    public class DatabaseConnection
    {
        public SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS2008;AttachDbFilename=|DataDirectory|\\student.mdf;Integrated Security=True;User Instance=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da;
        public SqlDataReader dr;
        public void insertRecord(String cls,String exam,String date,String filename,Label lab)
        {
            String error = "";
            try
            {
                con.Open();
                cmd.CommandText = "insert into filerecord values('"+cls+"','"+exam+"','"+date+"','FALSE','"+filename+"','"+DateTime.Today.Date.Year.ToString()+"');";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                error = ee.Message;
            }
            finally
            {
                con.Close();
                if (!error.Equals(""))
                {
                    lab.Text = error;
                }
            }
        }
    }