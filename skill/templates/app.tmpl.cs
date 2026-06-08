using Tuna.Revit.Extensions;
using Tuna.Revit.Infrastructure.ApplicationServices;

namespace {{NAMESPACE}};

public class App : TunaApplication
{
    public override void InitailizeComponents()
    {
        var tab = this.Host.ApplicationContext.UIControlledApplication.AddRibbonTab("{{TAB_NAME}}");

        tab.AddRibbonPanel("{{PANEL_NAME}}", panel =>
        {
            panel.AddPushButton<{{COMMAND_FULLNAME}}>();
        });
    }
}
