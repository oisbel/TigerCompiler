using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompilersUtils
{
    public abstract class ProgramNode
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public TypeInfo ReturnType { get; set; }
    }
}
