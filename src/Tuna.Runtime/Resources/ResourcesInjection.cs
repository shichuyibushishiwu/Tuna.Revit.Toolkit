using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Media;

namespace Tuna.Runtime.Resources;

/// <summary>
/// 资源注入类
/// </summary>
public class ResourcesInjection
{
    /// <summary>
    /// 是否已启用窗口级自动资源注入
    /// </summary>
    private static bool _autoInjectionEnabled;

    /// <summary>
    /// 初始化 ApplicationSource，加载指定程序集中的 AppResources.xaml
    /// </summary>
    /// <param name="assembly">包含 AppResources.xaml 的程序集</param>
    public static void Initialize(Assembly assembly)
    {
        if (assembly == null)
        {
            throw new ArgumentNullException(nameof(assembly));
        }

        Uri uri = GetResourceUri(assembly);
        //TODO 检测uri 是否存在

        LoadAndMergeResource(ApplicationSource.Current.Resources, uri);
        EnableAutoInjectionForWindows();
    }

    /// <summary>
    /// 获取资源的 Pack URI
    /// </summary>
    /// <param name="assembly">程序集</param>
    /// <returns>资源 URI</returns>
    private static Uri GetResourceUri(Assembly assembly)
    {
        var assemblyName = assembly.GetName().Name;

        // 假设资源文件名为 AppResources.xaml 且位于根目录
        return new Uri($"pack://application:,,,/{assemblyName};component/AppResources.xaml", UriKind.Absolute);
    }

    private static void LoadAndMergeResource(ResourceDictionary targetDictionary, Uri uri)
    {
        if (targetDictionary.MergedDictionaries.Any(d => d.Source == uri))
        {
            return;
        }

        var resourceDictionary = new ResourceDictionary
        {
            Source = uri
        };
        targetDictionary.MergedDictionaries.Add(resourceDictionary);
    }

    private static void EnableAutoInjectionForWindows()
    {
        if (_autoInjectionEnabled)
        {
            return;
        }

        EventManager.RegisterClassHandler(
            typeof(Window),
            FrameworkElement.LoadedEvent,
            new RoutedEventHandler(OnWindowLoaded));

        _autoInjectionEnabled = true;
    }

  

    /// <summary>
    /// 树级注入
    /// </summary>
    /// <param name="root"></param>
    private static void AttachHandlersRecursively(FrameworkElement root)
    {
        SetupElementInjection(root);

        int count = VisualTreeHelper.GetChildrenCount(root);
        for (int i = 0; i < count; i++)
        {
            if (VisualTreeHelper.GetChild(root, i) is FrameworkElement child)
            {
                AttachHandlersRecursively(child);
            }
        }
    }

    private static void SetupElementInjection(FrameworkElement element)
    {
        InjectIntoElement(element);

        // 订阅自身 Loaded，保证动态加入的元素也可注入
        //element.Loaded -= OnFrameworkElementLoaded;
        //element.Loaded += OnFrameworkElementLoaded;

        //// Frame 的实例级 CLR 事件订阅
        //if (element is Frame frame)
        //{
        //    frame.Navigated -= OnFrameNavigated;
        //    frame.Navigated += OnFrameNavigated;

        //    frame.LoadCompleted -= OnFrameLoadCompleted;
        //    frame.LoadCompleted += OnFrameLoadCompleted;

        //    if (frame.Content is FrameworkElement contentElement)
        //    {
        //        InjectIntoElement(contentElement);
        //    }
        //}
    }

    private static void InjectIntoElement(FrameworkElement element)
    {
        var appResources = ApplicationSource.Current.Resources;

        if (!element.Resources.MergedDictionaries.Contains(appResources))
        {
            element.Resources.MergedDictionaries.Add(appResources);
        }
    }

    private static void OnFrameworkElementLoaded(object sender, RoutedEventArgs e)
    {
        if (sender is FrameworkElement element)
        {
            InjectIntoElement(element);
        }
    }

    private static void OnWindowLoaded(object sender, RoutedEventArgs e)
    {
        if (sender is FrameworkElement element)
        {
            AttachHandlersRecursively(element);
        }
    }

    private static void OnFrameNavigated(object sender, NavigationEventArgs e)
    {
        if (e.Content is FrameworkElement element)
        {
            InjectIntoElement(element);
        }
    }

    private static void OnFrameLoadCompleted(object sender, NavigationEventArgs e)
    {
        if (e.Content is FrameworkElement element)
        {
            InjectIntoElement(element);
        }
    }
}
