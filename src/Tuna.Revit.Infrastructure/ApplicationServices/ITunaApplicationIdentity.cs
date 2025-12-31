using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Infrastructure.ApplicationServices;

/// <summary>
/// 定义扩展应用程序的标识
/// </summary>
public interface ITunaApplicationIdentity
{
    /// <summary>
    /// 应用名称
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// 唯一标识符
    /// </summary>
    Guid Guid { get; }
}
