using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Extensions;

/// <summary>
///
/// </summary>
public abstract class RevitDocumentEvents
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="application"></param>
    protected RevitDocumentEvents(Application application)
    {
        application.DocumentOpened += Application_DocumentOpened; 
        application.DocumentClosing += Application_DocumentClosing;
    }

    /// <summary>
    /// 文档关闭事件处理
    /// </summary>
    /// <param name="sender">事件源</param>
    /// <param name="e">文档关闭事件参数</param>
    private void Application_DocumentClosing(object? sender, DocumentClosingEventArgs e)
    {
        OnDocumentClosing(sender, e);
    }

    /// <summary>
    /// 文档打开事件处理
    /// </summary>
    /// <param name="sender">事件源</param>
    /// <param name="e">文档打开事件参数</param>
    private void Application_DocumentOpened(object? sender, DocumentOpenedEventArgs e)
    {
        OnDocumentOpened(sender, e);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected virtual void OnDocumentOpened(object? sender, DocumentOpenedEventArgs e) { }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected virtual void OnDocumentClosing(object? sender, DocumentClosingEventArgs e) { }
}
