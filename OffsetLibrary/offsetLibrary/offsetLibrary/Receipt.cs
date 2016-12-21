using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class Receipt
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
        private int _billid = 0;

        public int Billid
        {
            get { return _billid; }
            set { _billid = value; }
        }
        private Bill _bill = null;

        public Bill Bill
        {
            get { return _bill; }
            set { _bill = value; }
        }
        private float _paidamount = 0;

        public float Paidamount
        {
            get { return _paidamount; }
            set { _paidamount = value; }
        }
        private float _outstanding = 0;

        public float Outstanding
        {
            get { return _outstanding; }
            set { _outstanding = value; }
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
        private String _transdate = "";

        public String Transdate
        {
            get { return _transdate; }
            set { _transdate = value; }
        }
    }
}
