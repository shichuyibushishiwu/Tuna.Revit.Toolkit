# 14) ExternalEvent（IExternalEventService）

目标：在“非 Revit API 上下文”（例如 WPF UI、线程/异步回调）安全执行 Revit API。

## 同步投递 / PostCommand

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

## 异步投递 / PostCommandAsync

```csharp
using Autodesk.Revit.UI;
using Tuna.Revit.Extensions;

IExternalEventService service = new ExternalEventService();

await service.PostCommandAsync(uiApp =>
{
    // do something and return a value
    return uiApp.ActiveUIDocument.Document.Title;
});
```

返回值是 `Task<ExternalEventResult<TResult>>`，当执行过程中抛异常时会通过 `Task` 传播。
