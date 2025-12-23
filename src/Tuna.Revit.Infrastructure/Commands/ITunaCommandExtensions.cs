using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Infrastructure.Commands;

/// <summary>
/// 
/// </summary>
public static class ITunaCommandExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="command"></param>
    /// <returns></returns>
    public static CommandResult Succeeded(this ITunaCommand command)
    {
        if (command is null)
        {
            throw new ArgumentNullException(nameof(command));
        }

        return new CommandResult()
        {
            Result = Autodesk.Revit.UI.Result.Succeeded
        };
    }


}
