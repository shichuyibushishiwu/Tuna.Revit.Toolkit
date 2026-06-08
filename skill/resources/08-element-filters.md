# 08) Element Filters（ElementFilterFactory + Collector）

目标：用 `ElementFilterFactory` 快速创建 Revit 过滤器，并配合 `Document/View.GetElements(...)` 进行高性能查询。

## 最常用的组合方式 / Common patterns

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;
using static Tuna.Revit.Extensions.ElementFilterFactory;

// 例：查找“墙 + 非类型 + 排除某些 Id”
ElementFilter filter = LogicalAnd(
    Category(BuiltInCategory.OST_Walls),
    ElementIsElementType(inverted: true),
    Excluding(excludeIds));

FilteredElementCollector walls = document.GetElements(filter);
```

`ElementFilterFactory` 常用方法：
- `Category(...)` / `Multicategory(...)`
- `Class(...)` / `Multiclass(...)`
- `LogicalAnd(...)` / `LogicalOr(...)`
- `Excluding(...)`
- `ElementIsElementType(inverted: false)`

## 在 View 中查询 / Query in a view

`View.GetElements(...)` 会把 collector 限定到视图范围（只返回该视图可见/可取到的元素）：

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

FilteredElementCollector doorsInView = view.GetElements(BuiltInCategory.OST_Doors);
```

## 在“指定 Id 列表”范围内二次过滤 / Filter within a known set

当你已经有一批 `ElementId`（例如 selection、或其他 collector 的结果），可以在“列表范围”内继续用过滤器做快筛：

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;
using static Tuna.Revit.Extensions.ElementFilterFactory;

ICollection<ElementId> ids = selectionIds;
ElementFilter filter = Category(BuiltInCategory.OST_Walls);

FilteredElementCollector wallsInSelection = document.GetElementsInCollector(ids, filter);
```

## 碰撞 / Intersects（示例）

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

FilteredElementCollector hits = document.GetElementIntersectsInCollector(candidateIds, targetElement);
```
