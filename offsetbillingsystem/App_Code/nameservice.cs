using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Web.Script.Serialization;
using System.Web.Extensions;
using offsetLibrary;

/// <summary>
/// Summary description for nameservice
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.ComponentModel.ToolboxItem(false)]
[ScriptService]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class nameservice : System.Web.Services.WebService {
    CustomerOperation customerops = new CustomerOperation();
    public nameservice () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string getList(string start)
    {
        
        CustomerSuggest[] custarray = null;
        try
        {
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*"); 
            List<CustomerDetails> customerlist = customerops.readCustomers(start);
            if (customerlist != null && customerlist.Count > 0)
            {
                custarray = new CustomerSuggest[customerlist.Count];
                for (int i = 0; i < customerlist.Count; i++)
                {
                    CustomerSuggest suggest = new CustomerSuggest();
                    suggest.Custid = customerlist[i].Customerid;
                    suggest.Custname = customerlist[i].Customername;
                    suggest.Suggestion = customerlist[i].Customername + "," + customerlist[i].CustomerAddress + "," + customerlist[i].Customermobno
                        ;
                    suggest.Custmobno = customerlist[i].Customermobno;
                    suggest.Custemail = customerlist[i].Customeremail;
                    suggest.Custaddress = customerlist[i].CustomerAddress;
                    custarray[i] = suggest;
                    
                }
            }
        }
        catch (Exception e)
        {
        }
        return new JavaScriptSerializer().Serialize(custarray);
    }
    
}

