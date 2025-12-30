using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Runtime.Resources;

/// <summary>
/// 
/// </summary>
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
public class ApplicationSourceAttribute : Attribute
{
    /// <summary>
    /// 自定义应用程序资源路径
    /// </summary>
    /// <param name="path">资源路径</param>
    public ApplicationSourceAttribute(string path)
    {
        Path = path;
    }

    /// <summary>
    /// 资源路径
    /// </summary>
    public string Path { get; }
}
