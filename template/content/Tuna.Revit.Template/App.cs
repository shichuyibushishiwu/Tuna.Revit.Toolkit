using Tuna.Revit.Extensions;
using Tuna.Revit.Infrastructure.ApplicationServices;


namespace Tuna.Revit.Template
{
    /// <summary>
    /// The revit application plugin
    /// </summary>
    public class App : TunaApplication
    {
        public override void InitailizeComponents()
        {
            this.Host.ApplicationContext.UIControlledApplication
                .AddRibbonTab("Tuna")
                .AddRibbonPanel("Commands", panel =>
                {
                    panel.AddPushButton<Commands.Command>();
                });
        }
    }
}

