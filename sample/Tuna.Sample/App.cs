using Tuna.Revit.Extensions;
using Tuna.Revit.Infrastructure.ApplicationServices;


namespace Tuna.Sample
{
    /// <summary>
    /// The revit application plugin
    /// </summary>
    public class App : TunaApplication
    {
        public override void InitailizeComponents()
        {
            IRibbonTab tab = this.ApplicationUI.AddRibbonTab("tuna");
            tab.AddRibbonPanel("archi", panel =>
            {
                panel.AddPushButton<Commands.CommandA>()
                .AddSeparator()
                .AddPulldownButton("pdb", pbt => pbt
                    .AddPushButton<Commands.CommandA>()
                    .AddSeparator()
                    .AddPushButton<Commands.CommandB>()
                    .Configurate(d =>
                    {
                        d.LargeImage = "compass.png";
                    }))
                .AddSplitButton("stb", slt => slt
                    .AddPushButton<Commands.CommandA>()
                    .AddSeparator()
                    .AddPushButton<Commands.CommandB>())
                .AddComboBox("s", cb => cb.AddItem("dd").AddItem("ssad").OnSelectedChanged(e =>
                {

                }))
                .AddSlideOut();
            });

        }
    }

}
