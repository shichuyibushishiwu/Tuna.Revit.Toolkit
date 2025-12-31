using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Infrastructure.ApplicationServices;

namespace Tuna.Revit.Infrastructure.Commands;

/// <summary>
/// 定义命令
/// </summary>
public interface ITunaCommand
{
    /// <summary>
    /// 访问命令上下文
    /// </summary>
    ICommandContext CommandContext { get; }

    /// <summary>
    /// 访问命令所属的扩展应用程序
    /// </summary>
    public ITunaApplication CurrentApplication { get; }

    /// <summary>
    /// 访问主程序
    /// </summary>
    public HostApplication Host { get; }
}
