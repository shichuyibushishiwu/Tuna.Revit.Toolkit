using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Infrastructure.ApplicationServices;

/// <summary>
/// 应用程序上下文
/// </summary>
public class HostApplicationContext
{
    /// <summary>
    ///Internal method info of <see cref="Autodesk.Revit.UI.UIControlledApplication"/>
    /// </summary>
    private static readonly MethodInfo _getUIApplicationMethod = typeof(UIControlledApplication).GetMethod("getUIApplication", BindingFlags.Instance | BindingFlags.NonPublic)!;

    /// <summary>
    /// 初始化 <see cref="HostApplicationContext"/> 类的新实例
    /// </summary>
    /// <param name="uiControlledApplication">UI 受控应用程序</param>
    public HostApplicationContext(UIControlledApplication uiControlledApplication)
    {
        UIControlledApplication = uiControlledApplication;
        UIApplication = GetUIApplication(uiControlledApplication);
        Application = UIApplication.Application;
        ControlledApplication = UIControlledApplication.ControlledApplication;

        Documents = new DocumentCollection(Application);
    }

    /// <summary>
    /// 获取 UI 受控应用程序 <see cref="Autodesk.Revit.UI.UIControlledApplication"/> 
    /// </summary>
    public UIControlledApplication UIControlledApplication { get; }

    /// <summary>
    /// 获取受控应用程序 <see cref="Autodesk.Revit.ApplicationServices.ControlledApplication"/> 
    /// </summary>
    public ControlledApplication ControlledApplication { get;}

    /// <summary>
    /// 获取 UI 应用程序 <see cref="Autodesk.Revit.UI.UIApplication"/> 
    /// </summary>
    public UIApplication UIApplication { get; }

    /// <summary>
    /// 获取应用程序 <see cref="Application"/> 
    /// </summary>
    public Application Application { get; }

    /// <summary>
    /// 获取文档集合
    /// </summary>
    public DocumentCollection Documents { get;}

    /// <summary>
    /// 从 <see cref="UIControlledApplication"/> 获取 <see cref="Autodesk.Revit.UI.UIApplication" />
    /// </summary>
    /// <param name="application">受控应用程序</param>
    /// <returns>UI 应用程序</returns>
    /// <exception cref="System.ArgumentNullException">当反射获取失败时抛出</exception>
    private static UIApplication GetUIApplication(UIControlledApplication application)
    {
        return _getUIApplicationMethod.Invoke(application, []) as UIApplication ?? throw new ArgumentNullException("app reflection error");
    }
}
