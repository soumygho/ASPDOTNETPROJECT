using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class Transaction
    {
        private String _description = "";

        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private String _method = "";

        public String Method
        {
            get { return _method; }
            set { _method = value; }
        }
        private string _chequeno = "";

        public string Chequeno
        {
            get { return _chequeno; }
            set { _chequeno = value; }
        }
        private String _accno = "";

        public String Accno
        {
            get { return _accno; }
            set { _accno = value; }
        }
    }
}
