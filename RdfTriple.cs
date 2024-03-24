using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanticWeb.Rdf
{
    public class RdfTriple
    {
        public object Subject { get; set; }
        public object Predicate { get; set; }
        public object Object { get; set; }
    }
}
