using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Infrastructure.ApplicationServices;

namespace Tuna.Revit.Infrastructure.Commands;

/// <summary>
/// 
/// </summary>
public interface ITunaCommand
{
    /// <summary>
    /// 
    /// </summary>
    ICommandContext CommandContext { get; }

    /// <summary>
    /// 
    /// </summary>
    public ITunaApplication CurrentApplication { get; }

    /// <summary>
    /// 
    /// </summary>
    public HostApplication Host { get; }
}
