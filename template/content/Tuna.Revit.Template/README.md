# Tuna Revit Application 模板

欢迎使用 Tuna Revit Application 模板，这是一个用于快速创建 Revit 插件（Application 类型）的项目模板，内置向导可一键选择支持的 Revit 版本，开箱即用的 Ribbon UI 与示例命令，并自动完成调试环境与构建后部署拷贝配置。

## 主要功能
- 基于 Tuna.Revit.Toolkit 的标准化工程骨架，含 Application 启动类与命令示例
- 基于 Tuna.Revit.Extensions 的 API 扩展
- 自动创建 Ribbon 标签页与面板，内置示例按钮 “Tuna Hello World”
- 支持 Revit 2016–2026 多版本选择与对应调试启动程序配置
- 构建后自动拷贝 .addin 与输出文件到 Revit Addins 目录，便于快速调试
- 内置 WPF 窗口与简单的 MVVM 示例
- 支持 WPF 设计时和运行时的顶级根节点 AppResource.xaml

## 快速开始
- Visual Studio
  - 新建项目，搜索 “Tuna Revit Application”
  - 按向导选择支持的 Revit 版本与应用名称
- 命令行（如果已安装 dotnet 模板）
  - `dotnet new tuna-revit-app -n YourAppName --rvt21 true --rvt22 true --rvt23 true`
  - 可通过参数启用不同 Revit 版本支持

## 运行与调试
- 选择对应配置（如 Rvt_23_Debug），模板已设置启动程序为对应版本的 Revit.exe
- Debug 构建后，模板自动拷贝：
  - `.addin` 文件到 `C:\ProgramData\Autodesk\Revit\{RevitVersion}\`
  - 输出目录到 `C:\ProgramData\Autodesk\Revit\Addins\{RevitVersion}\{AppName}\`
- 在 Revit 中可见 “Tuna” 标签页 → “Commands” 面板 → “Tuna Hello World” 按钮
- Clean 将清理上述拷贝的目录与 .addin 文件

## 目录结构
- App.cs：应用入口，注册 Ribbon 与命令按钮（参考 [App.cs](App.cs)）
- Commands/Command.cs：示例命令，打开 WPF 窗口（参考 [Command.cs](./Commands/Command.cs)）
- Views/MainWindow.xaml(.cs)：示例窗口（参考 [MainWindow.xaml](./Views/MainWindow.xaml)）
- ViewModels/MainWindowViewModel.cs：示例 ViewModel（参考 [MainWindowViewModel.cs](./ViewModels/MainWindowViewModel.cs)）
- Tuna.Revit.Template.addin：Revit 插件声明（参考 [.addin](./Tuna.Revit.Template.addin)）
- Assets/Icon/*.png：示例图标（可替换为自定义图标）


## 依赖与目标平台
- 依赖 NuGet：
  - Tuna.Revit.Extensions（版本号随 Revit 版本前缀与 TunaVersion）
  - Tuna.Revit.Infrastructure
- 目标框架：
  - Revit 2016–2024：.NET Framework（net452 / net46 / net47 / net48）
  - Revit 2025–2026：.NET 8（net8.0-windows）

## 示例功能说明
- 启动类在初始化时创建 “Tuna” 标签页与 “Commands” 面板，并注册一个按钮
- 点击按钮后弹出 WPF 窗口，窗口通过 ViewModel 绑定显示 “Hello World!!!”
- 相关代码参考：[App.cs](file:///d:/Work/GitHub/Shiwu/Tuna.Revit.Toolkit/template/content/Tuna.Revit.Template/App.cs)、[Command.cs](file:///d:/Work/GitHub/Shiwu/Tuna.Revit.Toolkit/template/content/Tuna.Revit.Template/Commands/Command.cs)

## 关于
- 作者：Shiwu（ID：Shichuyibushishiwu）
- 官网：shichuyibushishiwu.top
- 项目定位：面向 Revit 开发者的轻量级入门与工程化模板

## 联系
- Email: 1012201478@qq.com
- WeChat ID: Tuna_ds
- BiliBili: [十五当只咸鱼](https://space.bilibili.com/14252097)