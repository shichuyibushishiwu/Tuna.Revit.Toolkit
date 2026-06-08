# 01) Element Query（Document.GetElements）

目标：用 Tuna.Revit.Extensions 提供的 `Document.GetElements...` 系列快速查询文档内的图元/类型。

## 按类型查询 / Query by type

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

FilteredElementCollector elements = document.GetElements(typeof(Wall));
```

也可以用泛型拿到更强类型的结果：

```csharp
IEnumerable<Wall> walls = document.GetElements<Wall>();
IEnumerable<Wall> walls2 = document.GetElements<Wall>(w => w.Name == "100");
```

差异说明：
- `GetElements(typeof(...))` 返回 `FilteredElementCollector`，便于继续链式过滤
- `GetElements<T>()` 返回 `IEnumerable<T>`，便于直接 LINQ/强类型处理

多类型查询 / Query multiple types：

```csharp
IEnumerable<Element> elements2 = document.GetElements(typeof(Wall), typeof(Floor));
```

## 按类别查询 / Query by category

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

FilteredElementCollector walls = document.GetElements(BuiltInCategory.OST_Walls);
```

如果你的代码使用了 BuiltInCategories（扩展包提供的类别常量），也可以传 `ElementId`：

```csharp
FilteredElementCollector doors = document.GetElements(BuiltInCategories.Doors);
```

## 备注 / Remarks

- 不是所有 `Element` 子类都支持“快速查询”；对 Room/Area/Space 等类型，扩展包会做兼容处理（可能走慢速查询）。
