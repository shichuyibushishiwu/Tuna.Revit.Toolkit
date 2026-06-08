# 16) Ribbon Icons（ResourceManager + Resolver）

目标：说明扩展包如何解析 Ribbon 图标，以及如何配置相对路径的图标根目录。

## 图标解析支持的输入类型 / Supported sources

`RibbonImageResovler` 支持：
- `string`：Pack URI / 文件路径（绝对或相对）
- `System.Drawing.Bitmap`
- `System.Windows.Media.ImageSource`
- `System.Uri`

当传入 `string` 且是相对路径时，会尝试在 `rootPath + IconRelativePath` 下查找。

## 配置相对路径图标根目录 / Configure icon folder

默认 `IconRelativePath` 为 `Assets\\Icon`，可在启动前通过 `AppDomain.CurrentDomain` 配置：

```csharp
using System;
using Tuna.Revit.Extensions;

AppDomain.CurrentDomain.SetData(
    ResourceManager.TunaRevitApplicationResourceIconPath,
    @"Assets\MyIcons");
```

## Bitmap → ImageSource

```csharp
using System.Drawing;
using System.Windows.Media.Imaging;
using Tuna.Revit.Extensions;

Bitmap bitmap = new Bitmap(@"D:\icon.png");
BitmapSource source = bitmap.ConvertToBitmapSource();
```
