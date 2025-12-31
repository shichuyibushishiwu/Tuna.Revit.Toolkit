using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Extensions;
using Tuna.Revit.Infrastructure.ApplicationServices;

namespace Tuna.Revit.Infrastructure.Commands;

/// <summary>
/// 命令上下文
/// </summary>
public class CommandContext : ICommandContext
{
    /// <summary>
    /// 初始化命令上下文
    /// </summary>
    public CommandContext()
    {
        CurrentApplication = HostApplication.Instance.Applications.ActivedApplication;
        ExternalEventService = CurrentApplication.ExternalEventService;
    }

    /// <inheritdoc/>
    public ITunaApplication CurrentApplication { get; }

    /// <inheritdoc/>
    public IExternalEventService ExternalEventService { get; } = default!;

    /// <inheritdoc/>
    public IDocumentContext? ActivedDocument => HostApplication.Instance.ApplicationContext.Documents.ActivedDocument;
}
