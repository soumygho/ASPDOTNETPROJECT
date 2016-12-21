using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class AdminTransaction
    {
        private int _id = 0;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private float _opbalance = 0;

        public float Opbalance
        {
            get { return _opbalance; }
            set { _opbalance = value; }
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
        private String _description = "";

        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private String _method = "";

        public String Method
        {
            get { return _method; }
            set { _method = value; }
        }
        private String _billid = "";

        public String Billid
        {
            get { return _billid; }
            set { _billid = value; }
        }
        private String _receiptid = "";

        public String Receiptid
        {
            get { return _receiptid; }
            set { _receiptid = value; }
        }
        private String _chequeno = "";

        public String Chequeno
        {
            get { return _chequeno; }
            set { _chequeno = value; }
        }
        private String _accno = "";

        public String Accno
        {
            get { return _accno; }
            set { _accno = value; }
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
        private float _closingbalance = 0;

        public float Closingbalance
        {
            get { return _closingbalance; }
            set { _closingbalance = value; }
        }
    }
}
