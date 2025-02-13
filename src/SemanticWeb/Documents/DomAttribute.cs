using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 interface Attr : Node {
  readonly attribute DOMString? namespaceURI;
  readonly attribute DOMString? prefix;
  readonly attribute DOMString localName;
  readonly attribute DOMString name;
  [CEReactions] attribute DOMString value;

  readonly attribute Element? ownerElement;

  readonly attribute boolean specified; // useless; always returns true
};
 * */
namespace SemanticWeb.Documents
{
    /// <summary>
    /// DOM Attribute
    /// </summary>
    /// <summary>
    /// Document Attribute
    /// </summary>
    /// <seealso href="https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmlattribute.localname?view=net-9.0"/>
    public class DomAttribute : DomNode
    {
        public DomAttribute() 
        { 
            NodeType = DomNodeType.Attribute; 
        }

        protected internal  DomAttribute(string? prefix, string localName, string? namespaceURI, DomDocument doc)
        { 
            NodeType = DomNodeType.Attribute; 
            Prefix = prefix;
            LocalName = localName;
            NamespaceUri = namespaceURI;
            OwnerDocument = doc;
            
        }
        

        public string? NamespaceUri { get; internal protected set; } = null;

        public string? Prefix { get; internal protected set; } = null;

        public string? LocalName { get; internal protected set; } = null;

        public string Name { get; internal protected set; } = string.Empty;
        public string Value { get; internal protected set; } = string.Empty;
        public DomDocument? OwnerDocument { get; internal protected set; } = null;
        public DomElement? OwnerElement { get; internal protected set; } = null;





        public bool Specified { get; private set; } = true;

    }
}
