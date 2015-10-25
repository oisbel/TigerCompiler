using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompilersUtils
{
    public abstract class BinaryOpNode:OperatorNode
    {
        public TigerNode LeftOperand { get; set; }
        public TigerNode RigthOperand { get; set; }

        public BinaryOpNode(TigerNode expr1, TigerNode expr2)
        {
            LeftOperand = expr1; RigthOperand = expr2;
        }
        public BinaryOpNode() : this(null, null) { }

    }
}
