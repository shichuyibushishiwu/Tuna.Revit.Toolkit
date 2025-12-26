using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Infrastructure.Commands;

/// <summary>
/// 命令执行结果
/// </summary>
public class CommandResult
{
    /// <summary>
    /// 初始化命令执行结果
    /// </summary>
    public CommandResult()
    {
        Result = Result.Cancelled;
    }

    /// <summary>
    /// 命令结果状态
    /// </summary>
    public Result Result { get; set; }

    /// <summary>
    /// 返回消息
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// 返回元素集合
    /// </summary>
    public ElementSet? ElementSet { get; set; }
}
