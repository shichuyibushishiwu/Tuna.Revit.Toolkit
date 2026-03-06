/************************************************************************************
   Author:十五
   CretaeTime:2023/4/22 19:01:35
   Mail:1012201478@qq.com
   Github:https://github.com/shichuyibushishiwu

   Description:

************************************************************************************/

using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
using System;
using System.Collections.Generic;

namespace Tuna.Revit.Extensions;

/// <summary>
/// 提供创建Revit元素过滤器的工厂类
/// <para>Element filter factory for creating various Revit element filters</para>
/// </summary>
public class ElementFilterFactory
{
    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个逻辑与过滤器，用于组合多个过滤条件（必须同时满足所有条件）
    /// <para>Create a <see cref="Autodesk.Revit.DB.LogicalAndFilter"/> that combines multiple filters (all conditions must be met)</para>
    /// </summary>
    /// <param name="filters">要组合的过滤器数组</param>
    /// <returns><see cref="Autodesk.Revit.DB.LogicalAndFilter"/></returns>
    public static LogicalAndFilter LogicalAnd(params ElementFilter[] filters)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(filters);
        return new LogicalAndFilter(filters);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个逻辑或过滤器，用于组合多个过滤条件（满足任一条件即可）
    /// <para>Create a logical OR filter that combines multiple filters (any condition can be met)</para>
    /// </summary>
    /// <param name="filters">要组合的过滤器数组</param>
    /// <returns><see cref="Autodesk.Revit.DB.LogicalOrFilter"/></returns>
    public static LogicalOrFilter LogicalOr(params ElementFilter[] filters)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(filters);
        return new LogicalOrFilter(filters);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个类型过滤器，用于过滤指定类型的元素
    /// <para>Create a class filter to filter elements of a specific type</para>
    /// </summary>
    /// <param name="type">要过滤的元素类型</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementClassFilter"/></returns>
    public static ElementClassFilter Class(Type type)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(type);
        return new ElementClassFilter(type);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个多类型过滤器，用于过滤多个指定类型的元素
    /// <para>Create a multi-class filter to filter elements of multiple specified types</para>
    /// </summary>
    /// <param name="types">要过滤的元素类型数组</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementMulticlassFilter"/></returns>
    public static ElementMulticlassFilter Multiclass(List<Type> types)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(types);
        return new ElementMulticlassFilter(types);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个类别过滤器，用于过滤指定内置类别的元素
    /// <para>Create an <see cref="Autodesk.Revit.DB.ElementCategoryFilter"/> for a <see cref="Autodesk.Revit.DB.BuiltInCategory"/></para>
    /// </summary>
    /// <param name="builtInCategory">要过滤的内置类别</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementCategoryFilter"/></returns>
    public static ElementCategoryFilter Category(BuiltInCategory builtInCategory)
    {
        return new ElementCategoryFilter(builtInCategory);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个类别过滤器，用于过滤指定内置类别的元素（支持取反）
    /// <para>Create an <see cref="Autodesk.Revit.DB.ElementCategoryFilter"/> for a <see cref="Autodesk.Revit.DB.BuiltInCategory"/> (support inverted)</para>
    /// </summary>
    /// <param name="builtInCategory">要过滤的内置类别</param>
    /// <param name="inverted">是否取反</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementCategoryFilter"/></returns>
    public static ElementCategoryFilter Category(BuiltInCategory builtInCategory, bool inverted)
    {
        return new ElementCategoryFilter(builtInCategory, inverted);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个类别过滤器，用于过滤指定类别Id的元素
    /// <para>Create an <see cref="Autodesk.Revit.DB.ElementCategoryFilter"/> for a category <see cref="Autodesk.Revit.DB.ElementId"/></para>
    /// </summary>
    /// <param name="categoryId">类别Id</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementCategoryFilter"/></returns>
    public static ElementCategoryFilter Category(ElementId categoryId)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(categoryId);
        return new ElementCategoryFilter(categoryId);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个类别过滤器，用于过滤指定类别Id的元素（支持取反）
    /// <para>Create an <see cref="Autodesk.Revit.DB.ElementCategoryFilter"/> for a category <see cref="Autodesk.Revit.DB.ElementId"/> (support inverted)</para>
    /// </summary>
    /// <param name="categoryId">类别Id</param>
    /// <param name="inverted">是否取反</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementCategoryFilter"/></returns>
    public static ElementCategoryFilter Category(ElementId categoryId, bool inverted)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(categoryId);
        return new ElementCategoryFilter(categoryId, inverted);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个多类别过滤器，用于过滤多个内置类别的元素
    /// <para>Create an <see cref="Autodesk.Revit.DB.ElementMulticategoryFilter"/> for multiple <see cref="Autodesk.Revit.DB.BuiltInCategory"/></para>
    /// </summary>
    /// <param name="builtInCategories">要过滤的内置类别集合</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementMulticategoryFilter"/></returns>
    public static ElementMulticategoryFilter Multicategory(List<BuiltInCategory> builtInCategories)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(builtInCategories);
        return new ElementMulticategoryFilter(builtInCategories);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个多类别过滤器，用于过滤多个类别Id的元素
    /// <para>Create an <see cref="Autodesk.Revit.DB.ElementMulticategoryFilter"/> for multiple category <see cref="Autodesk.Revit.DB.ElementId"/></para>
    /// </summary>
    /// <param name="categoryIds">要过滤的类别Id集合</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementMulticategoryFilter"/></returns>
    public static ElementMulticategoryFilter Multicategory(List<ElementId> categoryIds)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(categoryIds);
        return new ElementMulticategoryFilter(categoryIds);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个元素Id集合过滤器，用于过滤指定Id集合中的元素
    /// <para>Create an <see cref="Autodesk.Revit.DB.ElementIdSetFilter"/> for a set of element ids</para>
    /// </summary>
    /// <param name="elementIds">元素Id集合</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementIdSetFilter"/></returns>
    public static ElementIdSetFilter IdSet(ICollection<ElementId> elementIds)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(elementIds);
        return new ElementIdSetFilter(elementIds);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个排除过滤器，用于从结果中排除指定Id集合的元素
    /// <para>Create an <see cref="Autodesk.Revit.DB.ExclusionFilter"/> to exclude elements by ids</para>
    /// </summary>
    /// <param name="elementIds">要排除的元素Id集合</param>
    /// <returns><see cref="Autodesk.Revit.DB.ExclusionFilter"/></returns>
    public static ExclusionFilter Excluding(ICollection<ElementId> elementIds)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(elementIds);
        return new ExclusionFilter(elementIds);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个元素类型过滤器，用于过滤是否为ElementType的元素（支持取反）
    /// <para>Create an <see cref="Autodesk.Revit.DB.ElementIsElementTypeFilter"/> (support inverted)</para>
    /// </summary>
    /// <param name="inverted">是否取反</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementIsElementTypeFilter"/></returns>
    public static ElementIsElementTypeFilter ElementIsElementType(bool inverted = false)
    {
        return new ElementIsElementTypeFilter(inverted);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个标高过滤器，用于过滤约束到指定标高的元素
    /// <para>Create an <see cref="Autodesk.Revit.DB.ElementLevelFilter"/> for a level id</para>
    /// </summary>
    /// <param name="levelId">标高Id</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementLevelFilter"/></returns>
    public static ElementLevelFilter Level(ElementId levelId)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(levelId);
        return new ElementLevelFilter(levelId);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个宿主视图过滤器，用于过滤属于指定视图的元素
    /// <para>Create an <see cref="Autodesk.Revit.DB.ElementOwnerViewFilter"/> for an owner view id</para>
    /// </summary>
    /// <param name="viewId">视图Id</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementOwnerViewFilter"/></returns>
    public static ElementOwnerViewFilter OwnerView(ElementId viewId)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(viewId);
        return new ElementOwnerViewFilter(viewId);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个视图可见性过滤器，用于过滤在指定视图中可见的元素
    /// <para>Create a <see cref="Autodesk.Revit.DB.VisibleInViewFilter"/> for a view</para>
    /// </summary>
    /// <param name="document">文档</param>
    /// <param name="viewId">视图Id</param>
    /// <returns><see cref="Autodesk.Revit.DB.VisibleInViewFilter"/></returns>
    public static VisibleInViewFilter VisibleInView(Document document, ElementId viewId)
    {
        ArgumentNullExceptionUtils.ThrowIfNullOrInvalid(document);
        ArgumentNullExceptionUtils.ThrowIfNull(viewId);
        return new VisibleInViewFilter(document, viewId);
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个族实例过滤器，用于过滤指定族类型的族实例
    /// <para>Create a <see cref="Autodesk.Revit.DB.FamilyInstanceFilter"/> for a family symbol id</para>
    /// </summary>
    /// <param name="document">文档</param>
    /// <param name="familySymbolId">族类型Id</param>
    /// <returns><see cref="Autodesk.Revit.DB.FamilyInstanceFilter"/></returns>
    public static FamilyInstanceFilter FamilyInstance(Document document, ElementId familySymbolId)
    {
        ArgumentNullExceptionUtils.ThrowIfNullOrInvalid(document);
        ArgumentNullExceptionUtils.ThrowIfNull(familySymbolId);
        return new FamilyInstanceFilter(document, familySymbolId);
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个结构墙体用途过滤器，用于过滤指定结构用途的墙体实例
    /// <para>Create a <see cref="Autodesk.Revit.DB.Structure.StructuralWallUsageFilter"/> for a <see cref="Autodesk.Revit.DB.Structure.StructuralWallUsage"/></para>
    /// </summary>
    /// <param name="structuralWallUsage">结构墙体用途</param>
    /// <returns><see cref="Autodesk.Revit.DB.Structure.StructuralWallUsageFilter"/></returns>
    public static StructuralWallUsageFilter StructuralWallUsage(StructuralWallUsage structuralWallUsage)
    {
        return new StructuralWallUsageFilter(structuralWallUsage);
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个结构材质类型过滤器，用于过滤族实例参数「用于模型行为的材质」
    /// <para>Create a <see cref="Autodesk.Revit.DB.Structure.StructuralMaterialTypeFilter"/> for a <see cref="Autodesk.Revit.DB.Structure.StructuralMaterialType"/></para>
    /// </summary>
    /// <param name="structuralMaterialType">结构材质类型</param>
    /// <returns><see cref="Autodesk.Revit.DB.Structure.StructuralMaterialTypeFilter"/></returns>
    public static StructuralMaterialTypeFilter StructuralMaterialType(StructuralMaterialType structuralMaterialType)
    {
        return new StructuralMaterialTypeFilter(structuralMaterialType);
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个结构实例用途过滤器，用于过滤实例参数「结构用途」
    /// <para>Create a <see cref="Autodesk.Revit.DB.Structure.StructuralInstanceUsageFilter"/> for a <see cref="Autodesk.Revit.DB.Structure.StructuralInstanceUsage"/></para>
    /// </summary>
    /// <param name="structuralInstanceUsage">结构实例用途</param>
    /// <returns><see cref="Autodesk.Revit.DB.Structure.StructuralInstanceUsageFilter"/></returns>
    public static StructuralInstanceUsageFilter StructuralInstanceUsage(StructuralInstanceUsage structuralInstanceUsage)
    {
        return new StructuralInstanceUsageFilter(structuralInstanceUsage);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个结构类型过滤器，用于过滤指定结构类型的族实例
    /// <para>Create an <see cref="Autodesk.Revit.DB.ElementStructuralTypeFilter"/> for a <see cref="Autodesk.Revit.DB.Structure.StructuralType"/></para>
    /// </summary>
    /// <param name="structuralType">结构类型</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementStructuralTypeFilter"/></returns>
    public static ElementStructuralTypeFilter ElementStructuralType(StructuralType structuralType)
    {
        return new ElementStructuralTypeFilter(structuralType);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个线性图元过滤器，用于过滤指定线性类型的图元
    /// <para>Create a <see cref="Autodesk.Revit.DB.CurveElementFilter"/> for a <see cref="Autodesk.Revit.DB.CurveElementType"/></para>
    /// </summary>
    /// <param name="curveElementType">线性类型</param>
    /// <returns><see cref="Autodesk.Revit.DB.CurveElementFilter"/></returns>
    public static CurveElementFilter CurveElement(CurveElementType curveElementType)
    {
        return new CurveElementFilter(curveElementType);
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个结构族材质类型过滤器，用于过滤结构族对象
    /// <para>Create a <see cref="Autodesk.Revit.DB.Structure.FamilyStructuralMaterialTypeFilter"/> for a <see cref="Autodesk.Revit.DB.Structure.StructuralMaterialType"/></para>
    /// </summary>
    /// <param name="structuralMaterialType">结构材质类型</param>
    /// <returns><see cref="Autodesk.Revit.DB.Structure.FamilyStructuralMaterialTypeFilter"/></returns>
    public static FamilyStructuralMaterialTypeFilter FamilyStructuralMaterialType(StructuralMaterialType structuralMaterialType)
    {
        return new FamilyStructuralMaterialTypeFilter(structuralMaterialType);
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个族类型过滤器，用于过滤属于指定族Id的族类型
    /// <para>Create a <see cref="Autodesk.Revit.DB.FamilySymbolFilter"/> for a family <see cref="Autodesk.Revit.DB.ElementId"/></para>
    /// </summary>
    /// <param name="familyId">族Id</param>
    /// <returns><see cref="Autodesk.Revit.DB.FamilySymbolFilter"/></returns>
    public static FamilySymbolFilter FamilySymbol(ElementId familyId)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(familyId);
        return new FamilySymbolFilter(familyId);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个视图可选择过滤器，用于过滤在指定视图中可选择的元素
    /// <para>Create a <see cref="Autodesk.Revit.UI.Selection.SelectableInViewFilter"/> for a view</para>
    /// </summary>
    /// <param name="document">文档</param>
    /// <param name="viewId">视图Id</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementFilter"/></returns>
    public static ElementFilter SelectableInView(Document document, ElementId viewId)
    {
        ArgumentNullExceptionUtils.ThrowIfNullOrInvalid(document);
        ArgumentNullExceptionUtils.ThrowIfNull(viewId);
        return new Autodesk.Revit.UI.Selection.SelectableInViewFilter(document, viewId);

     
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个边界框相交过滤器，用于过滤与给定轮廓相交的元素
    /// <para>Create a bounding box intersects filter to find elements that intersect with the given outline</para>
    /// </summary>
    /// <param name="outline">用于检查相交的轮廓</param>
    /// <returns><see cref="Autodesk.Revit.DB.BoundingBoxIntersectsFilter"/></returns>
    public static BoundingBoxIntersectsFilter IntersectsWith(Outline outline)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(outline);
        return new BoundingBoxIntersectsFilter(outline);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个边界框相交过滤器，用于过滤与给定边界框相交的元素
    /// <para>Create a bounding box intersects filter to find elements that intersect with the given bounding box</para>
    /// </summary>
    /// <param name="boundingBox">边界框</param>
    /// <returns><see cref="Autodesk.Revit.DB.BoundingBoxIntersectsFilter"/></returns>
    public static BoundingBoxIntersectsFilter IntersectsWith(BoundingBoxXYZ boundingBox)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(boundingBox);
        return new BoundingBoxIntersectsFilter(new Outline(boundingBox.Min, boundingBox.Max));
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个图元相交过滤器，用于过滤与指定图元发生相交的元素
    /// <para>Create an <see cref="Autodesk.Revit.DB.ElementIntersectsElementFilter"/> that finds elements intersecting the given element</para>
    /// </summary>
    /// <param name="element">用于碰撞检测的目标图元</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementIntersectsElementFilter"/></returns>
    public static ElementIntersectsElementFilter Intersects(Element element)
    {
        ArgumentNullExceptionUtils.ThrowIfNullOrInvalid(element);
        return new ElementIntersectsElementFilter(element);
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个实体相交过滤器，用于过滤与指定实体发生相交的元素
    /// <para>Create an <see cref="Autodesk.Revit.DB.ElementIntersectsSolidFilter"/> that finds elements intersecting the given solid</para>
    /// </summary>
    /// <param name="solid">用于碰撞检测的实体</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementIntersectsSolidFilter"/></returns>
    public static ElementIntersectsSolidFilter Intersects(Solid solid)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(solid);
        return new ElementIntersectsSolidFilter(solid);
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个边界框内部过滤器，用于过滤完全位于给定边界框内的元素
    /// <para>Create a bounding box inside filter to find elements that are completely inside the given bounding box</para>
    /// </summary>
    /// <param name="boundingBox">用于检查包含关系的边界框</param>
    /// <returns><see cref="Autodesk.Revit.DB.BoundingBoxIsInsideFilter"/></returns>
    public static BoundingBoxIsInsideFilter InsideTheBoundingBox(BoundingBoxXYZ boundingBox)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(boundingBox);
        return new BoundingBoxIsInsideFilter(new Outline(boundingBox.Min, boundingBox.Max));
    }

    /// <summary>
    /// <c>[Quick Filter]</c>
    /// 创建一个边界框内部过滤器，用于过滤完全位于给定轮廓内的元素
    /// <para>Create a bounding box inside filter to find elements that are completely inside the given outline</para>
    /// </summary>
    /// <param name="outline">用于检查包含关系的轮廓</param>
    /// <returns><see cref="Autodesk.Revit.DB.BoundingBoxIsInsideFilter"/></returns>
    public static BoundingBoxIsInsideFilter InsideTheBoundingBox(Outline outline)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(outline);
        return new BoundingBoxIsInsideFilter(outline);
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数相等过滤器，用于过滤指定参数值等于给定整数的元素
    /// <para>Create a parameter equals filter for integer values</para>
    /// </summary>
    /// <param name="parameterId">参数的ElementId</param>
    /// <param name="value">要比较的整数值</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterEqualsTo(ElementId parameterId, int value)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(parameterId);
        return new ElementParameterFilter(ParameterFilterRuleFactory.CreateEqualsRule(parameterId, value));
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数相等过滤器，用于过滤指定参数值等于给定ElementId的元素
    /// <para>Create a parameter equals filter for ElementId values</para>
    /// </summary>
    /// <param name="parameterId">参数的ElementId</param>
    /// <param name="value">要比较的ElementId值</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterEqualsTo(ElementId parameterId, ElementId value)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(parameterId);
        ArgumentNullExceptionUtils.ThrowIfNull(value);
        return new ElementParameterFilter(ParameterFilterRuleFactory.CreateEqualsRule(parameterId, value));
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数相等过滤器，用于过滤指定参数值等于给定字符串的元素（支持大小写设置）
    /// <para>Create a parameter equals filter for string values (support caseSensitive for Revit 2022 and earlier)</para>
    /// </summary>
    /// <param name="parameterId">参数的ElementId</param>
    /// <param name="value">要比较的字符串值</param>
    /// <param name="caseSensitive">Revit 2022及之前可用，控制是否区分大小写</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterEqualsTo(ElementId parameterId, string value, bool caseSensitive)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(parameterId);
        ArgumentNullExceptionUtils.ThrowIfNull(value);
        return new ElementParameterFilter(ParameterFilterRuleFactoryExtensions.CreateEqualsRule(parameterId, value, caseSensitive));
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数相等过滤器，用于过滤指定参数值等于给定字符串的元素
    /// <para>Create a parameter equals filter for string values</para>
    /// </summary>
    /// <param name="parameterId">参数的ElementId</param>
    /// <param name="value">要比较的字符串值</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterEqualsTo(ElementId parameterId, string value)
    {
        return ParameterEqualsTo(parameterId, value, false);
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数相等过滤器，用于过滤指定内置参数值等于给定字符串的元素
    /// <para>Create a parameter equals filter for builtin parameter id (string values)</para>
    /// </summary>
    /// <param name="parameter">内置参数</param>
    /// <param name="value">要比较的字符串值</param>
    /// <param name="caseSensitive">Revit 2022及之前可用，控制是否区分大小写</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterEqualsTo(BuiltInParameter parameter, string value, bool caseSensitive = false)
    {
        return ParameterEqualsTo(new ElementId(parameter), value, caseSensitive);
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数相等过滤器，用于过滤指定内置参数值等于给定整数的元素
    /// <para>Create a parameter equals filter for builtin parameter id (integer values)</para>
    /// </summary>
    /// <param name="parameter">内置参数</param>
    /// <param name="value">要比较的整数值</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterEqualsTo(BuiltInParameter parameter, int value)
    {
        return ParameterEqualsTo(new ElementId(parameter), value);
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数相等过滤器，用于过滤指定内置参数值等于给定ElementId的元素
    /// <para>Create a parameter equals filter for builtin parameter id (ElementId values)</para>
    /// </summary>
    /// <param name="parameter">内置参数</param>
    /// <param name="value">要比较的ElementId值</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterEqualsTo(BuiltInParameter parameter, ElementId value)
    {
        return ParameterEqualsTo(new ElementId(parameter), value);
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数不相等过滤器，用于过滤指定参数值不等于给定字符串的元素
    /// <para>Create a parameter not-equals filter for string values</para>
    /// </summary>
    /// <param name="parameterId">参数的ElementId</param>
    /// <param name="value">要比较的字符串值</param>
    /// <param name="caseSensitive">Revit 2022及之前可用，控制是否区分大小写</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterNotEqualsTo(ElementId parameterId, string value, bool caseSensitive = false)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(parameterId);
        ArgumentNullExceptionUtils.ThrowIfNull(value);
        return new ElementParameterFilter(ParameterFilterRuleFactoryExtensions.CreateNotEqualsRule(parameterId, value, caseSensitive));
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数包含过滤器，用于过滤指定参数值包含给定字符串的元素
    /// <para>Create a parameter contains filter for string values</para>
    /// </summary>
    /// <param name="parameterId">参数的ElementId</param>
    /// <param name="value">要比较的字符串值</param>
    /// <param name="caseSensitive">Revit 2022及之前可用，控制是否区分大小写</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterContains(ElementId parameterId, string value, bool caseSensitive = false)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(parameterId);
        ArgumentNullExceptionUtils.ThrowIfNull(value);
        return new ElementParameterFilter(ParameterFilterRuleFactoryExtensions.CreateContainsRule(parameterId, value, caseSensitive));
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数开头匹配过滤器，用于过滤指定参数值以给定字符串开头的元素
    /// <para>Create a parameter begins-with filter for string values</para>
    /// </summary>
    /// <param name="parameterId">参数的ElementId</param>
    /// <param name="value">要比较的字符串值</param>
    /// <param name="caseSensitive">Revit 2022及之前可用，控制是否区分大小写</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterBeginsWith(ElementId parameterId, string value, bool caseSensitive = false)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(parameterId);
        ArgumentNullExceptionUtils.ThrowIfNull(value);
        return new ElementParameterFilter(ParameterFilterRuleFactoryExtensions.CreateBeginsWithRule(parameterId, value, caseSensitive));
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数结尾匹配过滤器，用于过滤指定参数值以给定字符串结尾的元素
    /// <para>Create a parameter ends-with filter for string values</para>
    /// </summary>
    /// <param name="parameterId">参数的ElementId</param>
    /// <param name="value">要比较的字符串值</param>
    /// <param name="caseSensitive">Revit 2022及之前可用，控制是否区分大小写</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterEndsWith(ElementId parameterId, string value, bool caseSensitive = false)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(parameterId);
        ArgumentNullExceptionUtils.ThrowIfNull(value);
        return new ElementParameterFilter(ParameterFilterRuleFactoryExtensions.CreateEndsWithRule(parameterId, value, caseSensitive));
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数大于过滤器，用于过滤指定整数参数值大于给定值的元素
    /// <para>Create a parameter greater-than filter for integer values</para>
    /// </summary>
    /// <param name="parameterId">参数的ElementId</param>
    /// <param name="value">要比较的整数值</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterGreaterThan(ElementId parameterId, int value)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(parameterId);
        return new ElementParameterFilter(ParameterFilterRuleFactory.CreateGreaterRule(parameterId, value));
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数大于过滤器，用于过滤指定双精度参数值大于给定值的元素
    /// <para>Create a parameter greater-than filter for double values</para>
    /// </summary>
    /// <param name="parameterId">参数的ElementId</param>
    /// <param name="value">要比较的双精度值</param>
    /// <param name="tolerance">数值比较容差</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterGreaterThan(ElementId parameterId, double value, double tolerance = 1e-6)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(parameterId);
        return new ElementParameterFilter(ParameterFilterRuleFactory.CreateGreaterRule(parameterId, value, tolerance));
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数小于过滤器，用于过滤指定整数参数值小于给定值的元素
    /// <para>Create a parameter less-than filter for integer values</para>
    /// </summary>
    /// <param name="parameterId">参数的ElementId</param>
    /// <param name="value">要比较的整数值</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterLessThan(ElementId parameterId, int value)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(parameterId);
        return new ElementParameterFilter(ParameterFilterRuleFactory.CreateLessRule(parameterId, value));
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数小于过滤器，用于过滤指定双精度参数值小于给定值的元素
    /// <para>Create a parameter less-than filter for double values</para>
    /// </summary>
    /// <param name="parameterId">参数的ElementId</param>
    /// <param name="value">要比较的双精度值</param>
    /// <param name="tolerance">数值比较容差</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterLessThan(ElementId parameterId, double value, double tolerance = 1e-6)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(parameterId);
        return new ElementParameterFilter(ParameterFilterRuleFactory.CreateLessRule(parameterId, value, tolerance));
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数大于等于过滤器，用于过滤指定整数参数值大于等于给定值的元素
    /// <para>Create a parameter greater-or-equal filter for integer values</para>
    /// </summary>
    /// <param name="parameterId">参数的ElementId</param>
    /// <param name="value">要比较的整数值</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterGreaterOrEqual(ElementId parameterId, int value)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(parameterId);
        return new ElementParameterFilter(ParameterFilterRuleFactory.CreateGreaterOrEqualRule(parameterId, value));
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数大于等于过滤器，用于过滤指定双精度参数值大于等于给定值的元素
    /// <para>Create a parameter greater-or-equal filter for double values</para>
    /// </summary>
    /// <param name="parameterId">参数的ElementId</param>
    /// <param name="value">要比较的双精度值</param>
    /// <param name="tolerance">数值比较容差</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterGreaterOrEqual(ElementId parameterId, double value, double tolerance = 1e-6)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(parameterId);
        return new ElementParameterFilter(ParameterFilterRuleFactory.CreateGreaterOrEqualRule(parameterId, value, tolerance));
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数小于等于过滤器，用于过滤指定双精度参数值小于等于给定值的元素
    /// <para>Create a parameter less-or-equal filter for double values</para>
    /// </summary>
    /// <param name="parameterId">参数的ElementId</param>
    /// <param name="value">要比较的双精度值</param>
    /// <param name="tolerance">数值比较容差</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterLessOrEqual(ElementId parameterId, double value, double tolerance = 1e-6)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(parameterId);
        return new ElementParameterFilter(ParameterFilterRuleFactory.CreateLessOrEqualRule(parameterId, value, tolerance));
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数小于等于过滤器，用于过滤指定整数参数值小于等于给定值的元素
    /// <para>Create a parameter less-or-equal filter for integer values</para>
    /// </summary>
    /// <param name="parameterId">参数的ElementId</param>
    /// <param name="value">要比较的整数值</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterLessOrEqual(ElementId parameterId, int value)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(parameterId);
        return new ElementParameterFilter(ParameterFilterRuleFactory.CreateLessOrEqualRule(parameterId, value));
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数过滤器，用于组合多个参数过滤规则（全部满足）
    /// <para>Create an <see cref="Autodesk.Revit.DB.ElementParameterFilter"/> that combines multiple rules (all rules must be met)</para>
    /// </summary>
    /// <param name="rules">参数过滤规则</param>
    /// <returns><see cref="Autodesk.Revit.DB.ElementParameterFilter"/></returns>
    public static ElementParameterFilter ParameterAll(params FilterRule[] rules)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(rules);
        return new ElementParameterFilter(rules);
    }

    /// <summary>
    /// <c>[Slow Filter]</c>
    /// 创建一个参数过滤器，用于组合多个参数过滤规则（满足任一规则即可）
    /// <para>Create a logical OR parameter filter that combines multiple rules (any rule can be met)</para>
    /// </summary>
    /// <param name="rules">参数过滤规则</param>
    /// <returns><see cref="Autodesk.Revit.DB.LogicalOrFilter"/></returns>
    public static LogicalOrFilter ParameterAny(params FilterRule[] rules)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(rules);
        if (rules.Length == 0)
        {
            throw new ArgumentException("rules can not be empty", nameof(rules));
        }

        var filters = new ElementFilter[rules.Length];
        for (int i = 0; i < rules.Length; i++)
        {
            filters[i] = new ElementParameterFilter(rules[i]);
        }
        return new LogicalOrFilter(filters);
    }
}
