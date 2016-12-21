using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class UserTransaction
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
        private float _credit = 0;

        public float Credit
        {
            get { return _credit; }
            set { _credit = value; }
        }
        private float _debit = 0;

        public float Debit
        {
            get { return _debit; }
            set { _debit = value; }
        }
        private float _outstanding = 0;

        public float Outstanding
        {
            get { return _outstanding; }
            set { _outstanding = value; }
        }
        private String _transdate = "";

        public String Transdate
        {
            get { return _transdate; }
            set { _transdate = value; }
        }
        private int _billid = 0;

        public int Billid
        {
            get { return _billid; }
            set { _billid = value; }
        }

        private int _recieptid = 0;

        public int Recieptid
        {
            get { return _recieptid; }
            set { _recieptid = value; }
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
        private float _opbalance = 0;

        public float Opbalance
        {
            get { return _opbalance; }
            set { _opbalance = value; }
        }
        private float _closingbalance = 0;

        public float Closingbalance
        {
            get { return _closingbalance; }
            set { _closingbalance = value; }
        }

    }
}
