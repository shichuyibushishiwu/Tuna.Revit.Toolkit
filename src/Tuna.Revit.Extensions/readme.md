# Tuna.Revit.Extensions

## 概述

Tuna.Revit.Extensions 提供针对 Autodesk Revit API 的高频扩展方法与辅助工具，覆盖 Document、Element、Selection、Geometry、Material、Ribbon 等常用领域，帮助你以更少的代码完成更多的工作。

## 功能亮点

- 常用对象的扩展方法（Document/Element/Selection/Geometry/Material）
- 视图与集合筛选器的便捷采集器（Collector 系列）
- Ribbon UI 构建辅助类，快速搭建插件菜单与图标
- 针对多版本 Revit 的条件编译与适配

## 兼容性

- 支持 Revit 2016–2026
- 支持 .NET Framework 4.5.2–4.8 与 .NET 8（Windows）

## 安装

- NuGet 包：`Tuna.Revit.Extensions`
- 在不同 Revit 版本的工程中引用相应目标框架即可，无需额外配置

## 快速上手

```csharp
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Tuna.Revit.Extensions;

namespace Samples
{
    /// <summary>
    /// 使用扩展方法的示例命令
    /// </summary>
    public class ExtensionsDemoCommand : IExternalCommand
    {
        /// <summary>
        /// 演示常用扩展方法的使用
        /// </summary>
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Document doc = uiapp.ActiveUIDocument.Document;

            // 示例：选择器与集合操作（具体方法请参考源码与 IntelliSense）
            // var walls = doc.Collector().OfClass(typeof(Wall)).ToElements();
            // var activeView = doc.ActiveView();
            // var bbox = activeView.GetBoundingBox();
            // var length = someWall.GetLength();

            return Result.Succeeded;
        }
    }
}
```

## 模块结构一览

- Extensions/Document：文档级扩展（当前视图、事务辅助等）
- Extensions/Element：图元扩展（名称、几何、参数访问等）
- Selection：选择与过滤器扩展（UI 选择、规则筛选）
- Geometry：几何计算、向量与临时几何（TransientElement）
- Material：材质、外观与颜色扩展
- Ribbon：Ribbon UI 构建与图标辅助
- Collection：采集器（CollectorInView、CollectorInList 等）

如需更完整的 API 与示例，请结合源码与 IntelliSense 查看具体方法签名与注释。 
