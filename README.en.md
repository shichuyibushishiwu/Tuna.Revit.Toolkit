![GitHub](https://img.shields.io/github/license/shichuyibushishiwu/Tuna.Revit.Extensions?label=License)
![GitHub](https://img.shields.io/badge/Shiwu-Tuna-green)

[简体中文](README.zh.md) | English

# Tuna.Revit.Toolkit

## Overview

Tuna.Revit.Toolkit is a powerful extension package for the Autodesk Revit API, designed to simplify Revit add-in development and improve productivity. It provides practical utilities and extension methods that make working with the Revit API simpler and more intuitive.

## Features

- Simplifies common Revit API operations
- Rich extension methods
- Supports multiple Revit versions
- Easy integration into existing projects
- Actively maintained

## Documentation

Visit the official documentation for usage guides and API references:
[Official Docs](https://shichuyibushishiwu.github.io/)

## Supported Revit Versions

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

## NuGet Packages

| Package | Version | Downloads |
|--------|--------|--------|
| Tuna.Revit.Extensions | 25.0 | ![Nuget](https://img.shields.io/nuget/dt/Tuna.Revit.Extensions?style=flat&logo=nuget) |
| Tuna.Revit.Infrastructure | 25.0 | ![Nuget](https://img.shields.io/nuget/dt/Tuna.Revit.Infrastructure?style=flat&logo=nuget) |

## Quick Start

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

## Contributing

We welcome community contributions! If you'd like to contribute, please follow these steps:

1. **Fork the repository**
2. **Create a feature branch** - `git checkout -b feature/amazing-feature`
3. **Commit your changes** - `git commit -m 'Add an amazing feature'`
4. **Push to the branch** - `git push origin feature/amazing-feature`
5. **Open a Pull Request**

### Code Style
- Follow C# coding conventions
- Add XML documentation comments to all public APIs

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

- **GitHub Issues**: [Submit an issue](https://github.com/shichuyibushishiwu/Tuna.Revit.Toolkit/issues)
- **Email**: 1012201478@qq.com
- **WeChat**: ITuna

## Acknowledgments

Thanks to all contributors and users. Special thanks to:

- All code contributors
- Users who provide valuable feedback
- Autodesk Revit API community
- The open-source community for support and encouragement

---

Tuna.Revit.Toolkit — Make Revit development simpler and more efficient
