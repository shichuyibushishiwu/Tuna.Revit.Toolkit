# 11) Units（UnitExtension）

目标：处理 Revit 内部单位（通常是英尺）与常用工程单位（mm/cm/m）的互转，并提供基础的浮点比较工具。

## 内部单位与显示单位 / Internal vs display

Revit API 多数几何/长度参数返回的 `double` 是内部单位（英尺）。建议在：
- 读取后展示给用户：英尺 → mm/cm/m
- 写回参数前：mm/cm/m → 英尺

## 最常用互转 / Common conversions

```csharp
using Tuna.Revit.Extensions;

double lengthFeet = 10;
double lengthMm = lengthFeet.FeetToMillimeters();

double inputMm = 1200;
double inputFeet = inputMm.MillimetersToFeet();
```

## 近似相等 / AlmostEquals

```csharp
using Tuna.Revit.Extensions;

bool same = a.AlmostEquals(b, tolerance: 1e-6);
```
