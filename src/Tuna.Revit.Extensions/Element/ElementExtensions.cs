/************************************************************************************
   Author:十五
   CretaeTime:2021/12/10 19:47:31
   Mail:1012201478@qq.com
   Github:https://github.com/shichuyibushishiwu

   Description:

************************************************************************************/



using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tuna.Revit.Extensions;

/// <summary>
/// Revit element extensions
/// </summary>
public static class ElementExtensions
{
    /// <summary>
    /// 根据参数的<see cref="Autodesk.Revit.DB.ElementId"/>获取图元的参数
    /// <para>Get element <see cref="Parameter"/> by <see cref="Autodesk.Revit.DB.ElementId"/></para>
    /// </summary>
    /// <param name="element">host element</param>
    /// <param name="parameterId">target parameter id</param>
    /// <returns>element <see cref="Parameter"/></returns>
    [DebuggerStepThrough]
    public static Parameter? GetParameter(this Element element, ElementId parameterId)
    {
        ArgumentNullExceptionUtils.ThrowIfNullOrInvalid(element);

        if (parameterId == ElementId.InvalidElementId)
        {
            return default;
        }

        if (element.Parameters.Size == 0)
        {
            return default;
        }

        return element.Parameters.ToList(p => p.Id == parameterId).FirstOrDefault();
    }

   

    /// <summary>
    /// 尝试去获取视图中与图元相交的对象
    /// <para>Try to get elements in the document which intersects with the primitive</para>
    /// </summary>
    /// <param name="element"></param>
    /// <param name="view"></param>
    /// <returns>图元所在的文档中与图元相交的对象</returns>
    /// <exception cref="System.ArgumentNullException"></exception>
    public static FilteredElementCollector TryGetIntersectElements(this Element element, View view)
    {
        ArgumentNullExceptionUtils.ThrowIfNullOrInvalid(element);
        ArgumentNullExceptionUtils.ThrowIfNullOrInvalid(view);

        Document document = element.Document;
        BoundingBoxXYZ boundingBox = element.get_BoundingBox(view);
        Outline outline = new Outline(boundingBox.Min, boundingBox.Max);
        FilteredElementCollector elements = document.GetElements(new BoundingBoxIntersectsFilter(outline));
        if (elements.GetElementCount() > 0)
        {
            elements = document.GetElementIntersectsInCollector(elements.ToElementIds(), element);
        }
        return elements;
    }
}
