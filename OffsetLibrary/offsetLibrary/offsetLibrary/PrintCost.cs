using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
   public class PrintCost
    {

        private int _min = 0;

        public int Min
        {
            get { return _min; }
            set { _min = value; }
        }
        private int _max = 0;

        public int Max
        {
            get { return _max; }
            set { _max = value; }
        }
        private float _printrate = 0;

        public float Printrate
        {
            get { return _printrate; }
            set { _printrate = value; }
        }
        private String _color = "";

        public String Color
        {
            get { return _color; }
            set { _color = value; }
        }
    }
}
