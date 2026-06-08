using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Extensions;

namespace Tuna.Revit.Infrastructure.ApplicationServices;

internal class TunaApplicationUI : ITunaApplicationUI
{
    public void AddDockablePane(string paneId)
    {
 
    }

    public void AddMenuItem(string tabName)
    {
       
    }

    public IRibbonTab AddRibbonTab(string tabName)
    {
        return HostApplication.Instance.ApplicationContext.UIControlledApplication.AddRibbonTab(tabName);
    }
}
