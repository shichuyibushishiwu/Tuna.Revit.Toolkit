# 06) Element Transforms

目标：使用 Revit API 对图元进行移动/旋转等变换。

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

document.NewTransaction(() =>
{
    XYZ offset = new XYZ(1, 0, 0);
    ElementTransformUtils.MoveElement(document, elementId, offset);
}, name: "Move element");
```

实践建议：

- 变换本身用 Revit API（`ElementTransformUtils` / `Location` 等），事务建议用 `document.NewTransaction(...)` 统一处理提交/回滚。
- `Pinned` / 约束 / 组内图元可能导致移动失败，建议 try/catch 并汇总失败原因（也可参考 [07-pitfalls](07-pitfalls.md)）。

## Rotate / 旋转

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

document.NewTransaction(() =>
{
    Line axis = Line.CreateUnbound(origin, XYZ.BasisZ);
    double angleRadians = Math.PI / 6;
    ElementTransformUtils.RotateElement(document, elementId, axis, angleRadians);
}, name: "Rotate element");
```

## Transform helper / Transform 扩展

当你需要复制一个 `Transform`（避免直接复用引用导致后续被修改）：

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

Transform copied = originalTransform.Duplicate();
```
