/************************************************************************************
   Author:十五
   CretaeTime:2022/4/20 13:16:40
   Mail:1012201478@qq.com
   Github:https://github.com/shichuyibushishiwu

   Description:

************************************************************************************/


using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Documents;
using Tuna.Revit.Extensions.Ribbon.Proxy;


namespace Tuna.Revit.Extensions;

/// <summary>
/// Revit ribbon ui extensions
/// </summary>
public static class RibbonExtensions
{
    /// <summary>
    /// 在面板上创建一个下拉按钮
    /// </summary>
    /// <param name="panel">要添加按钮的面板</param>
    /// <param name="name"></param>
    /// <param name="text"></param>
    /// <param name="handle"></param>
    /// <returns></returns>
    public static PulldownButton CreatePulldownButton(this RibbonPanel panel, string name, string text, Action<PulldownButtonData>? handle = null)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(panel);
        PulldownButtonData data = new PulldownButtonData(name, text);
        handle?.Invoke(data);
        return (PulldownButton)panel.AddItem(data);
    }

    /// <summary>
    /// 在面板上创建一个下拉式按钮
    /// </summary>
    /// <param name="panel"></param>
    /// <param name="name"></param>
    /// <param name="text"></param>
    /// <param name="handle"></param>
    /// <returns></returns>
    public static SplitButton CreateSplitButton(this RibbonPanel panel, string name, string text, Action<SplitButtonData>? handle = null)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(panel);
        SplitButtonData data = new SplitButtonData(name, text);
        handle?.Invoke(data);
        return (SplitButton)panel.AddItem(data);
    }

    /// <summary>
    /// 在面板上创建一个下拉框
    /// </summary>
    /// <param name="panel"></param>
    /// <param name="name"></param>
    /// <param name="handle"></param>
    /// <returns></returns>
    public static ComboBox CreateComboBox(this RibbonPanel panel, string name, Action<ComboBoxData>? handle = null)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(panel);
        ComboBoxData combo = new ComboBoxData(name);
        handle?.Invoke(combo);
        return (ComboBox)panel.AddItem(combo);
    }

    internal static PushButtonData CreatePushButtonData(Type type, Action<PushButtonData>? handle = null)
    {
        return RibbonButtonDescriptor.Setup(type, handle).PushButtonData;
    }

    /// <summary>
    /// 在面板上创建一个按钮
    /// <para>Create a ribbon push button on the panel</para>
    /// </summary>
    /// <typeparam name="T">外部命令，必须是一个自定义类型，且继承于<see cref="Autodesk.Revit.UI.IExternalCommand"/>,且必须存在一个无参的构造函数</typeparam>
    /// <param name="panel">要添加按钮的面板</param>
    /// <param name="handle">对按钮的参数进行赋值</param>
    /// <returns>创建的按钮</returns>
    public static PushButton CreatePushButton<T>(this RibbonPanel panel, Action<PushButtonData>? handle = null) where T : class, IExternalCommand, new()
    {
        ArgumentNullExceptionUtils.ThrowIfNull(panel);
        return (PushButton)panel.AddItem(CreatePushButtonData(typeof(T), handle));
    }

    public static IList<RibbonItem> CreatePushButton<T1, T2>(this RibbonPanel panel, Action<PushButtonData>? handle1 = null, Action<PushButtonData>? handle2 = null)
        where T1 : class, IExternalCommand, new()
        where T2 : class, IExternalCommand, new()
    {
        ArgumentNullExceptionUtils.ThrowIfNull(panel);
        PushButtonData buttonT1 = CreatePushButtonData(typeof(T1), handle1);
        PushButtonData buttonT2 = CreatePushButtonData(typeof(T2), handle2);
        return panel.AddStackedItems(buttonT1, buttonT2);
    }

    public static IList<RibbonItem> CreatePushButton<T1, T2, T3>(this RibbonPanel panel, Action<PushButtonData>? handle1 = null, Action<PushButtonData>? handle2 = null, Action<PushButtonData>? handle3 = null)
    where T1 : class, IExternalCommand, new()
    where T2 : class, IExternalCommand, new()
    where T3 : class, IExternalCommand, new()
    {
        ArgumentNullExceptionUtils.ThrowIfNull(panel);
        PushButtonData buttonT1 = CreatePushButtonData(typeof(T1), handle1);
        PushButtonData buttonT2 = CreatePushButtonData(typeof(T2), handle2);
        PushButtonData buttonT3 = CreatePushButtonData(typeof(T3), handle3);
        return panel.AddStackedItems(buttonT1, buttonT2, buttonT3);
    }


    /// <summary>
    /// 创建按压式按钮
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="pulldownButton">下拉按钮</param>
    /// <param name="handle"></param>
    /// <returns></returns>
    public static PushButton CreatePushButton<T>(this PulldownButton pulldownButton, Action<PushButtonData>? handle = null) where T : class, IExternalCommand, new()
    {
        ArgumentNullExceptionUtils.ThrowIfNull(pulldownButton);
        return pulldownButton.AddPushButton(CreatePushButtonData(typeof(T), handle));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="splitButton"></param>
    /// <param name="handle"></param>
    /// <returns></returns>
    public static PushButton CreatePushButton<T>(this SplitButton splitButton, Action<PushButtonData>? handle = null) where T : class, IExternalCommand, new()
    {
        ArgumentNullExceptionUtils.ThrowIfNull(splitButton);
        return splitButton.AddPushButton(CreatePushButtonData(typeof(T), handle));
    }
}
