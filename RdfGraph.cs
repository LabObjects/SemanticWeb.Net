using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Xml.Linq;

namespace SemanticWeb.Rdf;


// An RDF triple consists of three components:
//the subject, which is an IRI or a blank node
//the predicate, which is an IRI
//the object, which is an IRI, a literal or a blank node
//An RDF triple is conventionally written in the order subject, predicate, object.



public class RdfGraph
{

    #region Fields
    #endregion

    #region Constructors
    public RdfGraph() { }

    #endregion



    #region Properties
    #endregion

    #region Methods

    public void Load(string path)
    {

    }

    public void Load(Stream inputStream)
    {

    }

    #endregion


}
