using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Extensions;

namespace Tuna.Sample.Commands;

[Transaction(TransactionMode.Manual)]
internal class CommandA : IExternalCommand, IRibbonButtonData
{
    public string Title => "ss";

    public string LongDescription => "";

    public string ToolTip => "";

    public object Image => "gift16.png";

    public object LargeImage => "gift32.png";

    public object ToolTipImage => "";

    public ContextualHelp ContextualHelp => new ContextualHelp(ContextualHelpType.Url, "https://shichuyibushishiwu.github.io/");

    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
    {
        UIDocument uiDocument = commandData.Application.ActiveUIDocument;

        Document document = uiDocument.Document;
        document.TransientDisplay(new List<GeometryObject>()
            {
                Line.CreateBound(XYZ.Zero, XYZ.Zero + new XYZ(20, 20, 20))
            });
     
        return Result.Succeeded;
    }
}

[CommandButton(LargeImage = "gift32.png", Image = "gift16.png")]
[Transaction(TransactionMode.Manual)]
internal class CommandB : IExternalCommand
{
    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
    {
        UIDocument uiDocument = commandData.Application.ActiveUIDocument;

        Document document = uiDocument.Document;
        document.CleanTransientElements();
        TaskDialog.Show("msg", "B");
        return Result.Succeeded;
    }
}
