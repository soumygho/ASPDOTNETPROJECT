using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class ProfitTable
    {
        private int _id = 0;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
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
        private float _actualcost = 0;

        public float Actualcost
        {
            get { return _actualcost; }
            set { _actualcost = value; }
        }
        private float _finalamount = 0;

        public float Finalamount
        {
            get { return _finalamount; }
            set { _finalamount = value; }
        }
        private float _profit = 0;

        public float Profit
        {
            get { return _profit; }
            set { _profit = value; }
        }
        private float _loss = 0;

        public float Loss
        {
            get { return _loss; }
            set { _loss = value; }
        }
        private int _billid = 0;

        public int Billid
        {
            get { return _billid; }
            set { _billid = value; }
        }
        private String _transdate = "";

        public String Transdate
        {
            get { return _transdate; }
            set { _transdate = value; }
        }
    }
}
