# Example: Align command selection flow

## User asks

我想做一个对齐工具：先选基准，再选目标，然后事务里移动。

## Assistant should answer

- Command 基类里拿 `UIApplication/UIDocument/Document`
- `PickObject` 选基准，`PickObjects` 选目标
- 事务包裹 `ElementTransformUtils.MoveElement`
- 处理 `OperationCanceledException`
