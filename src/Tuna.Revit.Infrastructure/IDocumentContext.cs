using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Infrastructure;

/// <summary>
/// 文档上下文，封装 Revit 文档及其 UI 交互对象
/// </summary>
public interface IDocumentContext
{
    /// <summary>
    /// Revit 文档对象
    /// </summary>
    public Document Document { get; }

    /// <summary>
    /// Revit UI 文档对象
    /// </summary>
    public UIDocument UIDocument { get; }

    /// <summary>
    /// 当前选择对象
    /// </summary>
    public Selection Selection { get; }

    /// <summary>
    /// 是否为当前激活文档
    /// </summary>
    public bool IsActived { get; }
}
