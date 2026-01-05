/************************************************************************************
   Author:十五
   CretaeTime:2021/11/19 21:41:53
   Mail:1012201478@qq.com
   Github:https://github.com/shichuyibushishiwu

   Description:

************************************************************************************/

using Autodesk.Revit.DB;

#if Rvt_16|| Rvt_17
using Autodesk.Revit.Utility;
#else
using Autodesk.Revit.DB.Visual;
#endif

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Extensions;

/// <summary>
/// revit document extension
/// </summary>
public static class DocumentExtensions
{
    /// <summary>
    /// Is check element exist
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="document">The <see cref="Autodesk.Revit.DB.Document"/>.</param>
    /// <param name="predicate"></param>
    /// <returns></returns>
    public static bool ElementExist<T>(this Document document, Func<T, bool> predicate) where T : Element
    {
        return document.GetElements<T>().Any(predicate);
    }

    /// <summary>
    /// 通过 <see cref="Autodesk.Revit.DB.ElementId"/> 获取图元
    /// <para>Get element by <see cref="Autodesk.Revit.DB.ElementId"/></para>
    /// </summary>
    /// <typeparam name="TElement"></typeparam>
    /// <param name="document"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static TElement GetElement<TElement>(this Document document, ElementId id) where TElement : Element
    {
        return document.GetElement(id) as TElement ?? throw new Exception($"target can not be convert to {typeof(TElement)}");
    }

    /// <summary>
    /// Get revit unique element name
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="document"></param>
    /// <param name="basicName"></param>
    /// <returns></returns>
    public static string GetUniqueName<T>(this Document document, string basicName) where T : Element
    {
        int number = 0;
        string name = basicName;
        while (document.ElementExist<T>(e => string.Equals(e.Name, name, StringComparison.OrdinalIgnoreCase)))
        {
            number++;
            name = $"{basicName}({number})";
        }
        return name;
    }

    /// <summary>
    /// Get parameter filter element
    /// </summary>
    /// <param name="document">The <see cref="Autodesk.Revit.DB.Document"/>.</param>
    /// <param name="name"></param>
    /// <param name="ids"></param>
    /// <param name="filterRule"></param>
    /// <returns></returns>
    public static ParameterFilterElement CreateParameterFilterElement(this Document document, string name, ICollection<ElementId> ids, FilterRule filterRule)
    {
#if Rvt_16 || Rvt_17 || Rvt_18
        return ParameterFilterElement.Create(document, name, ids, new List<FilterRule>() { filterRule });

#else
        ElementParameterFilter elementParameterFilter = new ElementParameterFilter(filterRule);
        return ParameterFilterElement.Create(document, name, ids, elementParameterFilter);
#endif
    }




    /// <summary>
    /// 获取类型为 <typeparamref name="T"/> 的图元类型和实例的数量
    /// <para>Get element instances count in the document</para>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="document">要查询的文档</param>
    /// <returns></returns>
    public static IDictionary<ElementType, int> GetElementTypesAndInstancesCount<T>(this Document document) where T : HostObject
    {
        ArgumentNullExceptionUtils.ThrowIfNullOrInvalid(document);
        Dictionary<ElementId, int> amount = new Dictionary<ElementId, int>();
        var elements = document.GetElements<T>();
        foreach (var element in elements)
        {
            ElementId id = element.GetTypeId();

            if (amount.TryGetValue(id, out int count))
            {
                amount[id] = count + 1;
                continue;
            }
            amount.Add(id, 1);
        }

        return amount.ToDictionary(p => (document.GetElement(p.Key) as ElementType)!, p => p.Value);
    }

    /// <summary>
    /// 统计类型在文档中存在的实例的数量
    /// </summary>
    /// <typeparam name="T">类型所对应的实例的类</typeparam>
    /// <param name="elementTypes"></param>
    /// <returns></returns>
    public static IDictionary<ElementType, int> Counts<T>(this IEnumerable<ElementType> elementTypes) where T : HostObject
    {
        Dictionary<ElementId, int> amount = elementTypes.ToDictionary(t => t.Id, _ => 0);
        if (!elementTypes.Any())
        {
            return new Dictionary<ElementType, int>();
        }

        Document document = elementTypes.First().Document;
        IEnumerable<T> elements = document.GetElements<T>();
        foreach (var element in elements)
        {
            ElementId id = element.GetTypeId();
            if (amount.TryGetValue(id, out int count))
            {
                amount[id] = count + 1;
                continue;
            }
        }
        return amount.ToDictionary(p => (document.GetElement(p.Key) as ElementType)!, p => p.Value);
    }

    /// <summary>
    /// 获取具有图元实例的图元类型
    /// <para>Get the elements in the document whose has instances exist</para>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="document">要查询的文档</param>
    /// <returns>从文档中查询到的图元集合 <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<ElementType> GetElementTypesWhereHasInstances<T>(this Document document) where T : HostObject
    {
        return document.GetElementTypesAndInstancesCount<T>().Where(p => p.Value > 0).ToDictionary(p => p.Key, p => p.Value).Keys.ToList();
    }
}
