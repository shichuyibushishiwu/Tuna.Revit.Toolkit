using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Extensions;
using Tuna.Runtime.Resources;

namespace Tuna.Revit.Infrastructure.ApplicationServices;

/// <summary>
/// <inheritdoc/>
/// </summary>
public abstract class TunaApplication : TunaApplicationBase, IExternalApplication, ITunaApplication
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IExternalEventService ExternalEventService { get; set; } = default!;

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public ITunaApplicationIdentity ApplicationIdentity { get; set; } = default!;

    /// <summary>
    /// 主体Revit应用程序
    /// </summary>
    public HostApplication Host { get; private set; } = default!;

    /// <inheritdoc/>
    public Result OnShutdown(UIControlledApplication application)
    {
        return Result.Succeeded;
    }

    /// <inheritdoc/>
    public Result OnStartup(UIControlledApplication application)
    {
        var applicationAssembly = GetType().Assembly;
        ExternalEventService = new ExternalEventService();
        ApplicationIdentity = new TunaApplicationIdentity(application.ActiveAddInId);
         
        Result result;
        try
        {
            Host = HostApplication.Instance;
            Host.ApplicationContext = new HostApplicationContext(application);
            Host.Applications.Add(this);

            ResourcesInjection.Initialize(applicationAssembly);
            InitailizeComponents();
            result = Result.Succeeded;
        }
        catch (Exception)
        {
            result = Result.Failed;
        }

        return result;
    }

    /// <summary>
    /// 初始化组件
    /// </summary>
    public abstract void InitailizeComponents();
}
