using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserDAO
/// </summary>
public class UserDAO
{
    private String userid = "";
    private String name = "";
	public UserDAO(String id,String name)
	{
		//
		// TODO: Add constructor logic here
		//
        userid = id;
        this.name = name;
	}
    public ShortUserDetails getResult()
    {
        return null;
    }
}
