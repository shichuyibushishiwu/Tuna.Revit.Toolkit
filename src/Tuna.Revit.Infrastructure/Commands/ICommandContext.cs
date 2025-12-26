using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Extensions;

namespace Tuna.Revit.Infrastructure.Commands;

/// <summary>
/// 命令上下文
/// </summary>
public interface ICommandContext : IDocumentContextProvider
{
    /// <summary>
    /// 外部事件服务实例
    /// </summary>
    IExternalEventService ExternalEventService { get; }
}
