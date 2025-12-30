# Tuna.Revit.Application.Template

## 概述

此模块提供基于 Tuna.Revit.Toolkit 的 Revit 插件项目模板，帮助你快速创建具备基础框架与结构的工程。

## 安装模板

```bash
dotnet new -i Tuna.Revit.Application.Template
```

安装完成后可通过 `dotnet new --list` 查看模板短名称（通常为 `Tuna.Revit.Template`）。

## 创建新项目

```bash
dotnet new Tuna.Revit.Template -n MyRevitApp
```

或在 Visual Studio 中选择相应模板创建工程。

## 模板内容

- 预置项目结构与依赖
- 示例应用与命令入口
- 与 Tuna.Revit.Infrastructure/Tuna.Revit.Extensions 协同工作的基础代码骨架

如需个性化定制，可在生成项目后按需调整引用与初始化逻辑。 
