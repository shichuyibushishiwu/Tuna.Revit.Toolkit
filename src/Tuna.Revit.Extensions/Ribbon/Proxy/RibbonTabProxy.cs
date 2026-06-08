using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;

namespace Tuna.Revit.Extensions.Ribbon.Proxy;

internal class RibbonTabProxy : IRibbonTab
{
    private readonly List<RibbonPanelProxy> _items = new();

    public string Title { get; internal set; } = default!;

    public string AppPath { get; set; } = default!;

    public UIApplication Application { get; internal set; } = default!;

    public void AddDockablePanel()
    {
        throw new NotImplementedException();
    }

    public void AddMenuItem()
    {
        throw new NotImplementedException();
    }

    public IRibbonPanel AddRibbonPanel(string name, Action<IRibbonPanel>? handle = null)
    {
        RibbonPanelProxy ribbonPanelProxy = new()
        {
            Parent = this,
            Title = name,
            RevitRibbonObject = Application.CreateRibbonPanel(Title, name)
        };

        _items.Add(ribbonPanelProxy);

        handle?.Invoke(ribbonPanelProxy);

        return ribbonPanelProxy;
    }

    public IEnumerable<IRibbonItem> GetItems() => _items;

    public List<RibbonPanel> GetRibbonPanels()
    {
        return Application.GetRibbonPanels(this.Title);
    }
}
