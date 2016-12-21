using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

/// <summary>
/// Summary description for ClassDatabaseOperation
/// </summary>
public class ClassDatabaseOperation
{
    DatabaseConnection dbConnection = null;
	public ClassDatabaseOperation()
	{
        dbConnection = new DatabaseConnection();
	}
    private void createConnection()
    {
        if (dbConnection != null)
        {
            try
            {
                dbConnection.con.Open();
                dbConnection.cmd.Connection = dbConnection.con;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
    private void closeConnection()
    {
        if (dbConnection != null)
        {
            try
            {
                dbConnection.con.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }

    public ArrayList getUserDetails(int userid)
    {
        ArrayList al = null;
        try
        {
            createConnection();
            dbConnection.cmd.CommandText = "select userdetails.*,usermain.* from userdetails,usermain where userdetails.uid = usermain.id;";
            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            if (dbConnection.dr.HasRows)
            {
                al = new ArrayList();
                
                while (dbConnection.dr.Read())
                {
                    ClassForm user = new ClassForm();
                    user.Userid = Int32.Parse(dbConnection.dr["id"].ToString());
                    user.UserName = dbConnection.dr["username"].ToString();
                    user.Pwd = dbConnection.dr["password"].ToString();
                    user.Sex = dbConnection.dr["sex"].ToString();
                    user.Name = dbConnection.dr["name"].ToString();
                    user.Interest = dbConnection.dr["interest"].ToString();
                    user.Postalcode = dbConnection.dr["postalcode"].ToString();
                    user.Rating = dbConnection.dr["rating"].ToString();
                    user.State = dbConnection.dr["state"].ToString();
                    user.Email = dbConnection.dr["email"].ToString();
                    user.Comment = dbConnection.dr["comment"].ToString();
                    user.City = dbConnection.dr["city"].ToString();
                    user.Address = dbConnection.dr["address"].ToString();
                    al.Add(user);
                }
            }
            dbConnection.dr.Close();
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            closeConnection();
        }
        return al;
    }

    public ArrayList getUserDetails(String userName)
    {
        ArrayList al = null;
        try
        {
            createConnection();
            dbConnection.cmd.CommandText = "select usermain.* from usermain where  usermain.username = '"+userName+"';";
            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            if (dbConnection.dr.HasRows)
            {
                al = new ArrayList();

                while (dbConnection.dr.Read())
                {
                    ClassForm user = new ClassForm();
                    user.Userid = Int32.Parse(dbConnection.dr["id"].ToString());
                    user.UserName = dbConnection.dr["username"].ToString();
                    user.Pwd = dbConnection.dr["password"].ToString();
                    
                    al.Add(user);
                }
            }
            dbConnection.dr.Close();
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            closeConnection();
        }
        return al;
    }

    public bool insertRecord(ClassForm user)
    {
        Boolean flag = false;
        try
        {
            createConnection();

            dbConnection.cmd.Transaction = dbConnection.con.BeginTransaction();
            dbConnection.cmd.CommandText = "insert into usermain (id,password,username) values ("+user.Userid+",'"+user.Pwd+"','"+user.UserName+"');";
            dbConnection.cmd.ExecuteNonQuery();
            dbConnection.cmd.CommandText = "insert into userdetails (uid,name,address,sex,email,interest,postalcode,state,city,comment,rating) values ("+user.Userid+",'"+user.Name+"','"+user.Address+"','"+user.Sex+"','"+user.Email+"','"+user.Interest+"','"+user.Postalcode+"','"+user.State+"','"+user.City+"','"+user.Comment+"','"+user.Rating+"');";
            dbConnection.cmd.ExecuteNonQuery();
            dbConnection.cmd.Transaction.Commit();
            flag = true;
        }
        catch (Exception e)
        {
            dbConnection.cmd.Transaction.Rollback();
            throw e;
        }
        finally
        {
            closeConnection();
        }
        return flag;
    }
}
