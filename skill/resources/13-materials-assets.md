# 13) Materials & Assets（Appearance / Color）

目标：读取/修改材质外观（Appearance Asset）的颜色，并处理颜色格式转换。

## 读取材质外观颜色 / GetAppearanceColor

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

Color color = material.GetAppearanceColor();
```

## 修改材质外观颜色 / SetAppearanceColor（Revit 2018+）

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

document.NewTransaction(() =>
{
    material.SetAppearanceColor(new Color(255, 0, 0));
}, "Set appearance color");
```

备注：`SetAppearanceColor` 在较早版本（Revit 2016/2017）不可用。

## 创建通用外观资源 / CreateAppearanceElement

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

document.NewTransaction(() =>
{
    AppearanceAssetElement? appearance = document.CreateAppearanceElement("My Generic Appearance");
}, "Create appearance");
```

## 从 Material 获取 AppearanceAssetElement

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

AppearanceAssetElement? appearance = material.GetAppearanceAssetElement();
```

## 颜色工具 / ColorExtensions

```csharp
using Tuna.Revit.Extensions;

string html = revitColor.ConvertToHTML();
Autodesk.Revit.DB.Color rc = drawingColor.ConvertToRevitColor();
bool same = c1.IsEqualTo(c2);
```
