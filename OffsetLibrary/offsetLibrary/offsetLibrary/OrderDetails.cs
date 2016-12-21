using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class OrderDetails
    {

        private int _id = 0;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private String _paper = "NIL";

        public String Paperid
        {
            get { return _paper; }
            set { _paper = value; }
        }
        private String _size = "NIL";

        public String Size
        {
            get { return _size; }
            set { _size = value; }
        }
        private int _quoteid = 0;

        public int Quoteid
        {
            get { return _quoteid; }
            set { _quoteid = value; }
        }
        private int _billid = 0;

        public int Billid
        {
            get { return _billid; }
            set { _billid = value; }
        }
        private String _color = "NIL";

        public String Color
        {
            get { return _color; }
            set { _color = value; }
        }
        private String _printside = "NIL";

        public String Printside
        {
            get { return _printside; }
            set { _printside = value; }
        }
        private String _flexsize = "NIL";

        public String Flexsize
        {
            get { return _flexsize; }
            set { _flexsize = value; }
        }
        private String _stampmodelno = "NIL";

        public String Stampmodelno
        {
            get { return _stampmodelno; }
            set { _stampmodelno = value; }
        }

        private String _description = "NIL";

        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private int _qty = 0;

        public int Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }
        private CostTable _cost = null;

        public CostTable Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        private int _categoryid = 0;

        public int Categoryid
        {
            get { return _categoryid; }
            set { _categoryid = value; }
        }

        private String _papername = null;

        public String Papername
        {
            get { return _papername; }
            set { _papername = value; }
        }
        
        
    }
}
