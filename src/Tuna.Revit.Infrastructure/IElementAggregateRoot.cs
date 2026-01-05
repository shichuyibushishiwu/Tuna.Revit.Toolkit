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
    /// 访问当前图元所在的文档
    /// </summary>
    public Document Document { get; }

    /// <summary>
    /// 访问当前图元的Id
    /// </summary>
    public ElementId ElementId { get; }

    /// <summary>
    /// 访问当前图元的名称
    /// </summary>
    public string Name { get; set; }

}
