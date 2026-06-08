using Autodesk.Revit.UI;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Tuna.Revit.Extensions.Ribbon.Proxy;
using static UIFramework.WorksharingNotificationWindow;

namespace Tuna.Revit.Extensions;

/// <summary>
/// 对UI的扩展
/// </summary>
public static class UIApplicationExtensions
{
    /// <summary>
    /// internal method info of <see cref="UIControlledApplication"/>
    /// </summary>
    private static readonly MethodInfo? _getUIApplicationMethod = (typeof(UIControlledApplication).GetMethod("getUIApplication", BindingFlags.Instance | BindingFlags.NonPublic));

    /// <summary>
    /// get the <see cref="Autodesk.Revit.UI.UIApplication" /> from <see cref="UIControlledApplication"/>
    /// </summary>
    /// <param name="application"></param>
    /// <returns></returns>
    /// <exception cref="System.ArgumentNullException"></exception>
    public static UIApplication GetUIApplication(this UIControlledApplication application)
    {
        return _getUIApplicationMethod!.Invoke(application, new object[0]) as UIApplication ?? throw new ArgumentNullException("app reflection error");
    }

    internal static IRibbonTab InternalAddRibbonTab(this UIApplication application, string title, Action<IRibbonTab>? action = null)
    {
        application.CreateRibbonTab(title);

        IRibbonTab ribbonTab = new RibbonTabProxy()
        {
            Application = application,
            Title = title,
        };
        action?.Invoke(ribbonTab);

        return ribbonTab;
    }

    /// <summary>
    /// 创建Tab
    /// </summary>
    /// <param name="application"></param>
    /// <param name="title"></param>
    /// <param name="action"></param>
    public static IRibbonTab AddRibbonTab(this UIApplication application, string title, Action<IRibbonTab>? action = null)
    {
        Assembly assembly = Assembly.GetCallingAssembly();
        ResourceManager.Instance.IconRootPath = System.IO.Directory.GetParent(assembly.Location)!.FullName;

        return application.InternalAddRibbonTab(title, action);
    }

    /// <summary>
    /// 创建Tab
    /// </summary>
    /// <param name="application"></param>
    /// <param name="title"></param>
    /// <param name="action"></param>
    /// <exception cref="System.ArgumentNullException"></exception>
    public static IRibbonTab AddRibbonTab(this UIControlledApplication application, string title, Action<IRibbonTab>? action = null)
    {
        Assembly assembly = Assembly.GetCallingAssembly();
        ResourceManager.Instance.IconRootPath = System.IO.Directory.GetParent(assembly.Location)!.FullName;

        return application.GetUIApplication().InternalAddRibbonTab(title);
    }
}
