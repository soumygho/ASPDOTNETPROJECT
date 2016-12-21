using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class Category
    {
        private int _id = 0;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private String _categoryname = "";

        public String Categoryname
        {
            get { return _categoryname; }
            set { _categoryname = value; }
        }

    }
}
