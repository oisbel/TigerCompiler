using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompilersUtils
{
    public class Access
    {

    }

    public class AccessArray:Access
    {
        public TigerNode Index { get; set; }
        public AccessArray(TigerNode index)
        {
            Index = index;
        }
    }
    public class AccessRecord:Access
    {
        public string Field { get; set; }
        public AccessRecord(string field)
        {
            Field = field;
        }
    }
}
