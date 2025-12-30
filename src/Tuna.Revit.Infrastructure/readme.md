# Tuna.Revit.Infrastructure

## 概述

Tuna.Revit.Infrastructure 提供构建 Revit 插件的基础设施与抽象，包括应用程序与命令的基类、命令上下文与执行结果、宿主应用上下文等，帮助你以一致的方式组织插件代码。

## 功能亮点

- TunaApplication：统一应用生命周期（OnStartup/OnShutdown），集成资源注入与 Host 维护
- TunaCommand：统一命令执行入口，内置可用性检查与结果处理
- CommandContext/DocumentContext：封装当前文档与 UI 上下文
- CommandResult 与辅助扩展：标准化返回状态、消息与元素集合
- HostApplication/HostApplicationContext：集中维护 UIControlledApplication/UIApplication/Application/文档集合

## 安装

- NuGet 包：`Tuna.Revit.Infrastructure`
- 可与 `Tuna.Revit.Extensions` 一同使用，按需引用

## 快速上手

```csharp
using Autodesk.Revit.UI;
using Tuna.Revit.Infrastructure.ApplicationServices;
using Tuna.Revit.Infrastructure.Commands;

namespace Samples
{
    /// <summary>
    /// 示例应用：继承 TunaApplication
    /// </summary>
    public class SampleApplication : TunaApplication
    {
        /// <summary>
        /// 初始化组件（注册 Ribbon、外部事件等）
        /// </summary>
        public override void InitailizeComponents()
        {
            // 此处可进行菜单注册、事件初始化等
        }
    }

    /// <summary>
    /// 示例命令：继承 TunaCommand
    /// </summary>
    public class SampleCommand : TunaCommand
    {
        /// <summary>
        /// 执行实际业务逻辑，并返回标准化结果
        /// </summary>
        public override CommandResult Execute()
        {
            // 使用 Host 与 CommandContext 访问当前应用与文档环境
            // var doc = CommandContext.ActivedDocument?.Document;
            return this.Succeeded();
        }

        /// <summary>
        /// 可选：决定命令是否可用
        /// </summary>
        public override bool CanExecute() => true;
    }
}
```

## 关键类型

- ApplicationServices
  - HostApplication：维护全局应用实例列表与上下文
  - HostApplicationContext：封装 UIControlledApplication/UIApplication/Application/文档集合
  - ITunaApplication/ITunaApplicationIdentity：应用接口与标识
- Commands
  - TunaCommand：命令基类，统一执行与可用性
  - ICommandContext/IDocumentContextProvider：命令上下文接口
  - CommandContext/DocumentContext：具体实现
  - CommandResult/CommandResultExtensions：结果对象与 helper

在实际项目中，你只需继承 TunaApplication 与 TunaCommand，按需使用上下文与结果，即可快速搭建插件框架。 
