using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Infrastructure.Commands;

/// <summary>
/// 
/// </summary>
public class CommandResult
{
    /// <summary>
    /// 
    /// </summary>
    public CommandResult()
    {
        Result = Result.Cancelled;
    }

    /// <summary>
    /// 
    /// </summary>
    public Result Result { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ElementSet? ElementSet { get; set; }
}
