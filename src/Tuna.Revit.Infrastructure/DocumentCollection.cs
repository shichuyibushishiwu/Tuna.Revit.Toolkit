using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Events;
using Tuna.Revit.Infrastructure.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Infrastructure.Commands;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB.Events;
using Tuna.Revit.Extensions;

namespace Tuna.Revit.Infrastructure;

/// <summary>
/// 文档集合，提供当前打开的所有文档及激活文档
/// </summary>
public class DocumentCollection : IDocumentContextProvider, IEnumerable<IDocumentContext>
{
    private readonly List<IDocumentContext> _documents = new();

    /// <summary>
    /// 初始化文档集合，并构建当前打开的文档上下文列表
    /// </summary>
    internal DocumentCollection(Application application)
    {
        foreach (Document doc in application.Documents)
        {
            DocumentContext documentContext = new DocumentContext(doc);
            _documents.Add(documentContext);
            if (documentContext.IsActived)
            {
                ActivedDocument = documentContext;
            }
        }

        var uiapp = new UIApplication(application);
        if (uiapp != null)
        {
            uiapp.ViewActivated += OnViewActivated;
        }

        application.DocumentOpened += OnDocumentOpened;
        application.DocumentClosing += OnDocumentClosing;
    }

    /// <summary>
    /// 当前活动的文档
    /// </summary>
    public IDocumentContext? ActivedDocument { get; private set; }

    /// <summary>
    /// 获取文档集合的枚举器，用于遍历所有文档上下文
    /// </summary>
    /// <returns>文档上下文枚举器</returns>
    public IEnumerator<IDocumentContext> GetEnumerator()
    {
        return _documents.GetEnumerator();
    }

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <summary>
    /// 视图激活事件处理，更新当前激活文档
    /// </summary>
    /// <param name="sender">事件源</param>
    /// <param name="e">视图激活事件参数</param>
    private void OnViewActivated(object? sender, ViewActivatedEventArgs e)
    {
        if (e.CurrentActiveView == null)
        {
            return;
        }

        var doc = e.CurrentActiveView.Document;
        if (doc == null)
        {
            return;
        }

        var documentContext = _documents.FirstOrDefault(d => d.Document == doc);
        if (documentContext == null)
        {
            documentContext = new DocumentContext(doc);
            _documents.Add(documentContext);
        }
        ActivedDocument = documentContext;
    }

    /// <summary>
    /// 文档打开事件处理，添加新文档到集合
    /// </summary>
    /// <param name="sender">事件源</param>
    /// <param name="e">文档打开事件参数</param>
    protected void OnDocumentOpened(object? sender, DocumentOpenedEventArgs e)
    {
        var doc = e.Document;
        if (doc == null)
        {
            return;
        }

        if (_documents.Any(d => d.Document == doc))
        {
            return;
        }

        _documents.Add(new DocumentContext(doc));
    }

    /// <summary>
    /// 文档关闭事件处理，从集合移除文档
    /// </summary>
    /// <param name="sender">事件源</param>
    /// <param name="e">文档关闭事件参数</param>
    protected void OnDocumentClosing(object? sender, DocumentClosingEventArgs e)
    {
        var doc = e.Document;
        if (doc == null)
        {
            return;
        }

        var idx = _documents.FindIndex(d => d.Document == doc);
        if (idx >= 0)
        {
            var closing = _documents[idx];
            _documents.RemoveAt(idx);

            if (ActivedDocument == closing)
            {
                ActivedDocument = null;
            }
        }
    }
}
