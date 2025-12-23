using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Infrastructure;

public class DocumentCollection : IEnumerable<IDocumentContext>
{
    public DocumentCollection()
    {
        
    }

    public IEnumerator<IDocumentContext> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
