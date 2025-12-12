using Autodesk.Revit.UI;

/// Power by shiwu
namespace Tuna.Revit.Template
{
    /// <summary>
    /// The revit application plugin
    /// </summary>
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
}

