# 07) Pitfalls / 常见坑

- 类型名冲突：`Autodesk.Revit.DB.View` vs `System.Windows.Forms.View`，建议 `using RevitView = Autodesk.Revit.DB.View;`
- TaskDialog 冲突：`Autodesk.Revit.UI.TaskDialog` vs `System.Windows.Forms.TaskDialog`，建议 `using RevitTaskDialog = Autodesk.Revit.UI.TaskDialog;`
- BoundingBox 为空：`get_BoundingBox(view)` 可能为 null，必要时 fallback 到 `get_BoundingBox(null)` 或跳过
- Pin/约束/组：移动可能失败，需 try/catch 并汇总结果
