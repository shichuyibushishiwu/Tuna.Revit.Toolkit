using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Extensions;

namespace Tuna.Revit.Infrastructure.ApplicationServices;

/// <summary>
/// 
/// </summary>
public interface ITunaApplicationUI
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="tabName"></param>
    public IRibbonTab AddRibbonTab(string tabName);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="tabName"></param>
    public void AddMenuItem(string tabName);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="paneId"></param>
    public void AddDockablePane(string paneId);
}
