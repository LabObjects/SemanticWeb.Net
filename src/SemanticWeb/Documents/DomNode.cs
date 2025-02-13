using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanticWeb.Documents
{
    public abstract class DomNode
    {


        #region Properties

        public virtual List<DomNode>? ChildNodes { get; internal protected set; }



        public virtual DomNode? FirstChild
        {
            get
            {
                return ChildNodes != null && ChildNodes.Count > 0 ? ChildNodes[0] : null;
            }
        }

        public virtual bool HasChildNodes
        {
            get
            {
                return ChildNodes == null ? false : ChildNodes.Count > 0 ? true : false;
            }
        }

        public virtual DomNode? LastChild
        {
            get
            {
                return ChildNodes != null && ChildNodes.Count > 0 ? ChildNodes[ChildNodes.Count - 1] : null;
            }
        }
        public virtual DomNode? NextSibling
        {
            get
            {
                return ChildNodes != null && ChildNodes.Count > 0 ? ChildNodes[ChildNodes.Count - 1] : null;
            }
        }
        public virtual DomNode? PreviousSibling
        {
            get
            {
                return ChildNodes != null && ChildNodes.Count > 0 ? ChildNodes[ChildNodes.Count - 1] : null;
            }
        }

        public virtual string NodeName { get; protected internal set; }
        public virtual DomNodeType NodeType { get; protected internal set; }
        public virtual DomNode? Parent { get; internal protected set; }

        #endregion


    }
}
