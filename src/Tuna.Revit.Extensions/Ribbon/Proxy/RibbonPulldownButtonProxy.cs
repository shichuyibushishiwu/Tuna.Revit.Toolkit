using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Data;

namespace Tuna.Revit.Extensions.Ribbon.Proxy;

internal class RibbonPulldownButtonProxy : RibbonElementProxy<PulldownButton>, IRibbonPulldownButton
{
    private readonly List<IRibbonItem> _items = new();
    private readonly List<Tuple<RibbonItemType, RibbonButtonDescriptor?>> _components = new();

    public RibbonPulldownButtonProxy()
    {
        RibbonButtonData = new RibbonButtonData();
    }

    public RibbonItemType Type => RibbonItemType.PulldownButton;

    public string Name => Title;

    public IRibbonPulldownButton AddPushButton<TCommand>(Action<RibbonButtonData>? handle = null) where TCommand : class, IExternalCommand, new()
    {
        RibbonButtonDescriptor descriptor = RibbonButtonDescriptor.Setup(typeof(TCommand), revitButton =>
        {
            if (handle != null)
            {
                //RibbonButtonData.MapTo(RibbonButtonData, revitButton);
            }
        });

        _components.Add(new(RibbonItemType.PushButton, descriptor));
        return this;
    }

    public IRibbonPulldownButton AddSeparator()
    {
        _components.Add(new(RibbonItemType.Separator, null));
        return this;
    }

    public IEnumerable<IRibbonItem> GetItems() => _items;

    public void Configurate(Action<RibbonButtonData> config)
    {
        RibbonButtonData.Title = Title;
        config.Invoke(RibbonButtonData);
    }

    public RibbonButtonData RibbonButtonData { get; set; }


    public void InitializeComponent()
    {
        foreach (var item in _components)
        {
            switch (item.Item1)
            {
                case RibbonItemType.PushButton:
                    RibbonButtonDescriptor? descriptor = item.Item2;
                    RibbonButtonProxy ribbonButtonProxy = new();

                    RibbonButton ribbonButton = this.RevitRibbonObject.AddPushButton(descriptor.PushButtonData);

                    ribbonButtonProxy.RevitRibbonObject = ribbonButton;
                    ribbonButtonProxy.Title = ribbonButton.Name;
                    ribbonButtonProxy.Name = ribbonButton.Name;

                    _items.Add(ribbonButtonProxy);
                    break;
                case RibbonItemType.Separator:
                    this.RevitRibbonObject.AddSeparator();
                    break;
            }
        }
    }
}
