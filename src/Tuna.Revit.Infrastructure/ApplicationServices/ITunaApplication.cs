using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Extensions;

namespace Tuna.Revit.Infrastructure.ApplicationServices;

/// <summary>
/// 定义应用程序
/// </summary>
public interface ITunaApplication
{
    /// <summary>
    /// 外部事件服务实例
    /// </summary>
    IExternalEventService ExternalEventService { get; }
}
