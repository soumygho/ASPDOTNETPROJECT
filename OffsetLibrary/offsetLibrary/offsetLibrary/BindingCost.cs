using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
  public  class BindingCost
    {
        private int _id = 0;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _description = "";

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private int _max = 0;

        public int Max
        {
            get { return _max; }
            set { _max = value; }
        }
        private int _min = 0;

        public int Min
        {
            get { return _min; }
            set { _min = value; }
        }
        private float _rateperunit = 0;

        public float Rateperunit
        {
            get { return _rateperunit; }
            set { _rateperunit = value; }
        }
    }
}
