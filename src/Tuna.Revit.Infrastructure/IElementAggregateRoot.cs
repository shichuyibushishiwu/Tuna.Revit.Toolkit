using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Infrastructure;

/// <summary>
/// 图元聚合根
/// </summary>
public interface IElementAggregateRoot
{
    public Document Document { get; set; }

    public ElementId ElementId { get; set; }

}
