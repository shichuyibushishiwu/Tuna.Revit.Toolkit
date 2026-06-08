
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Extensions.Ribbon.Proxy;

internal class RibbonButtonDescriptor
{
    public Type CommandType { get; private set; } = default!;

    public IRibbonButtonData? RibbonButtonData { get; private set; }

    public PushButtonData PushButtonData { get; private set; } = default!;

    public static RibbonButtonDescriptor Setup(Type commandType, Action<PushButtonData>? handle = null)
    {
        string commandName = commandType.Name;
        string buttonName = $"tuna_btn_{commandName}";
        string assembly = commandType.Assembly.Location;
        string commandFullName = commandType.FullName!;

        PushButtonData pushButtonData = new PushButtonData(buttonName, commandName, assembly, commandFullName);
        if (typeof(IExternalCommandAvailability).IsAssignableFrom(commandType))
        {
            pushButtonData.AvailabilityClassName = commandFullName;
        }

        //方式三，通过属性进行配置，优先级第三
        IRibbonButtonData? ribbonButtonData = commandType.GetCustomAttribute<CommandButtonAttribute>();
        if (ribbonButtonData != null)
        {
            Extensions.RibbonButtonData.MapTo(ribbonButtonData, pushButtonData);
        }

        //方式二，通过接口进行配置，优先级第二
        if (typeof(IRibbonButtonData).IsAssignableFrom(commandType))
        {
            ribbonButtonData = Activator.CreateInstance(commandType) as IRibbonButtonData;
            Extensions.RibbonButtonData.MapTo(ribbonButtonData!, pushButtonData);
        }

        //方式一，通过回调函数进行配置，优先级第一
        handle?.Invoke(pushButtonData);

        return new RibbonButtonDescriptor()
        {
            PushButtonData = pushButtonData,
            RibbonButtonData = ribbonButtonData,
            CommandType = commandType
        };
    }
}
