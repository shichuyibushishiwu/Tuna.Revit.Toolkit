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
    /// internal method info of <see cref="UIControlledApplication"/>
    /// </summary>
    private static readonly MethodInfo _getUIApplicationMethod = typeof(UIControlledApplication).GetMethod("getUIApplication", BindingFlags.Instance | BindingFlags.NonPublic)!;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="uiControlledApplication"></param>
    public HostApplicationContext(UIControlledApplication uiControlledApplication)
    {
        UIControlledApplication = uiControlledApplication;
        UIApplication = GetUIApplication(uiControlledApplication);
        Application = UIApplication.Application;
        ControlledApplication = UIControlledApplication.ControlledApplication;

        Documents = new DocumentCollection(Application);
    }

    /// <summary>
    /// 
    /// </summary>
    public UIControlledApplication UIControlledApplication { get; }

    /// <summary>
    /// 
    /// </summary>
    public ControlledApplication ControlledApplication { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public UIApplication UIApplication { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Application Application { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DocumentCollection Documents { get; set; }


    /// <summary>
    /// get the <see cref="Autodesk.Revit.UI.UIApplication" /> from <see cref="UIControlledApplication"/>
    /// </summary>
    /// <param name="application"></param>
    /// <returns></returns>
    /// <exception cref="System.ArgumentNullException"></exception>
    private static UIApplication GetUIApplication(UIControlledApplication application)
    {
        return _getUIApplicationMethod.Invoke(application, []) as UIApplication ?? throw new ArgumentNullException("app reflection error");
    }
}
