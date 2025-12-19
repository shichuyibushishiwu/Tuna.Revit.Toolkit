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
    /// <summary>
    /// 当前图元所在的文档
    /// </summary>
    public Document Document { get; set; }

    /// <summary>
    /// 当前图元的Id
    /// </summary>
    public ElementId ElementId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }

}
