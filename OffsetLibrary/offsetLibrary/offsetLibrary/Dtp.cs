using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class Dtp
    {
        private int _id = 0;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private String _papersize = "";

        public String Papersize
        {
            get { return _papersize; }
            set { _papersize = value; }
        }
        private float _rateperpage = 0;

        public float Rateperpage
        {
            get { return _rateperpage; }
            set { _rateperpage = value; }
        }

        private String _type = "";

        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

    }
}
