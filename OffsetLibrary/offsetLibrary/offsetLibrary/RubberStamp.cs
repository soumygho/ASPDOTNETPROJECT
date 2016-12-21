using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class RubberStamp
    {
        private int _id = 0;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private String _modelno = "";

        public String Modelno
        {
            get { return _modelno; }
            set { _modelno = value; }
        }
        private float _rate = 0;

        public float Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }
    }
}
