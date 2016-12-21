using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class Flex
    {
        private int _id = 0;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private float _ratepersquarefeet = 0;

        public float Ratepersquarefeet
        {
            get { return _ratepersquarefeet; }
            set { _ratepersquarefeet = value; }
        }
    }
}
