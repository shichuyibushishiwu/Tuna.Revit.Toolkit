using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Extensions.Ribbon.Proxy;

internal class RibbonPanelProxy : RibbonElementProxy<RibbonPanel>, IRibbonPanel
{
    private readonly List<IRibbonItem> _items = new();

    public RibbonTabProxy Parent { get; internal set; }

    public RibbonItemType Type => RibbonItemType.RibbonPanel;

    public string Name => Title;

    public void AddSlideOut() => RevitRibbonObject.AddSlideOut();

    public IRibbonPanel AddSeparator()
    {
        RevitRibbonObject.AddSeparator();
        return this;
    }

    public IRibbonPanel AddPushButton<TCommand>(Action<RibbonButtonData>? handle = null) where TCommand : class, IExternalCommand, new()
    {
        Type commandType = typeof(TCommand);
        if (!_items.Any(item => item.Name == $"btn_{commandType}"))
        {
            RibbonButtonProxy ribbonButtonProxy = new RibbonButtonProxy();
            ribbonButtonProxy.Configurate(handle);

            RibbonButtonDescriptor descriptor = RibbonButtonDescriptor.Setup(commandType, revitButton =>
            {
                if (handle != null)
                {
                    RibbonButtonData.MapTo(ribbonButtonProxy.RibbonButtonData, revitButton);
                }
            });


            var ribbonButton = (PushButton)this.RevitRibbonObject.AddItem(descriptor.PushButtonData);

            ribbonButtonProxy.RevitRibbonObject = ribbonButton;
            ribbonButtonProxy.Title = ribbonButton.ItemText;
            ribbonButtonProxy.Name = ribbonButton.Name;

            _items.Add(ribbonButtonProxy);
        }
        return this;
    }

    public IRibbonPanel AddPulldownButton(string title, Action<IRibbonPulldownButton>? handle = null)
    {
        RibbonPulldownButtonProxy pulldownButtonProxy = new RibbonPulldownButtonProxy();
        handle?.Invoke(pulldownButtonProxy);

        PulldownButton pulldownButton = this.RevitRibbonObject.CreatePulldownButton(title, title, btn => RibbonButtonData.MapTo(pulldownButtonProxy.RibbonButtonData, btn));

        pulldownButtonProxy.RevitRibbonObject = pulldownButton;
        pulldownButtonProxy.InitializeComponent();

        _items.Add(pulldownButtonProxy);

        return this;
    }

    public IRibbonPanel AddSplitButton(string title, Action<IRibbonSplitButton>? handle = null)
    {
        SplitButton splitButton = this.RevitRibbonObject.CreateSplitButton(title, title);
      
        RibbonSplitButtonProxy splitButtonProxy = new()
        {
            RevitRibbonObject = splitButton,
            Name = splitButton.Name
        };

        handle?.Invoke(splitButtonProxy);

        _items.Add(splitButtonProxy);

        return this;
    }

    public IRibbonPanel AddComboBox(string name, Action<IRibbonComboBox>? handle = null)
    {
        ComboBox comboBox = this.RevitRibbonObject.CreateComboBox(name);

        RibbonComboBoxProxy comboBoxProxy = new(comboBox)
        {
            Title = comboBox.Name,
        };

        handle?.Invoke(comboBoxProxy);

        _items.Add(comboBoxProxy);

        return this;
    }

    public IRibbonPanel AddRadioButtonGroup()
    {
        return this;
    }

    public IRibbonPanel AddTextBox()
    {
        return this;
    }

    public IEnumerable<IRibbonItem> GetItems() => _items;
}
