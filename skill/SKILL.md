---
name: "tuna-revit-toolkit"
description: "Guides building Revit add-ins with Tuna.Revit.Extensions/Infrastructure (commands, ribbon, selection, transactions). Invoke when user asks how to do X with Tuna or is coding a Revit add-in."
---

# Tuna.Revit.Toolkit Skill

本技能是关于如何在 Revit 二开中使用 Tuna.Revit.Toolkit（常见为 Tuna.Revit.Extensions 与 Tuna.Revit.Infrastructure）完成查询、选择、事务、变换、Ribbon 与命令编写。

Use this skill when the user asks practical “how to do X with Tuna” questions: Document queries, selection, transactions, transforms, ribbon wiring, and command patterns.

## Quick routing / 快速定位

按功能分级把需求路由到 `resources/` / `templates/`，再从对应小节复制最短可运行代码。

### A) 入口与 UI（App / Ribbon / Command）

- App 入口（OnStartup / InitailizeComponents）→ `templates/app.tmpl.cs` + `resources/02-ribbon-wiring.md`
- Ribbon 挂载（Tab / Panel / Button / Icon）→ `resources/02-ribbon-wiring.md`
- Command 骨架 / 命令上下文（UIApplication/UIDocument/Document）→ `templates/command.tmpl.cs` + `resources/03-command-context.md`

### B) 交互与数据（Query / Selection）

- 图元查询 / element query（Document.GetElements...）→ `resources/01-element-query.md`
- 单选 / select one element（SelectElement）→ `resources/04-selection.md`
- 多选 / select multiple elements（SelectElements）→ `resources/04-selection.md`
- 框选 / select by rectangle（SelectElementsByRectangle）→ `resources/04-selection.md`  
  直接参考：[04-selection.md:L89-L109](resources/04-selection.md#L89-L109)
- 点选 / pick point（SelectPoint）→ `resources/04-selection.md`

### C) 修改模型（Transactions / Transforms）

- 事务 / transactions（NewTransaction / NewTransactionGroup）→ `resources/05-transactions.md`
- 变换 / transforms（Move / Rotate / Transform）→ `resources/06-transforms.md`

### D) 进阶（ExternalEvent / Transient / Pitfalls）

- 外部事件 / external event（非 Revit 上下文回到 Revit API）→ `resources/03-command-context.md`（ExternalEvent 段落）
- 临时显示 / transient display（TransientDisplay）→ `resources/06-transforms.md`（TransientDisplay 段落）
- 常见坑 / pitfalls → `resources/07-pitfalls.md`

## Fastest path / 最短上手路径

目标：用最少代码把 “App + Ribbon + Command” 跑起来，然后再叠加 selection / transaction / query。

### 1) Application 入口（Revit 启动时注册 Ribbon）

推荐继承 `TunaApplication` 并实现 `InitailizeComponents()`：
- 可复制骨架：`templates/app.tmpl.cs`
- 详细说明：`resources/02-ribbon-wiring.md`

### 2) Command 入口（从 TunaCommand 拿上下文 + 写业务）

推荐继承 `TunaCommand`，并在 `Execute()` 中拿到 `UIApplication/UIDocument/Document`：
- 可复制骨架：`templates/command.tmpl.cs`
- 详细说明：`resources/03-command-context.md`

### 3) 在事务里修改模型（推荐用 Extensions 的 NewTransaction）

修改模型必须进事务：优先使用 `document.NewTransaction(...)` / `document.NewTransactionGroup(...)`：
- 详细说明：`resources/05-transactions.md`

## How to use / 使用方式

当被调用时，请按以下顺序组织输出：
- 先给出最短路径（最少代码、最少步骤）让用户跑起来
- 再补充可选增强（过滤器、错误处理、多版本兼容、性能）
- 输出可直接粘贴的代码片段，并引用仓库内已有模式（如 `TunaApplication` / `TunaCommand`）

## Patterns / 输出模式（写答案时的默认套路）

- 如果用户问“怎么写插件入口 / Ribbon 怎么挂” → 先给 `TunaApplication + AddRibbonTab + AddRibbonPanel + AddPushButton` 的最短骨架，再补 `CommandButtonAttribute` 与图标路径规则。
- 如果用户问“怎么选 / 框选 / 点选” → 直接用 `SelectionExtensions`，并提醒用 `SelectionResult<T>.SelectionStatus` 判断是否 Cancelled。
- 如果用户问“怎么改模型 / 移动旋转” → 先包 `document.NewTransaction(...)`，再用 Revit API（如 `ElementTransformUtils`），并提示 pinned/constraints/group 失败场景。
- 如果用户问“怎么在非命令上下文改模型” → 先用 `IExternalEventService.PostCommand(...)` 把动作投递回 Revit 上下文。

## Knowledge layout / 知识结构

- 治理入口：`metadata.yaml`（版本、触发、归属等）
- 稳定性基座：`examples/`（输入输出示例）
- 结构一致性：`templates/`（可复用代码骨架）
- 确定性能力：`scripts/`（可执行检查/生成逻辑）
- 知识上下文：`resources/`（按需引用的详细说明）

优先从 `resources/` 选择最相关小节组合答案；需要给出“可复制骨架”时，引用 `templates/`；需要展示期望输出形态时，引用 `examples/`。
