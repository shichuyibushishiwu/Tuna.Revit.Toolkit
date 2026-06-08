# 05) Transactions

目标：在 Revit 中修改模型必须包裹在事务中。

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

TransactionResult result = document.NewTransaction(() =>
{
    // Do modifications here, e.g.:
    // ElementTransformUtils.MoveElement(document, elementId, new XYZ(1, 0, 0));
}, name: "My Transaction");

if (result.TransactionStatus != TransactionStatus.Committed)
{
    // result.Message / result.Exception contains details
}
```

实践建议：

- 修改模型前先判断是否只读：扩展方法内部会对 `document.IsReadOnly` 做保护。
- 推荐把所有“可能失败”的 API 调用放进同一个事务里，失败时会自动 RollBack，并把异常写进 `TransactionResult`。
- 需要把多个事务合并/分组时，用 `NewTransactionGroup`。

## TransactionGroup（多事务合并）

```csharp
using Tuna.Revit.Extensions;

TransactionResult groupResult = document.NewTransactionGroup(option =>
{
    document.NewTransaction(() =>
    {
        // step 1
    }, "Step 1");

    document.NewTransaction(() =>
    {
        // step 2
    }, "Step 2");

    option.Merge(); // Assimilate：把内部事务合并成一次提交
}, name: "My Transaction Group");
```
