# Example: Element Query

## User asks

How do I query walls in the current document using Tuna.Revit.Extensions?

## Assistant should answer

- Use `using Tuna.Revit.Extensions;`
- Prefer `document.GetElements<Wall>()` for typed results
- Use `document.GetElements(typeof(Wall))` when you want a `FilteredElementCollector` to chain more filters

```csharp
using Autodesk.Revit.DB;
using Tuna.Revit.Extensions;

IEnumerable<Wall> walls = document.GetElements<Wall>();
```
