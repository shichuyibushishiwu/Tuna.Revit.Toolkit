using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Tuna.Revit.Infrastructure.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Infrastructure;

internal class DocumentContext : IDocumentContext
{
    /// <summary>
    /// 初始化文档上下文
    /// </summary>
    /// <param name="document">目标 Revit 文档</param>
    public DocumentContext(Document document)
    {
        Document = document;
        UIDocument = new UIDocument(document);

        Selection = UIDocument.Selection;
    }

    /// <inheritdoc/>
    public Document Document { get; }

    /// <inheritdoc/>
    public UIDocument UIDocument { get; }

    /// <inheritdoc/>
    public Selection Selection { get; }

    /// <inheritdoc/>
    public bool IsActived => UIDocument.ActiveGraphicalView != null;
}
