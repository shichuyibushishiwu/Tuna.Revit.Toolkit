using System;
using System.IO;

namespace Tuna.Revit.Extensions;

/// <summary>
/// 应用程序上下文
/// </summary>
public class ResourceManager
{
    private const string DefaultIconPath = @"Assets\Icon";

    /// <summary>
    /// 
    /// </summary>
    public const string TunaRevitApplicationResourceIconPath = "TUNA_REVIT_APPLICATION_RESOURCE_ICON_PATH";

    private ResourceManager()
    {
        var configuredValue = AppDomain.CurrentDomain.GetData(TunaRevitApplicationResourceIconPath);
        if (configuredValue is string iconRelativePath && !string.IsNullOrWhiteSpace(iconRelativePath))
        {
            IconRelativePath = iconRelativePath;
            return;
        }

        IconRelativePath = DefaultIconPath;
    }

    /// <summary>
    /// 默认值
    /// </summary>
    public static ResourceManager Instance { get; } = new ResourceManager();

    /// <summary>
    /// 
    /// </summary>
    public string IconRelativePath { get; }

    /// <summary>
    /// 
    /// </summary>
    public string? IconRootPath { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="rootPath"></param>
    /// <returns></returns>
    /// <exception cref="System. ArgumentException"></exception>
    public string GetResourcePath(string? rootPath)
    {
        if (string.IsNullOrWhiteSpace(rootPath))
        {
            throw new ArgumentException("rootPath can not be null or whitespace.", nameof(rootPath));
        }


        return Path.Combine(rootPath, IconRelativePath);
    }
}
