using System;
using System.Windows;

namespace Tuna.Runtime.Resources;

/// <summary>
/// 模拟 WPF 应用程序的根元素，用于存储全局资源
/// </summary>
public class ApplicationSource
{
    private static readonly Lazy<ApplicationSource> _lazy = new Lazy<ApplicationSource>(() => new ApplicationSource());

    private ApplicationSource() { }

    /// <summary>
    /// 获取当前应用程序源实例
    /// </summary>
    public static ApplicationSource Current => _lazy.Value;

    /// <summary>
    /// 获取全局资源字典
    /// </summary>
    public ResourceDictionary Resources { get; } = new ResourceDictionary();
}
