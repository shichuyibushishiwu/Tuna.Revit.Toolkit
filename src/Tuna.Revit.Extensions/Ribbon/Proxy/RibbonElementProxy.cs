using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tuna.Revit.Extensions.Ribbon.Proxy;

internal abstract class RibbonElementProxy<T>
{
    public T RevitRibbonObject { get; set; } = default!;

    public string Title { get; set; } = default!;
}
