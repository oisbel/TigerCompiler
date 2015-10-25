using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompilersUtils
{
    public abstract class TypeDeclNode:DeclarationNode
    {
        public string Id { get; set; }
    }
}
