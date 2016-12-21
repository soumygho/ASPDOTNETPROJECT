using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class CostTable
    {
        private int _id = 0;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
       
        private float _pagecost = 0;

        public float Pagecost
        {
            get { return _pagecost; }
            set { _pagecost = value; }
        }
        private float _colorcost = 0;

        public float Colorcost
        {
            get { return _colorcost; }
            set { _colorcost = value; }
        }
        private float _bindingcost = 0;

        public float Bindingcost
        {
            get { return _bindingcost; }
            set { _bindingcost = value; }
        }
        private float _dtpcost = 0;

        public float Dtpcost
        {
            get { return _dtpcost; }
            set { _dtpcost = value; }
        }
        private float _deliverycost = 0;

        public float Deliverycost
        {
            get { return _deliverycost; }
            set { _deliverycost = value; }
        }
        private float _additionalprofit = 0;

        public float Additionalprofit
        {
            get { return _additionalprofit; }
            set { _additionalprofit = value; }
        }
        private float _printcost = 0;

        public float Printcost
        {
            get { return _printcost; }
            set { _printcost = value; }
        }
        private float _totalcost = 0;

        public float Totalcost
        {
            get { return _totalcost; }
            set { _totalcost = value; }
        }

        private int _orderid = 0;

        public int Orderid
        {
            get { return _orderid; }
            set { _orderid = value; }
        }
        private int _categoryid = 0;

        public int Categoryid
        {
            get { return _categoryid; }
            set { _categoryid = value; }
        }


    }
}
