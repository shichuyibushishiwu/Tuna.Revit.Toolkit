using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Extensions;

namespace Tuna.Revit.Infrastructure.ExternalEvent;

/// <summary>
/// 外部事件的返回值
/// </summary>
/// <typeparam name="T"></typeparam>
public class ExternalEventResult<T>: TunaAPIResult
{
    /// <summary>
    /// Value
    /// </summary>
    public T? Value { get; set; }

    /// <summary>
    /// ExternalEventRequest
    /// </summary>
    public ExternalEventRequest ExternalEventRequest { get; set; }
}
