using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Extensions;

/// <summary>
/// 
/// </summary>
public static class ElementIdExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="elementId"></param>
    /// <returns></returns>
    public static long ToLong(this Autodesk.Revit.DB.ElementId elementId)
    {
        ArgumentNullExceptionUtils.ThrowIfNullOrInvalid(elementId);

#if Rvt_24_Before
        return elementId.IntegerValue;
#else
        return elementId.Value;
#endif
    }
}
