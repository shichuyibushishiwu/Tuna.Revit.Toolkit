# Tuna.Runtime

## 概述

Tuna.Runtime 提供运行时支持，主要面向 WPF 资源的集中注入与管理，帮助在 Revit 插件中统一使用样式、控件模板与资源字典。

## 功能亮点

- ResourcesInjection：从指定程序集加载并注入 `AppResources.xaml`
- ApplicationSource：提供全局 `ResourceDictionary`，作为统一资源入口
- ApplicationSourceAttribute：可在程序集级配置资源路径
- 自动窗口级注入：在窗口与其可视树加载时自动合并资源

## 使用方式

### 1. 准备资源文件

- 在你的 UI 程序集内添加 WPF 资源字典，例如 `AppResources.xaml`（Build Action 设为 Resource）

### 2. 可选：通过属性指定资源路径

```csharp
using Tuna.Runtime.Resources;

// 在你的 UI 程序集 AssemblyInfo.cs 或任意文件的程序集级位置添加
[assembly: ApplicationSource("AppResources.xaml")]
```

### 3. 在应用启动时注入资源

```csharp
using System.Reflection;
using Tuna.Runtime.Resources;
using Tuna.Revit.Infrastructure.ApplicationServices;

namespace Samples
{
    /// <summary>
    /// 示例应用：在启动时注入资源
    /// </summary>
    public class SampleApplication : TunaApplication
    {
        /// <summary>
        /// 应用组件初始化
        /// </summary>
        public override void InitailizeComponents()
        {
            // 假设资源位于当前应用程序集
            var assembly = GetType().Assembly;
            ResourcesInjection.Initialize(assembly);
        }
    }
}
```

## 适用场景

- 插件中统一管理样式与控件模板
- 跨窗口共享资源字典，无需手动合并
- 与 Tuna.Revit.Infrastructure 协同，在应用生命周期中完成资源注入 
