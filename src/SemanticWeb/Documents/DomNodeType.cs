using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanticWeb.Documents
{
    /// <summary>
    /// DOM Node Types
    /// </summary>
    /// <remarks>
    /// <para>The Web Hypertext Application Technology Working Group (WHATWG) DOM Standard defines the following node types</para>
    /// <list type="bullet">
    /// <listheader>readonly attribute unsigned short nodeType;</listheader>
    /// <item>const unsigned short ELEMENT_NODE = 1;</item>
    /// <item>const unsigned short ATTRIBUTE_NODE = 2;</item>
    /// <item>const unsigned short TEXT_NODE = 3;</item>
    /// <item>const unsigned short CDATA_SECTION_NODE = 4;</item>
    /// <item>const unsigned short ENTITY_REFERENCE_NODE = 5; // legacy</item>
    /// <item>const unsigned short ENTITY_NODE = 6; // legacy</item>
    /// <item>const unsigned short PROCESSING_INSTRUCTION_NODE = 7;</item>
    /// <item>const unsigned short COMMENT_NODE = 8;</item>
    /// <item>const unsigned short DOCUMENT_NODE = 9;</item>
    /// <item>const unsigned short DOCUMENT_TYPE_NODE = 10;</item>
    /// <item>const unsigned short DOCUMENT_FRAGMENT_NODE = 11;</item>
    /// <item>const unsigned short NOTATION_NODE = 12; // legacy</item>
    /// </list>
    /// </remarks>
    /// <seealso href="https://dom.spec.whatwg.org/#node"/>
    /// <see cref="https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmlnodetype?view=net-9.0"/>
    public enum DomNodeType
    {
        None = 0,
        Element = 1, 
        Attribute = 2,
        Text = 3, 
        CData = 4, 
        EntityReference, 
        Entity, 
        ProcessingInstruction, 
        Comment, 
        Document, 
        DocumentType, 
        DocumentFragment, 
        Notation
    };

}
