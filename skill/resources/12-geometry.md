# 12) Geometry（Resolve + Vector + Transform + Transient）

目标：用扩展方法更容易地获取图元几何（Solid/Face），做基础向量判断，并创建临时显示几何（Transient）。

## 解析 Solid / Face

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

List<Solid> solids = element.ResolveSolids(opt =>
{
    opt.ComputeReferences = true;
    opt.DetailLevel = ViewDetailLevel.Fine;
    opt.GeometryType = GeometryType.Instance; // 或 GeometryType.Symbol
});

List<Face> faces = element.ResolveFaces(opt =>
{
    opt.DetailLevel = ViewDetailLevel.Fine;
});
```

## FaceArray → Face[]

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

Face[] faceArray = solid.Faces.ToArray();
```

## XYZ 向量工具 / Vector helpers

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

XYZ moved = point.Translate(direction: XYZ.BasisX, distance: 10);
bool parallel = v1.IsAlmostParallelTo(v2);
bool codir = v1.IsAlmostCodirectionalTo(v2);
bool vertical = v1.IsAlmostVerticalTo(v2);
```

## Transform 复制 / Duplicate

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

Transform copied = original.Duplicate();
```

## 临时显示 / TransientDisplay

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

ElementId id = document.TransientDisplay(geometryObject);

// 用完清理（会在事务内删除由 Tuna 创建的 transient 元素）
document.CleanTransientElement(id);
```
