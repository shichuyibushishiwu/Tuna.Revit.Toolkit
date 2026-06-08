# 10) Parameters（Get/Set + Filter Rules + Attributes）

目标：用扩展方法更稳定地读写参数，并跨版本创建/解析参数过滤器。

## 按 StorageType 取值 / GetParameterValue<T>

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

Parameter? p = element.LookupParameter("Comments");
string? value = p?.GetParameterValue<string>();
```

常见类型映射：
- `StorageType.Integer` → `int`
- `StorageType.Double` → `double`（Revit 内部单位）
- `StorageType.String` → `string`
- `StorageType.ElementId` → `ElementId`

## 按 StorageType 设值 / SetParameterValue<T>

写参数必须在事务内：

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

document.NewTransaction(() =>
{
    Parameter? mark = element.GetParameter(BuiltInParameters.Mark);
    mark?.SetParameterValue("A-001");
}, "Set Mark");
```

## 参数过滤规则（跨版本）

Revit 2023+ 的 `ParameterFilterRuleFactory.CreateEqualsRule` 签名发生过变化，扩展包用统一入口封装：

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

FilterRule rule = ParameterFilterRuleFactoryExtensions.CreateEqualsRule(
    BuiltInParameters.Mark,
    "A-001",
    caseSensitive: false);
```

## ParameterFilterElement 的 ElementFilter（兼容老版本）

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

ElementFilter? filter = parameterFilterElement.GetElementFilter();
```

## 用特性绑定参数（Internal / External Definition）

当你想把“参数定义”写在模型类属性上，可用：
- `InternalDefinitionAttribute(BuiltInParameter)`
- `ExternalDefinitionAttribute(...)`

解析获取参数：

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

var attr = new InternalDefinitionAttribute(BuiltInParameter.ALL_MODEL_MARK);
Parameter mark = attr.GetUniqueParameter(element);
```
