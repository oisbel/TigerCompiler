using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompilersUtils
{
    public class Error
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public string BodyError { get; set; }
        public Error(int row, int col, string bodyError)
        {
            Row = row;
            Col = col;
            BodyError = bodyError;
        }
        public override string ToString()
        {
            return "(" + Row + "," + Col + "):" + BodyError;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Error)) return false;
            return BodyError == ((Error)obj).BodyError;
        }
    }
}
