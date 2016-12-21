using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ActualCost
/// </summary>
/// 
namespace offsetLibrary
{
    public class ActualCost
    {
        public ActualCost()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private int _id = 0;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _categoryid = 0;

        public int Categoryid
        {
            get { return _categoryid; }
            set { _categoryid = value; }
        }
        private float _printcostperpage = 0;

        public float Printcostperpage
        {
            get { return _printcostperpage; }
            set { _printcostperpage = value; }
        }
        private float _dtpcostperpage = 0;

        public float Dtpcostperpage
        {
            get { return _dtpcostperpage; }
            set { _dtpcostperpage = value; }
        }
        private float _bindingcost = 0;

        public float Bindingcost
        {
            get { return _bindingcost; }
            set { _bindingcost = value; }
        }
        private float _colorcostperpage = 0;

        public float Colorcostperpage
        {
            get { return _colorcostperpage; }
            set { _colorcostperpage = value; }
        }
        private float _profit = 0;

        public float Profit
        {
            get { return _profit; }
            set { _profit = value; }
        }
        private float _deliverycostperunit = 0;

        public float Deliverycostperunit
        {
            get { return _deliverycostperunit; }
            set { _deliverycostperunit = value; }
        }
    }
}
