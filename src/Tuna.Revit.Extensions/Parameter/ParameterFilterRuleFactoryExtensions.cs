/************************************************************************************
   Author:十五
   CretaeTime:2023/4/3 23:55:24
   Mail:1012201478@qq.com
   Github:https://github.com/shichuyibushishiwu

   Description:

************************************************************************************/

using Autodesk.Revit.DB;

namespace Tuna.Revit.Extensions;

/// <summary>
/// Revit parameter filter rule extensions
/// </summary>
public static class ParameterFilterRuleFactoryExtensions
{
    /// <summary>
    /// Creates a filter rule that determines whether strings from the document equal a certain value.
    /// </summary>
    /// <param name="id">Parameter id.</param>
    /// <param name="value">String value.</param>
    /// <param name="caseSensitive">Case sensitive for Revit 2022 and earlier.</param>
    /// <returns></returns>
    public static FilterRule CreateEqualsRule(ElementId id, string value, bool caseSensitive = false)
    {
#if Rvt_23_Before
        return ParameterFilterRuleFactory.CreateEqualsRule(id, value, caseSensitive);

#else
        return ParameterFilterRuleFactory.CreateEqualsRule(id, value);
#endif
    }

    /// <summary>
    /// Creates a filter rule that determines whether strings from the document do not equal a certain value.
    /// </summary>
    /// <param name="id">Parameter id.</param>
    /// <param name="value">String value.</param>
    /// <param name="caseSensitive">Case sensitive for Revit 2022 and earlier.</param>
    /// <returns></returns>
    public static FilterRule CreateNotEqualsRule(ElementId id, string value, bool caseSensitive = false)
    {
#if Rvt_23_Before
        return ParameterFilterRuleFactory.CreateNotEqualsRule(id, value, caseSensitive);
#else
        return ParameterFilterRuleFactory.CreateNotEqualsRule(id, value);
#endif
    }

    /// <summary>
    /// Creates a filter rule that determines whether strings from the document contain a certain value.
    /// </summary>
    /// <param name="id">Parameter id.</param>
    /// <param name="value">String value.</param>
    /// <param name="caseSensitive">Case sensitive for Revit 2022 and earlier.</param>
    /// <returns></returns>
    public static FilterRule CreateContainsRule(ElementId id, string value, bool caseSensitive = false)
    {
#if Rvt_23_Before
        return ParameterFilterRuleFactory.CreateContainsRule(id, value, caseSensitive);
#else
        return ParameterFilterRuleFactory.CreateContainsRule(id, value);
#endif
    }

    /// <summary>
    /// Creates a filter rule that determines whether strings from the document begin with a certain value.
    /// </summary>
    /// <param name="id">Parameter id.</param>
    /// <param name="value">String value.</param>
    /// <param name="caseSensitive">Case sensitive for Revit 2022 and earlier.</param>
    /// <returns></returns>
    public static FilterRule CreateBeginsWithRule(ElementId id, string value, bool caseSensitive = false)
    {
#if Rvt_23_Before
        return ParameterFilterRuleFactory.CreateBeginsWithRule(id, value, caseSensitive);
#else
        return ParameterFilterRuleFactory.CreateBeginsWithRule(id, value);
#endif
    }

    /// <summary>
    /// Creates a filter rule that determines whether strings from the document end with a certain value.
    /// </summary>
    /// <param name="id">Parameter id.</param>
    /// <param name="value">String value.</param>
    /// <param name="caseSensitive">Case sensitive for Revit 2022 and earlier.</param>
    /// <returns></returns>
    public static FilterRule CreateEndsWithRule(ElementId id, string value, bool caseSensitive = false)
    {
#if Rvt_23_Before
        return ParameterFilterRuleFactory.CreateEndsWithRule(id, value, caseSensitive);
#else
        return ParameterFilterRuleFactory.CreateEndsWithRule(id, value);
#endif
    }
}
