using Autodesk.Revit.UI;

namespace Tuna.Revit.Addin;


public class App : IExternalApplication
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