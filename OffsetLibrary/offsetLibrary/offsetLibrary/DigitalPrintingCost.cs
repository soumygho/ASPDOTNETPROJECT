using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
   public class DigitalPrintingCost
    {
        private int _id = 0;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private float _rateperpage = 0;

        public float Rateperpage
        {
            get { return _rateperpage; }
            set { _rateperpage = value; }
        }
    }
}
