using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
