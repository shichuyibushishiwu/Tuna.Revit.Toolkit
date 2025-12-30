# Tuna.Revit.Toolkit

![GitHub](https://img.shields.io/github/license/shichuyibushishiwu/Tuna.Revit.Extensions?label=License)
![GitHub](https://img.shields.io/badge/Shiwu-Tuna-green)

## 概述

Tuna.Revit.Toolkit 是一套针对 Autodesk Revit API 的扩展与基础设施集合，帮助你更快地编写稳定、可维护的 Revit 插件。该工具包涵盖常用 API 的扩展方法、命令与应用的基础框架、运行时资源注入，以及项目模板。

## 模块说明

- Extensions：提供丰富且跨版本的 Revit API 扩展方法与工具函数  
  详见模块文档：[`Tuna Revit Extensions`](src/Tuna.Revit.Extensions/readme.md)
- Infrastructure：提供插件应用与命令的抽象与基类，实现上下文、结果处理等基础设施  
  详见模块文档：[`Tuna Revit Infrastructure`](src/Tuna.Revit.Infrastructure/readme.md)
- Runtime：提供 WPF 资源注入等运行时支持，辅助 UI 与资源管理  
  详见模块文档：[`Tuna Revit Runtime`](src/Tuna.Runtime/readme.md)
- Template Pack：提供项目模板，便捷创建基于本工具包的 Revit 插件工程  
  详见模块文档：[`Tuna Revit Application Template`](template/pack/readme.md)

## 特性

- 简化常见 Revit API 操作
- 丰富的扩展方法与 UI Ribbon 帮助器
- 标准化的命令与应用框架
- 运行时资源注入，统一 UI 资源管理
- 支持多版本 Revit，兼容性良好

## NuGet 包

| 包名 | 说明 | 最新版本 | 下载 |
|---|---|---|---|
| Tuna.Revit.Extensions | 扩展方法集合 | `2016.2.x`<br/>`2017.2.x`<br/>`2018.2.x`<br/>`2019.0.x`<br/>`2020.0.x`<br/>`2021.0.x`<br/>`2022.0.x`<br/>`2023.0.x`<br/>`2024.0.x`<br/>`2025.0.x`<br/>`2026.0.x` | ![Nuget](https://img.shields.io/nuget/dt/Tuna.Revit.Extensions?style=flat&logo=nuget) |
| Tuna.Revit.Infrastructure | 插件基础设施 | `1.2.x` | ![Nuget](https://img.shields.io/nuget/dt/Tuna.Revit.Infrastructure?style=flat&logo=nuget) |
| Tuna.Revit.Application.Template | 项目模板 | `1.0.x` | ![Nuget](https://img.shields.io/nuget/dt/Tuna.Revit.Application.Template?style=flat&logo=nuget) |

## 快速上手

### 基于基础设施实现应用

```csharp
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Tuna.Revit.Extensions;

namespace MyRevitApp
{
    /// <summary>
    /// 示例应用：继承 TunaApplication
    /// </summary>
    public class MyApplication : TunaApplication
    {
        /// <summary>
        /// 初始化组件（如注册 Ribbon、外部事件等）
        /// </summary>
        public override void InitailizeComponents()
        {
            // 基础设施会在 OnStartup 中完成 Host 初始化与资源注入
        }
    }
}
```

### 基于基础设施实现命令

```csharp
using Autodesk.Revit.UI;
using Tuna.Revit.Infrastructure.ApplicationServices;
using Tuna.Revit.Infrastructure.Commands;

namespace MyRevitApp
{
    /// <summary>
    /// 示例命令：继承 TunaCommand
    /// </summary>
    public class SampleCommand : TunaCommand
    {
        /// <summary>
        /// 实际业务逻辑
        /// </summary>
        public override CommandResult Execute()
        {
            // 使用 CommandContext/Host 访问当前文档与应用上下文
            List<Wall> walls = CommandContext.ActiveDocumentContext.GetElements<Wall>();
            return this.Succeeded();
        }
    }
}
```

## 文档

更多使用指南与 API 说明，请访问[官方文档](https://shichuyibushishiwu.github.io/)

## 贡献

欢迎提交 Issue 与 Pull Request：
- Fork 仓库
- 创建分支：`git checkout -b feature/awesome`
- 提交代码：`git commit -m "feat: awesome feature"`
- 推送分支：`git push origin feature/awesome`
- 发起 Pull Request

## 许可

遵循 MIT 许可证，详见 [LICENSE](LICENSE)。

## 联系

- GitHub Issues: https://github.com/shichuyibushishiwu/Tuna.Revit.Toolkit/issues
- Email: 1012201478@qq.com
- WeChat ID: Tuna_ds

## 致谢

感谢所有贡献者与用户，特别感谢 Autodesk Revit API 社区与开源社区的支持。
