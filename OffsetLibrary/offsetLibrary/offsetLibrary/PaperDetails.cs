using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class PaperDetails
    {
        private int _id = 0;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private String _papername = "";

        public String Papername
        {
            get { return _papername; }
            set { _papername = value; }
        }
        private float _paperrate = 0;

        public float Paperrate
        {
            get { return _paperrate; }
            set { _paperrate = value; }
        }
    }
}
