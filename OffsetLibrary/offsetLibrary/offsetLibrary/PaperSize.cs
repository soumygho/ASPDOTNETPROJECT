using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace offsetLibrary
{
    public class PaperSize
    {
        private int _id = 0;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _paperid = 0;

        public int Paperid
        {
            get { return _paperid; }
            set { _paperid = value; }
        }
        private String _description = "";

        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private float _ratepersheet = 0;

        public float Ratepersheet
        {
            get { return _ratepersheet; }
            set { _ratepersheet = value; }
        }

        private float _rateperpaper = 0;

        public float Rateperpaper
        {
            get { return _rateperpaper; }
            set { _rateperpaper = value; }
        }
        private int _noofpaperspersheet = 0;

        public int Noofpaperspersheet
        {
            get { return _noofpaperspersheet; }
            set { _noofpaperspersheet = value; }
        }
        private PaperDetails _paper = null;

        public PaperDetails Paper
        {
            get { return _paper; }
            set { _paper = value; }
        }
        
    }
}
