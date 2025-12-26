using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Infrastructure.Commands;

/// <summary>
/// 命令结果扩展方法
/// </summary>
public static class CommandResultExtensions
{
    /// <summary>
    /// 命令执行成功
    /// </summary>
    /// <param name="command">Tuna 命令接口</param>
    /// <returns>命令结果</returns>
    public static CommandResult Succeeded(this ITunaCommand command)
    {
        if (command is null)
        {
            throw new ArgumentNullException(nameof(command));
        }

        return new CommandResult()
        {
            Result = Result.Succeeded
        };
    }

    /// <summary>
    /// 命令执行成功
    /// </summary>
    /// <param name="command">Tuna 命令接口</param>
    /// <param name="message">返回消息</param>
    /// <returns>命令结果</returns>
    public static CommandResult Succeeded(this ITunaCommand command, string message)
    {
        if (command is null)
        {
            throw new ArgumentNullException(nameof(command));
        }

        return new CommandResult()
        {
            Result = Result.Succeeded,
            Message = message
        };
    }

    /// <summary>
    /// 命令执行成功
    /// </summary>
    /// <param name="command">Tuna 命令接口</param>
    /// <param name="elements">返回元素集合</param>
    /// <returns>命令结果</returns>
    public static CommandResult Succeeded(this ITunaCommand command, ElementSet elements)
    {
        if (command is null)
        {
            throw new ArgumentNullException(nameof(command));
        }

        return new CommandResult()
        {
            Result = Result.Succeeded,
            ElementSet = elements
        };
    }

    /// <summary>
    /// 命令执行成功
    /// </summary>
    /// <param name="command">Tuna 命令接口</param>
    /// <param name="message">返回消息</param>
    /// <param name="elements">返回元素集合</param>
    /// <returns>命令结果</returns>
    public static CommandResult Succeeded(this ITunaCommand command, string message, ElementSet elements)
    {
        if (command is null)
        {
            throw new ArgumentNullException(nameof(command));
        }

        return new CommandResult()
        {
            Result = Result.Succeeded,
            Message = message,
            ElementSet = elements
        };
    }

    /// <summary>
    /// 命令取消
    /// </summary>
    /// <param name="command">Tuna 命令接口</param>
    /// <returns>命令结果</returns>
    public static CommandResult Cancelled(this ITunaCommand command)
    {
        if (command is null)
        {
            throw new ArgumentNullException(nameof(command));
        }

        return new CommandResult()
        {
            Result = Result.Cancelled
        };
    }

    /// <summary>
    /// 命令取消
    /// </summary>
    /// <param name="command">Tuna 命令接口</param>
    /// <param name="message">返回消息</param>
    /// <returns>命令结果</returns>
    public static CommandResult Cancelled(this ITunaCommand command, string message)
    {
        if (command is null)
        {
            throw new ArgumentNullException(nameof(command));
        }

        return new CommandResult()
        {
            Result = Result.Cancelled,
            Message = message
        };
    }

    /// <summary>
    /// 命令取消
    /// </summary>
    /// <param name="command">Tuna 命令接口</param>
    /// <param name="elements">返回元素集合</param>
    /// <returns>命令结果</returns>
    public static CommandResult Cancelled(this ITunaCommand command, ElementSet elements)
    {
        if (command is null)
        {
            throw new ArgumentNullException(nameof(command));
        }

        return new CommandResult()
        {
            Result = Result.Cancelled,
            ElementSet = elements
        };
    }

    /// <summary>
    /// 命令取消
    /// </summary>
    /// <param name="command">Tuna 命令接口</param>
    /// <param name="message">返回消息</param>
    /// <param name="elements">返回元素集合</param>
    /// <returns>命令结果</returns>
    public static CommandResult Cancelled(this ITunaCommand command, string message, ElementSet elements)
    {
        if (command is null)
        {
            throw new ArgumentNullException(nameof(command));
        }

        return new CommandResult()
        {
            Result = Result.Cancelled,
            Message = message,
            ElementSet = elements
        };
    }

    /// <summary>
    /// 命令执行失败
    /// </summary>
    /// <param name="command">Tuna 命令接口</param>
    /// <returns>命令结果</returns>
    public static CommandResult Failed(this ITunaCommand command)
    {
        if (command is null)
        {
            throw new ArgumentNullException(nameof(command));
        }

        return new CommandResult()
        {
            Result = Result.Failed
        };
    }

    /// <summary>
    /// 命令执行失败
    /// </summary>
    /// <param name="command">Tuna 命令接口</param>
    /// <param name="message">返回消息</param>
    /// <returns>命令结果</returns>
    public static CommandResult Failed(this ITunaCommand command, string message)
    {
        if (command is null)
        {
            throw new ArgumentNullException(nameof(command));
        }

        return new CommandResult()
        {
            Result = Result.Failed,
            Message = message
        };
    }

    /// <summary>
    /// 命令执行失败
    /// </summary>
    /// <param name="command">Tuna 命令接口</param>
    /// <param name="elements">返回元素集合</param>
    /// <returns>命令结果</returns>
    public static CommandResult Failed(this ITunaCommand command, ElementSet elements)
    {
        if (command is null)
        {
            throw new ArgumentNullException(nameof(command));
        }

        return new CommandResult()
        {
            Result = Result.Failed,
            ElementSet = elements
        };
    }

    /// <summary>
    /// 命令执行失败
    /// </summary>
    /// <param name="command">Tuna 命令接口</param>
    /// <param name="message">返回消息</param>
    /// <param name="elements">返回元素集合</param>
    /// <returns>命令结果</returns>
    public static CommandResult Failed(this ITunaCommand command, string message, ElementSet elements)
    {
        if (command is null)
        {
            throw new ArgumentNullException(nameof(command));
        }

        return new CommandResult()
        {
            Result = Result.Failed,
            Message = message,
            ElementSet = elements
        };
    }
}
