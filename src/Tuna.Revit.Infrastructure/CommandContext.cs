using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Extensions;

namespace Tuna.Revit.Infrastructure;

/// <summary>
/// 命令上下文
/// </summary>
public class CommandContext : ICommandContext
{
    /// <summary>
    /// 外部事件服务实例
    /// </summary>
    public IExternalEventService ExternalEventService => throw new NotImplementedException();
}
