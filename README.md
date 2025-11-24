# Tuna.Revit.Toolkit

![GitHub](https://img.shields.io/github/license/shichuyibushishiwu/Tuna.Revit.Extensions?label=License)
![GitHub](https://img.shields.io/badge/Shiwu-Tuna-green)

[English](README.en.md) | [简体中文](README.zh.md)

## English

### Overview

Tuna.Revit.Toolkit is a powerful extension package for the Autodesk Revit API, designed to simplify Revit add-in development and improve productivity. It provides practical utilities and extension methods that make working with the Revit API simpler and more intuitive.

### Features

- Simplifies common Revit API operations
- Rich extension methods
- Supports multiple Revit versions
- Easy integration into existing projects
- Actively maintained

### Documentation

Visit the official documentation for usage guides and API references:
[Official Docs](https://shichuyibushishiwu.github.io/)

### Supported Revit Versions

* Revit 2016
* Revit 2017
* Revit 2018
* Revit 2019
* Revit 2020
* Revit 2021
* Revit 2022
* Revit 2023
* Revit 2024
* Revit 2025
* Revit 2026

### NuGet Packages

| Package | Version | Downloads |
|--------|--------|--------|
| Tuna.Revit.Extensions | 25.0 | ![Nuget](https://img.shields.io/nuget/dt/Tuna.Revit.Extensions?style=flat&logo=nuget) |
| Tuna.Revit.Infrastructure | 25.0 | ![Nuget](https://img.shields.io/nuget/dt/Tuna.Revit.Infrastructure?style=flat&logo=nuget) |

### Quick Start

Below is a simple example demonstrating how to use Tuna.Revit.Toolkit:

```csharp
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Tuna.Revit.Extensions;

namespace MyRevitApp
{
    public class MyCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Document doc = uiapp.ActiveUIDocument.Document;

            // Use extension methods from Tuna.Revit.Extensions
            Wall wall = doc.GetElement("wall_id") as Wall;
            double length = wall.GetLength();

            return Result.Succeeded;
        }
    }
}
```

### Contributing

We welcome community contributions! If you'd like to contribute, please follow these steps:

1. **Fork the repository**
2. **Create a feature branch** - `git checkout -b feature/amazing-feature`
3. **Commit your changes** - `git commit -m 'Add an amazing feature'`
4. **Push to the branch** - `git push origin feature/amazing-feature`
5. **Open a Pull Request**

#### Code Style
- Follow C# coding conventions
- Add XML documentation comments to all public APIs

### License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

### Contact

- **GitHub Issues**: [Submit an issue](https://github.com/shichuyibushishiwu/Tuna.Revit.Toolkit/issues)
- **Email**: 1012201478@qq.com
- **WeChat**: ITuna

### Acknowledgments

Thanks to all contributors and users. Special thanks to:

- All code contributors
- Users who provide valuable feedback
- Autodesk Revit API community
- The open-source community for support and encouragement

---

## 简体中文

### 简介

Tuna.Revit.Toolkit 是一个为 Autodesk Revit API 开发的强大扩展包，旨在简化 Revit 二次开发过程，提高开发效率。通过提供一系列实用工具和扩展方法，使 Revit API 的使用变得更加简单和直观。

### 功能特点

- 简化常见 Revit API 操作
- 提供丰富的扩展方法
- 支持多个 Revit 版本
- 易于集成到现有项目中
- 持续更新和维护

### 文档

详细的使用文档和 API 参考，请访问我们的官方文档：
[官方文档](https://shichuyibushishiwu.github.io/)

### 支持的 Revit 版本

* Revit 2016
* Revit 2017
* Revit 2018
* Revit 2019
* Revit 2020
* Revit 2021
* Revit 2022
* Revit 2023
* Revit 2024
* Revit 2025
* Revit 2026

### NuGet 包列表

| 包名称 | 版本  | 下载量 |
|--------|--------|--------|
| Tuna.Revit.Extensions | 25.0 | ![Nuget](https://img.shields.io/nuget/dt/Tuna.Revit.Extensions?style=flat&logo=nuget) |
| Tuna.Revit.Infrastructure | 25.0 | ![Nuget](https://img.shields.io/nuget/dt/Tuna.Revit.Infrastructure?style=flat&logo=nuget) |

### 快速开始

以下是一个简单的示例，展示如何使用 Tuna.Revit.Toolkit：

```csharp
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Tuna.Revit.Extensions;

namespace MyRevitApp
{
    public class MyCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Document doc = uiapp.ActiveUIDocument.Document;

            // 使用 Tuna.Revit.Extensions 的扩展方法
            Wall wall = doc.GetElement("wall_id") as Wall;
            double length = wall.GetLength();

            // 更多操作...
            return Result.Succeeded;
        }
    }
}
```

### 贡献指南

我们热忱欢迎社区贡献！如果您想为项目做出贡献，请遵循以下步骤：

1. **Fork 本仓库**
2. **创建特性分支** - `git checkout -b feature/amazing-feature`
3. **提交您的更改** - `git commit -m '添加某个惊人的特性'`
4. **推送到分支** - `git push origin feature/amazing-feature`
5. **开启 Pull Request**

#### 代码规范
- 遵循 C# 编码规范
- 为所有公共 API 添加 XML 文档注释

### 许可证

本项目采用 MIT 许可证 - 详情请参阅 [LICENSE](LICENSE) 文件。

### 联系方式

- **GitHub Issues**: [提交问题](https://github.com/shichuyibushishiwu/Tuna.Revit.Toolkit/issues)
- **邮箱**: 1012201478@qq.com
- **微信公众号**: ITuna

### 致谢

衷心感谢所有为这个项目做出贡献的开发者和用户。特别鸣谢：

- 所有提交代码的贡献者
- 提供宝贵反馈的用户
- Autodesk Revit API 社区
- 开源社区的支持与鼓励

---

*Tuna.Revit.Toolkit - 让 Revit 开发更简单、更高效*

        

