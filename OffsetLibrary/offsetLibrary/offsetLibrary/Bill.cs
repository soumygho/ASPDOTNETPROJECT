using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class Bill
    {
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


        private ProfitTable _profit = null;

        public ProfitTable Profit
        {
            get { return _profit; }
            set { _profit = value; }
        }
        private BillPaymentDetails _payment = null;

        public BillPaymentDetails Payment
        {
            get { return _payment; }
            set { _payment = value; }
        }
        private float _totalamount = 0;

        public float Totalamount
        {
            get { return _totalamount; }
            set { _totalamount = value; }
        }
        private String _billdate = "";

        public String Billdate
        {
            get { return _billdate; }
            set { _billdate = value; }
        }
        private float _cons = 0;

        public float Cons
        {
            get { return _cons; }
            set { _cons = value; }
        }
        private float _finalamount = 0;

        public float Finalamount
        {
            get { return _finalamount; }
            set { _finalamount = value; }
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
