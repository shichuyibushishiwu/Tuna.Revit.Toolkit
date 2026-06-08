# 03) Command Context（TunaCommand）

目标：在 `TunaCommand.Execute()` 中获取 `UIApplication/UIDocument/Document`，并处理取消。

```csharp
using Autodesk.Revit.UI;
using Tuna.Revit.Infrastructure.Commands;

internal abstract class SampleCommandBase : TunaCommand
{
    public override CommandResult Execute()
    {
        UIApplication uiApplication = this.Host.ApplicationContext.UIApplication;
        UIDocument uiDocument = uiApplication.ActiveUIDocument;
        var document = uiDocument.Document;

        return new CommandResult();
    }
}
```

取消处理 / Cancellation：
- 用户按 ESC 取消 PickObject(s) 时通常抛 `Autodesk.Revit.Exceptions.OperationCanceledException`，捕获后直接返回。

## ExternalEvent（从非命令上下文回到 Revit API）

当你在 WPF/异步回调中需要执行 Revit API，使用 `IExternalEventService` 把动作投递回 Revit 上下文：

```csharp
using Autodesk.Revit.UI;
using Tuna.Revit.Extensions;

IExternalEventService service = new ExternalEventService();
service.PostCommand(uiApp =>
{
    UIDocument uiDoc = uiApp.ActiveUIDocument;
    var document = uiDoc.Document;

    document.NewTransaction(() =>
    {
        // safe Revit API calls here
    }, "Do work");
});
```

更完整的用法（含 async）：见 `resources/14-external-event.md`。
