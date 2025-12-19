using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Infrastructure.ApplicationServices;

/// <summary>
/// 
/// </summary>
public class HostApplication
{
    /// <summary>
    /// 
    /// </summary>
    public static HostApplication Instance { get; } = new HostApplication();

    private HostApplication()
    {
        Applications = new List<ITunaApplication>();
    }

    /// <summary>
    /// 
    /// </summary>
    public HostApplicationContext ApplicationContext { get; internal set; } = default!;

    /// <summary>
    /// 
    /// </summary>
    public List<ITunaApplication> Applications { get; }
}

