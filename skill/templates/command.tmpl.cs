using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;
using Tuna.Revit.Extensions;
using Tuna.Revit.Infrastructure.Commands;

namespace {{NAMESPACE}};

[CommandButton(Title = "{{TITLE}}", Image = "{{ICON16}}", LargeImage = "{{ICON32}}")]
[Transaction(TransactionMode.Manual)]
internal sealed class {{CLASS_NAME}} : TunaCommand
{
    public override CommandResult Execute()
    {
        UIApplication uiApplication = this.Host.ApplicationContext.UIApplication;
        UIDocument uiDocument = uiApplication.ActiveUIDocument;
        var document = uiDocument.Document;

        return new CommandResult();
    }
}
