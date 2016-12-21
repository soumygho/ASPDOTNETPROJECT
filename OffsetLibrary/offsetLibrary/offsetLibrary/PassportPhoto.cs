using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class PassportPhoto
    {
        private int _id = 0;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private float _rateperphoto = 0;

        public float Rateperphoto
        {
            get { return _rateperphoto; }
            set { _rateperphoto = value; }
        }
    }
}
