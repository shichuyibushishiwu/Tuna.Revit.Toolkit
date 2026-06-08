# 04) Selection（SelectObject / SelectElements）

目标：使用 Tuna.Revit.Extensions 提供的选择扩展方法，统一用 `SelectionResult<T>` 返回选择结果，并支持预过滤。

## 选择方式 / Selection modes

- 单选 / Single: `SelectObject(...)` / `SelectElement(...)`
- 多选 / Multiple: `SelectObjects(...)` / `SelectElements(...)`
- 框选 / Rectangle: `SelectElementsByRectangle(...)`
- 选点 / Point: `SelectPoint(...)`

## 单选对象 / Select one object

```csharp
SelectionResult<Reference> result = uiDocument.SelectObject(
    Autodesk.Revit.UI.Selection.ObjectType.Face,
    prompt: "请选择一个要操作面");

if (result.SelectionStatus == SelectionStatus.Succeeded)
{
    Reference reference = result.Value;
}
```

### 单选预过滤 / Single selection pre-filter

过滤出链接文档中的面（示例：用 stable representation 判断 SURFACE）：

```csharp
SelectionResult<Reference> result = uiDocument.SelectObject(
    Autodesk.Revit.UI.Selection.ObjectType.LinkedElement,
    referencePredicate: parameters =>
        parameters.Reference?.ConvertToStableRepresentation(document).Contains("SURFACE") == true,
    prompt: "请选择链接的项目中一个要操作面");
```

过滤出链接文档中的墙体（示例：按类别过滤）：

```csharp
SelectionResult<Reference> result = uiDocument.SelectObject(
    Autodesk.Revit.UI.Selection.ObjectType.LinkedElement,
    elementPredicate: element => element.Category?.Id == BuiltInCategories.Walls,
    prompt: "请选择链接的项目中一个要操作面");
```

## 单选图元 / Select one element

```csharp
Element element = uiDocument.SelectElement("请选择一个要操作的图元");
```

按类别限制：

```csharp
Element element = uiDocument.SelectElement(BuiltInCategory.OST_Walls, "请选择一个要操作的图元");
```

复杂条件过滤（示例：回调过滤）：

```csharp
Element element = uiDocument.SelectElement(
    element => element is FamilyInstance instance && instance.Name == "Test",
    "请选择一个要操作的图元");
```

## 多选对象 / Select multiple objects

```csharp
SelectionResult<IList<Reference>> result = uiDocument.SelectObjects(
    Autodesk.Revit.UI.Selection.ObjectType.Face);

if (result.SelectionStatus == SelectionStatus.Succeeded)
{
    IList<Reference> references = result.Value;
}
```

同样也支持直接选择图元（示例：按类别多选）：

```csharp
SelectionResult<IList<Element>> result = uiDocument.SelectElements(BuiltInCategory.OST_Walls);

if (result.SelectionStatus == SelectionStatus.Succeeded)
{
    IList<Element> elements = result.Value;
}
```

## Select elements by rectangle

```csharp
SelectionResult<IList<Element>> result = uiDocument.SelectElementsByRectangle(BuiltInCategory.OST_Walls);

if (result.SelectionStatus == SelectionStatus.Succeeded)
{
    IList<Element> elements = result.Value;
}
```

## Select point

```csharp
SelectionResult<XYZ> result = uiDocument.SelectPoint("请选择一个点");

if (result.SelectionStatus == SelectionStatus.Succeeded)
{
    XYZ point = result.Value;
}
```

## Return type

扩展包将交互选择统一封装为 `SelectionResult<T>`：

```csharp
public class SelectionResult<T>
{
    public string Message { get; set; }
    public T Value { get; }
    public SelectionStatus SelectionStatus { get; set; }
    public Exception Exception { get; set; }
    public bool HasException { get; }
}
```

选择状态 / SelectionStatus：
- `SelectionStatus.Succeeded`：选择成功
- `SelectionStatus.Cancelled`：用户取消（如 ESC）
- `SelectionStatus.Failed`：选择失败（包含异常等情况）
