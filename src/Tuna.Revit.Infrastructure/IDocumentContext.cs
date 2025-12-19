using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Infrastructure;

public interface IDocumentContext
{
    public Document Document { get; }

    public UIDocument UIDocument { get; }

    public Selection Selection { get; }
}
