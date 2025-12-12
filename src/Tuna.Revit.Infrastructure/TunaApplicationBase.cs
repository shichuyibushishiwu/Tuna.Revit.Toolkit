using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Extensions;
using Tuna.Revit.Infrastructure.ApplicationServices;

namespace Tuna.Revit.Infrastructure;

public abstract class TunaApplicationBase : IExternalApplication, ITunaApplication
{
    public IExternalEventService ExternalEventService => throw new NotImplementedException();

    public Result OnShutdown(UIControlledApplication application)
    {

        return Result.Succeeded;
    }

    public Result OnStartup(UIControlledApplication application)
    {
        return Result.Succeeded;
    }
}
