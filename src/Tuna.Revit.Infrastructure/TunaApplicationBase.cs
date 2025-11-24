using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Infrastructure.ApplicationServices;

namespace Tuna.Revit.Infrastructure;

internal class TunaApplicationBase : IExternalApplication, ITunaApplication
{
    public Result OnShutdown(UIControlledApplication application)
    {
        throw new NotImplementedException();
    }

    public Result OnStartup(UIControlledApplication application)
    {
        throw new NotImplementedException();
    }
}
