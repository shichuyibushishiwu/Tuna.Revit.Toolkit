using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Extensions;
using Tuna.Revit.Infrastructure.ApplicationServices;

namespace Tuna.Revit.Infrastructure;

/// <summary>
/// 命令上下文
/// </summary>
public class CommandContext : ICommandContext
{
    /// <summary>
    /// 
    /// </summary>
    public CommandContext()
    {
        var uiDocument = HostApplication.Instance.ApplicationContext.UIApplication.ActiveUIDocument;
        
        DocumentCollection = new DocumentCollection();
    }

    /// <summary>
    /// 外部事件服务实例
    /// </summary>
    public IExternalEventService ExternalEventService { get; } = default!;

    /// <summary>
    /// 
    /// </summary>
    public IDocumentContext? ActivedDocument { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DocumentCollection DocumentCollection { get; set; }
}
