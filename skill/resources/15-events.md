# 15) Events（Application / Document）

目标：用扩展包提供的事件基类，把 Revit Application / Document 生命周期事件集中管理，并自动完成订阅/反订阅。

## Application 事件 / RevitApplicationEvents

支持：
- ApplicationInitialized
- ApplicationClosing
- SelectionChanged（仅 Revit 2023+）
- ThemeChanged（仅 Revit 2024+）

```csharp
using Autodesk.Revit.UI;
using Tuna.Revit.Extensions;

internal sealed class MyAppEvents : RevitApplicationEvents
{
    public MyAppEvents(UIControlledApplication app) : base(app) { }

    protected override void OnApplicationInitialized(object? sender, Autodesk.Revit.DB.Events.ApplicationInitializedEventArgs e)
    {
        // init after Revit fully initialized
    }
}
```

## Document 事件 / RevitDocumentEvents

```csharp
using Autodesk.Revit.ApplicationServices;
using Tuna.Revit.Extensions;

internal sealed class MyDocEvents : RevitDocumentEvents
{
    public MyDocEvents(Application app) : base(app) { }

    protected override void OnDocumentOpened(object? sender, Autodesk.Revit.DB.Events.DocumentOpenedEventArgs e)
    {
        // document opened
    }
}
```
