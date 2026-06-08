# 09) Document & Element Utils

目标：汇总 `DocumentExtensions` / `ElementExtensions` 中最常用的“查询/辅助/安全封装”能力。

## 强类型取图元 / GetElement<T>

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

Wall wall = document.GetElement<Wall>(wallId);
```

## 生成唯一名称 / GetUniqueName<T>

用于创建族类型、材质、过滤器等“名称必须唯一”的对象：

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

string unique = document.GetUniqueName<ParameterFilterElement>("My Filter");
```

## 创建参数过滤器 / CreateParameterFilterElement

跨版本封装（Revit 2016–2026）创建 `ParameterFilterElement`：

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

FilterRule rule = ParameterFilterRuleFactoryExtensions.CreateContainsRule(
    BuiltInParameters.Mark,
    "A",
    caseSensitive: false);

ParameterFilterElement filterElement = document.CreateParameterFilterElement(
    name: "Mark contains A",
    ids: new[] { new ElementId(BuiltInCategory.OST_Walls) },
    filterRule: rule);
```

## 统计类型实例数量 / GetElementTypesAndInstancesCount<T>

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

IDictionary<ElementType, int> counts = document.GetElementTypesAndInstancesCount<Wall>();
```

## 通过参数 Id 获取参数 / Element.GetParameter(ElementId)

配合 `BuiltInParameters`（扩展包的 `ElementId` 常量）更方便：

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

Parameter? mark = element.GetParameter(BuiltInParameters.Mark);
```

## 视图中碰撞查询（注意 BoundingBox 可能为 null）

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

FilteredElementCollector hits = element.TryGetIntersectElements(view);
```
