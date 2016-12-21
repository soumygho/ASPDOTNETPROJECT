using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class BillPaymentDetails
    {
        private int _id = 0;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _billid = 0;

        public int Billid
        {
            get { return _billid; }
            set { _billid = value; }
        }
        private float _finalamount = 0;

        public float Finalamount
        {
            get { return _finalamount; }
            set { _finalamount = value; }
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
        private Bill _billdetails = null;

        internal Bill Billdetails
        {
            get { return _billdetails; }
            set { _billdetails = value; }
        }

        private String _transdate = "";

        public String Transdate
        {
            get { return _transdate; }
            set { _transdate = value; }
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
    }
}
