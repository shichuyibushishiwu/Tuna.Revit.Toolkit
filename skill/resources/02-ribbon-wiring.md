# 02) Ribbon Wiring（TunaApplication + Extensions）

目标：在 Revit 启动时注册 Tab/Panel/Button，并把命令类挂到按钮上。

## Application 入口模式

```csharp
using Tuna.Revit.Extensions;
using Tuna.Revit.Infrastructure.ApplicationServices;

namespace MyAddin;

public sealed class App : TunaApplication
{
    public override void InitailizeComponents()
    {
        IRibbonTab tab = this.ApplicationUI.AddRibbonTab("Tuna");
        tab.AddRibbonPanel("Tools", panel =>
        {
            panel.AddPushButton<Commands.MyCommand>();
        });
    }
}
```

## 按钮元数据

常见用特性声明按钮标题、图标等（以你仓库现有用法为准）：

```csharp
using Autodesk.Revit.Attributes;
using Tuna.Revit.Extensions;
using Tuna.Revit.Infrastructure.Commands;

namespace MyAddin.Commands;

[CommandButton(
    Title = "My Tool",
    ToolTip = "Do something",
    Image = "pack://application:,,,/MyAddin;component/Assets/Icon/gift16.png",
    LargeImage = "pack://application:,,,/MyAddin;component/Assets/Icon/gift32.png")]
[Transaction(TransactionMode.Manual)]
internal sealed class MyCommand : TunaCommand
{
    public override CommandResult Execute()
    {
        return new CommandResult();
    }
}
```

## Fluent wiring（Panel 上链式添加按钮）

`AddRibbonPanel(..., panel => ...)` 支持链式构建：

```csharp
IRibbonTab tab = this.ApplicationUI.AddRibbonTab("tuna");
tab.AddRibbonPanel("archi", panel =>
{
    panel.AddPushButton<Commands.CommandA>()
        .AddSeparator()
        .AddPulldownButton("pdb", pbt => pbt
            .AddPushButton<Commands.CommandA>()
            .AddSeparator()
            .AddPushButton<Commands.CommandB>())
        .AddSplitButton("stb", slt => slt
            .AddPushButton<Commands.CommandA>()
            .AddSeparator()
            .AddPushButton<Commands.CommandB>())
        .AddComboBox("cb", cb => cb.AddItem("A").AddItem("B"));
});
```

## Icon resolution / 图标解析规则

Ribbon 图标最终需要 `ImageSource`。扩展包支持以下几种来源：

- Pack URI（推荐，用 Resource/Embedded 的方式随程序集发布）：`pack://application:,,,/Assembly;component/Assets/Icon/gift32.png`
- 绝对文件路径：`D:\...\gift32.png`
- `System.Drawing.Bitmap` / `ImageSource` / `Uri`（如果你在代码里自行加载）
