using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomerDetails
/// </summary>
/// 
namespace offsetLibrary
{
    public class CustomerDetails
    {
        public CustomerDetails()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private int _customerid = 0;

        public int Customerid
        {
            get { return _customerid; }
            set { _customerid = value; }
        }
        private String _customername = "";

        public String Customername
        {
            get { return _customername; }
            set { _customername = value; }
        }
        private String _customerAddress = "";

        public String CustomerAddress
        {
            get { return _customerAddress; }
            set { _customerAddress = value; }
        }
        private String _customermobno = "";

        public String Customermobno
        {
            get { return _customermobno; }
            set { _customermobno = value; }
        }
        private String _customeremail = "";

        public String Customeremail
        {
            get { return _customeremail; }
            set { _customeremail = value; }
        }
    }
}
