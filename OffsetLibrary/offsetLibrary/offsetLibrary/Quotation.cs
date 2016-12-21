using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class Quotation
    {
        private int _id = 0;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        private int _userid = 0;

        public int Userid
        {
            get { return _userid; }
            set { _userid = value; }
        }
        
        private float _totalamount = 0;

        public float Totalamount
        {
            get { return _totalamount; }
            set { _totalamount = value; }
        }

        private int _transmonth = 0;

        public int Transmonth
        {
            get { return _transmonth; }
            set { _transmonth = value; }
        }
        private int _transyear = 0;

        public int Transyear
        {
            get { return _transyear; }
            set { _transyear = value; }
        }

        
        private String _quotedate = "";

        public String Quotedate
        {
            get { return _quotedate; }
            set { _quotedate = value; }
        }

        private List<OrderDetails> orders = null;

        public List<OrderDetails> Orders
        {
            get { return orders; }
            set { orders = value; }
        }

        private CustomerDetails customer = null;

        public CustomerDetails Customer
        {
            get { return customer; }
            set { customer = value; }
        }


    }
}
