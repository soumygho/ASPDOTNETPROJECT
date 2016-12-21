using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class Identitycard
    {
        private int _id = 0;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private float _ratepercard = 0;

        public float Ratepercard
        {
            get { return _ratepercard; }
            set { _ratepercard = value; }
        }
    }
}
