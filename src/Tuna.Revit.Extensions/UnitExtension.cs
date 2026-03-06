/************************************************************************************
   Author:十五
   CretaeTime:2021/12/10 19:30:36
   Mail:1012201478@qq.com
   Github:https://github.com/shichuyibushishiwu

   Description:

************************************************************************************/

using Autodesk.Revit.DB;
using System;
using System.Diagnostics;

namespace Tuna.Revit.Extensions;

/// <summary>
/// Revit unit extensions
/// </summary>
public static class UnitExtension
{
    /// <summary>
    /// 将值的单位从 (英尺) 转为 (毫米)
    /// <para>Convert value to millimeters</para>
    /// </summary>
    /// <param name="doubleValue">单位为英尺的值</param>
    /// <returns>单位为毫米的值</returns>
    [DebuggerStepThrough, Obsolete]
    public static double ConvertToMillimeters(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_DECIMAL_FEET, DisplayUnitType.DUT_MILLIMETERS);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.Feet, UnitTypeId.Millimeters);
#endif
    }

    /// <summary>
    /// 将值的单位从 (英尺) 转为 (毫米)
    /// <para>Convert value to millimeters</para>
    /// </summary>
    /// <param name="value">单位为英尺的值</param>
    /// <returns>单位为毫米的值</returns>
    [DebuggerStepThrough, Obsolete]
    public static double ConvertToMillimeters(this int value) => ConvertToMillimeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (英尺) 转为 (毫米)
    /// <para>Convert value to millimeters</para>
    /// </summary>
    /// <param name="value">单位为英尺的值</param>
    /// <returns>单位为毫米的值</returns>
    [DebuggerStepThrough, Obsolete]
    public static double ConvertToMillimeters(this float value) => ConvertToMillimeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (毫米) 转为 (英尺)
    /// <para>Convert millimeters to feet</para>
    /// </summary>
    /// <param name="doubleValue">单位为毫米的值</param>
    /// <returns>单位为英尺的值</returns>
    [DebuggerStepThrough, Obsolete]
    public static double ConvertToFeet(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_MILLIMETERS, DisplayUnitType.DUT_DECIMAL_FEET);

#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.Millimeters, UnitTypeId.Feet);
#endif
    }

    /// <summary>
    /// 将值的单位从 (毫米) 转为 (英尺)
    /// <para>Convert millimeters to feet</para>
    /// </summary>
    /// <param name="value">单位为毫米的值</param>
    /// <returns>单位为英尺的值</returns>
    [DebuggerStepThrough, Obsolete]
    public static double ConvertToFeet(this int value) => ConvertToFeet(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (毫米) 转为 (英尺)
    /// <para>Convert millimeters to feet</para>
    /// </summary>
    /// <param name="value">单位为毫米的值</param>
    /// <returns>单位为英尺的值</returns>
    [DebuggerStepThrough, Obsolete]
    public static double ConvertToFeet(this float value) => ConvertToFeet(doubleValue: value);

    /// <summary>
    /// 判断两个数值在允许的公差范围内是否相等
    /// </summary>
    /// <param name="value">要比较的数值</param>
    /// <param name="otherValue">要比较的另一个数值</param>
    /// <param name="tolerance">公差 默认值（1e-9）</param>
    /// <returns>返回 <see cref="bool"/> 值，当为 ture 时表示数值相等，false表示不相等</returns>
    [DebuggerStepThrough, Obsolete]
    public static bool AlmostEquals(this double value, double otherValue, double tolerance = 1E-09)
    {
        return Math.Abs(value - otherValue) <= tolerance;
    }






    /// <summary>
    /// 将值的单位从 (英尺) 转为 (毫米)
    /// <para>Convert feet to millimeters</para>
    /// </summary>
    /// <param name="doubleValue">单位为英尺的值</param>
    /// <returns>单位为毫米的值</returns>
    [DebuggerStepThrough]
    public static double FeetToMillimeters(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_DECIMAL_FEET, DisplayUnitType.DUT_MILLIMETERS);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.Feet, UnitTypeId.Millimeters);
#endif
    }

    /// <summary>
    /// 将值的单位从 (英尺) 转为 (毫米)
    /// <para>Convert feet to millimeters</para>
    /// </summary>
    /// <param name="value">单位为英尺的值</param>
    /// <returns>单位为毫米的值</returns>
    [DebuggerStepThrough]
    public static double FeetToMillimeters(this int value) => FeetToMillimeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (英尺) 转为 (毫米)
    /// <para>Convert feet to millimeters</para>
    /// </summary>
    /// <param name="value">单位为英尺的值</param>
    /// <returns>单位为毫米的值</returns>
    [DebuggerStepThrough]
    public static double FeetToMillimeters(this float value) => FeetToMillimeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (英尺) 转为 (厘米)
    /// <para>Convert feet to centimeters</para>
    /// </summary>
    /// <param name="doubleValue">单位为英尺的值</param>
    /// <returns>单位为厘米的值</returns>
    [DebuggerStepThrough]
    public static double FeetToCentimeters(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_DECIMAL_FEET, DisplayUnitType.DUT_CENTIMETERS);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.Feet, UnitTypeId.Centimeters);
#endif
    }

    /// <summary>
    /// 将值的单位从 (英尺) 转为 (厘米)
    /// <para>Convert feet to centimeters</para>
    /// </summary>
    /// <param name="value">单位为英尺的值</param>
    /// <returns>单位为厘米的值</returns>
    [DebuggerStepThrough]
    public static double FeetToCentimeters(this int value) => FeetToCentimeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (英尺) 转为 (厘米)
    /// <para>Convert feet to centimeters</para>
    /// </summary>
    /// <param name="value">单位为英尺的值</param>
    /// <returns>单位为厘米的值</returns>
    [DebuggerStepThrough]
    public static double FeetToCentimeters(this float value) => FeetToCentimeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (英尺) 转为 (分米)
    /// <para>Convert feet to decimeters</para>
    /// </summary>
    /// <param name="doubleValue">单位为英尺的值</param>
    /// <returns>单位为分米的值</returns>
    [DebuggerStepThrough]
    public static double FeetToDecimeters(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_DECIMAL_FEET, DisplayUnitType.DUT_DECIMETERS);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.Feet, UnitTypeId.Decimeters);
#endif
    }

    /// <summary>
    /// 将值的单位从 (英尺) 转为 (分米)
    /// <para>Convert feet to decimeters</para>
    /// </summary>
    /// <param name="value">单位为英尺的值</param>
    /// <returns>单位为分米的值</returns>
    [DebuggerStepThrough]
    public static double FeetToDecimeters(this int value) => FeetToDecimeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (英尺) 转为 (分米)
    /// <para>Convert feet to decimeters</para>
    /// </summary>
    /// <param name="value">单位为英尺的值</param>
    /// <returns>单位为分米的值</returns>
    [DebuggerStepThrough]
    public static double FeetToDecimeters(this float value) => FeetToDecimeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (英尺) 转为 (米)
    /// <para>Convert feet to meters</para>
    /// </summary>
    /// <param name="doubleValue">单位为英尺的值</param>
    /// <returns>单位为米的值</returns>
    [DebuggerStepThrough]
    public static double FeetToMeters(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_DECIMAL_FEET, DisplayUnitType.DUT_METERS);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.Feet, UnitTypeId.Meters);
#endif
    }

    /// <summary>
    /// 将值的单位从 (英尺) 转为 (米)
    /// <para>Convert feet to meters</para>
    /// </summary>
    /// <param name="value">单位为英尺的值</param>
    /// <returns>单位为米的值</returns>
    [DebuggerStepThrough]
    public static double FeetToMeters(this int value) => FeetToMeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (英尺) 转为 (米)
    /// <para>Convert feet to meters</para>
    /// </summary>
    /// <param name="value">单位为英尺的值</param>
    /// <returns>单位为米的值</returns>
    [DebuggerStepThrough]
    public static double FeetToMeters(this float value) => FeetToMeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (毫米) 转为 (英尺)
    /// <para>Convert millimeters to feet</para>
    /// </summary>
    /// <param name="doubleValue">单位为毫米的值</param>
    /// <returns>单位为英尺的值</returns>
    [DebuggerStepThrough]
    public static double MillimetersToFeet(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_MILLIMETERS, DisplayUnitType.DUT_DECIMAL_FEET);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.Millimeters, UnitTypeId.Feet);
#endif
    }

    /// <summary>
    /// 将值的单位从 (毫米) 转为 (英尺)
    /// <para>Convert millimeters to feet</para>
    /// </summary>
    /// <param name="value">单位为毫米的值</param>
    /// <returns>单位为英尺的值</returns>
    [DebuggerStepThrough]
    public static double MillimetersToFeet(this int value) => MillimetersToFeet(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (毫米) 转为 (英尺)
    /// <para>Convert millimeters to feet</para>
    /// </summary>
    /// <param name="value">单位为毫米的值</param>
    /// <returns>单位为英尺的值</returns>
    [DebuggerStepThrough]
    public static double MillimetersToFeet(this float value) => MillimetersToFeet(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (厘米) 转为 (英尺)
    /// <para>Convert centimeters to feet</para>
    /// </summary>
    /// <param name="doubleValue">单位为厘米的值</param>
    /// <returns>单位为英尺的值</returns>
    [DebuggerStepThrough]
    public static double CentimetersToFeet(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_CENTIMETERS, DisplayUnitType.DUT_DECIMAL_FEET);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.Centimeters, UnitTypeId.Feet);
#endif
    }

    /// <summary>
    /// 将值的单位从 (厘米) 转为 (英尺)
    /// <para>Convert centimeters to feet</para>
    /// </summary>
    /// <param name="value">单位为厘米的值</param>
    /// <returns>单位为英尺的值</returns>
    [DebuggerStepThrough]
    public static double CentimetersToFeet(this int value) => CentimetersToFeet(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (厘米) 转为 (英尺)
    /// <para>Convert centimeters to feet</para>
    /// </summary>
    /// <param name="value">单位为厘米的值</param>
    /// <returns>单位为英尺的值</returns>
    [DebuggerStepThrough]
    public static double CentimetersToFeet(this float value) => CentimetersToFeet(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (分米) 转为 (英尺)
    /// <para>Convert decimeters to feet</para>
    /// </summary>
    /// <param name="doubleValue">单位为分米的值</param>
    /// <returns>单位为英尺的值</returns>
    [DebuggerStepThrough]
    public static double DecimetersToFeet(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_DECIMETERS, DisplayUnitType.DUT_DECIMAL_FEET);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.Decimeters, UnitTypeId.Feet);
#endif
    }

    /// <summary>
    /// 将值的单位从 (分米) 转为 (英尺)
    /// <para>Convert decimeters to feet</para>
    /// </summary>
    /// <param name="value">单位为分米的值</param>
    /// <returns>单位为英尺的值</returns>
    [DebuggerStepThrough]
    public static double DecimetersToFeet(this int value) => DecimetersToFeet(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (分米) 转为 (英尺)
    /// <para>Convert decimeters to feet</para>
    /// </summary>
    /// <param name="value">单位为分米的值</param>
    /// <returns>单位为英尺的值</returns>
    [DebuggerStepThrough]
    public static double DecimetersToFeet(this float value) => DecimetersToFeet(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (米) 转为 (英尺)
    /// <para>Convert meters to feet</para>
    /// </summary>
    /// <param name="doubleValue">单位为米的值</param>
    /// <returns>单位为英尺的值</returns>
    [DebuggerStepThrough]
    public static double MetersToFeet(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.Meters, UnitTypeId.Feet);
#endif
    }

    /// <summary>
    /// 将值的单位从 (米) 转为 (英尺)
    /// <para>Convert meters to feet</para>
    /// </summary>
    /// <param name="value">单位为米的值</param>
    /// <returns>单位为英尺的值</returns>
    [DebuggerStepThrough]
    public static double MetersToFeet(this int value) => MetersToFeet(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (米) 转为 (英尺)
    /// <para>Convert meters to feet</para>
    /// </summary>
    /// <param name="value">单位为米的值</param>
    /// <returns>单位为英尺的值</returns>
    [DebuggerStepThrough]
    public static double MetersToFeet(this float value) => MetersToFeet(doubleValue: value);



   

    /// <summary>
    /// 将值的单位从 (平方英尺) 转为 (平方毫米)
    /// <para>Convert square feet to square millimeters</para>
    /// </summary>
    /// <param name="doubleValue">单位为平方英尺的值</param>
    /// <returns>单位为平方毫米的值</returns>
    [DebuggerStepThrough]
    public static double SquareFeetToSquareMillimeters(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_SQUARE_FEET, DisplayUnitType.DUT_SQUARE_MILLIMETERS);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.SquareFeet, UnitTypeId.SquareMillimeters);
#endif
    }

    /// <summary>
    /// 将值的单位从 (平方英尺) 转为 (平方毫米)
    /// <para>Convert square feet to square millimeters</para>
    /// </summary>
    /// <param name="value">单位为平方英尺的值</param>
    /// <returns>单位为平方毫米的值</returns>
    [DebuggerStepThrough]
    public static double SquareFeetToSquareMillimeters(this int value) => SquareFeetToSquareMillimeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (平方英尺) 转为 (平方毫米)
    /// <para>Convert square feet to square millimeters</para>
    /// </summary>
    /// <param name="value">单位为平方英尺的值</param>
    /// <returns>单位为平方毫米的值</returns>
    [DebuggerStepThrough]
    public static double SquareFeetToSquareMillimeters(this float value) => SquareFeetToSquareMillimeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (平方英尺) 转为 (平方厘米)
    /// <para>Convert square feet to square centimeters</para>
    /// </summary>
    /// <param name="doubleValue">单位为平方英尺的值</param>
    /// <returns>单位为平方厘米的值</returns>
    [DebuggerStepThrough]
    public static double SquareFeetToSquareCentimeters(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_SQUARE_FEET, DisplayUnitType.DUT_SQUARE_CENTIMETERS);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.SquareFeet, UnitTypeId.SquareCentimeters);
#endif
    }

    /// <summary>
    /// 将值的单位从 (平方英尺) 转为 (平方厘米)
    /// <para>Convert square feet to square centimeters</para>
    /// </summary>
    /// <param name="value">单位为平方英尺的值</param>
    /// <returns>单位为平方厘米的值</returns>
    [DebuggerStepThrough]
    public static double SquareFeetToSquareCentimeters(this int value) => SquareFeetToSquareCentimeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (平方英尺) 转为 (平方厘米)
    /// <para>Convert square feet to square centimeters</para>
    /// </summary>
    /// <param name="value">单位为平方英尺的值</param>
    /// <returns>单位为平方厘米的值</returns>
    [DebuggerStepThrough]
    public static double SquareFeetToSquareCentimeters(this float value) => SquareFeetToSquareCentimeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (平方英尺) 转为 (平方米)
    /// <para>Convert square feet to square meters</para>
    /// </summary>
    /// <param name="doubleValue">单位为平方英尺的值</param>
    /// <returns>单位为平方米的值</returns>
    [DebuggerStepThrough]
    public static double SquareFeetToSquareMeters(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_SQUARE_FEET, DisplayUnitType.DUT_SQUARE_METERS);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.SquareFeet, UnitTypeId.SquareMeters);
#endif
    }

    /// <summary>
    /// 将值的单位从 (平方英尺) 转为 (平方米)
    /// <para>Convert square feet to square meters</para>
    /// </summary>
    /// <param name="value">单位为平方英尺的值</param>
    /// <returns>单位为平方米的值</returns>
    [DebuggerStepThrough]
    public static double SquareFeetToSquareMeters(this int value) => SquareFeetToSquareMeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (平方英尺) 转为 (平方米)
    /// <para>Convert square feet to square meters</para>
    /// </summary>
    /// <param name="value">单位为平方英尺的值</param>
    /// <returns>单位为平方米的值</returns>
    [DebuggerStepThrough]
    public static double SquareFeetToSquareMeters(this float value) => SquareFeetToSquareMeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (平方毫米) 转为 (平方英尺)
    /// <para>Convert square millimeters to square feet</para>
    /// </summary>
    /// <param name="doubleValue">单位为平方毫米的值</param>
    /// <returns>单位为平方英尺的值</returns>
    [DebuggerStepThrough]
    public static double SquareMillimetersToSquareFeet(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_SQUARE_MILLIMETERS, DisplayUnitType.DUT_SQUARE_FEET);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.SquareMillimeters, UnitTypeId.SquareFeet);
#endif
    }

    /// <summary>
    /// 将值的单位从 (平方毫米) 转为 (平方英尺)
    /// <para>Convert square millimeters to square feet</para>
    /// </summary>
    /// <param name="value">单位为平方毫米的值</param>
    /// <returns>单位为平方英尺的值</returns>
    [DebuggerStepThrough]
    public static double SquareMillimetersToSquareFeet(this int value) => SquareMillimetersToSquareFeet(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (平方毫米) 转为 (平方英尺)
    /// <para>Convert square millimeters to square feet</para>
    /// </summary>
    /// <param name="value">单位为平方毫米的值</param>
    /// <returns>单位为平方英尺的值</returns>
    [DebuggerStepThrough]
    public static double SquareMillimetersToSquareFeet(this float value) => SquareMillimetersToSquareFeet(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (平方厘米) 转为 (平方英尺)
    /// <para>Convert square centimeters to square feet</para>
    /// </summary>
    /// <param name="doubleValue">单位为平方厘米的值</param>
    /// <returns>单位为平方英尺的值</returns>
    [DebuggerStepThrough]
    public static double SquareCentimetersToSquareFeet(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_SQUARE_CENTIMETERS, DisplayUnitType.DUT_SQUARE_FEET);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.SquareCentimeters, UnitTypeId.SquareFeet);
#endif
    }

    /// <summary>
    /// 将值的单位从 (平方厘米) 转为 (平方英尺)
    /// <para>Convert square centimeters to square feet</para>
    /// </summary>
    /// <param name="value">单位为平方厘米的值</param>
    /// <returns>单位为平方英尺的值</returns>
    [DebuggerStepThrough]
    public static double SquareCentimetersToSquareFeet(this int value) => SquareCentimetersToSquareFeet(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (平方厘米) 转为 (平方英尺)
    /// <para>Convert square centimeters to square feet</para>
    /// </summary>
    /// <param name="value">单位为平方厘米的值</param>
    /// <returns>单位为平方英尺的值</returns>
    [DebuggerStepThrough]
    public static double SquareCentimetersToSquareFeet(this float value) => SquareCentimetersToSquareFeet(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (平方米) 转为 (平方英尺)
    /// <para>Convert square meters to square feet</para>
    /// </summary>
    /// <param name="doubleValue">单位为平方米的值</param>
    /// <returns>单位为平方英尺的值</returns>
    [DebuggerStepThrough]
    public static double SquareMetersToSquareFeet(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_SQUARE_METERS, DisplayUnitType.DUT_SQUARE_FEET);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.SquareMeters, UnitTypeId.SquareFeet);
#endif
    }

    /// <summary>
    /// 将值的单位从 (平方米) 转为 (平方英尺)
    /// <para>Convert square meters to square feet</para>
    /// </summary>
    /// <param name="value">单位为平方米的值</param>
    /// <returns>单位为平方英尺的值</returns>
    [DebuggerStepThrough]
    public static double SquareMetersToSquareFeet(this int value) => SquareMetersToSquareFeet(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (平方米) 转为 (平方英尺)
    /// <para>Convert square meters to square feet</para>
    /// </summary>
    /// <param name="value">单位为平方米的值</param>
    /// <returns>单位为平方英尺的值</returns>
    [DebuggerStepThrough]
    public static double SquareMetersToSquareFeet(this float value) => SquareMetersToSquareFeet(doubleValue: value);







    /// <summary>
    /// 将值的单位从 (立方英尺) 转为 (立方米)
    /// <para>Convert cubic feet to cubic meters</para>
    /// </summary>
    /// <param name="doubleValue">单位为立方英尺的值</param>
    /// <returns>单位为立方米的值</returns>
    [DebuggerStepThrough]
    public static double CubicFeetToCubicMeters(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_CUBIC_FEET, DisplayUnitType.DUT_CUBIC_METERS);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.CubicFeet, UnitTypeId.CubicMeters);
#endif
    }

    /// <summary>
    /// 将值的单位从 (立方英尺) 转为 (立方米)
    /// <para>Convert cubic feet to cubic meters</para>
    /// </summary>
    /// <param name="value">单位为立方英尺的值</param>
    /// <returns>单位为立方米的值</returns>
    [DebuggerStepThrough]
    public static double CubicFeetToCubicMeters(this int value) => CubicFeetToCubicMeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (立方英尺) 转为 (立方米)
    /// <para>Convert cubic feet to cubic meters</para>
    /// </summary>
    /// <param name="value">单位为立方英尺的值</param>
    /// <returns>单位为立方米的值</returns>
    [DebuggerStepThrough]
    public static double CubicFeetToCubicMeters(this float value) => CubicFeetToCubicMeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (立方英尺) 转为 (立方毫米)
    /// <para>Convert cubic feet to cubic millimeters</para>
    /// </summary>
    /// <param name="doubleValue">单位为立方英尺的值</param>
    /// <returns>单位为立方毫米的值</returns>
    [DebuggerStepThrough]
    public static double CubicFeetToCubicMillimeters(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_CUBIC_FEET, DisplayUnitType.DUT_CUBIC_MILLIMETERS);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.CubicFeet, UnitTypeId.CubicMillimeters);
#endif
    }

    /// <summary>
    /// 将值的单位从 (立方英尺) 转为 (立方毫米)
    /// <para>Convert cubic feet to cubic millimeters</para>
    /// </summary>
    /// <param name="value">单位为立方英尺的值</param>
    /// <returns>单位为立方毫米的值</returns>
    [DebuggerStepThrough]
    public static double CubicFeetToCubicMillimeters(this int value) => CubicFeetToCubicMillimeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (立方英尺) 转为 (立方毫米)
    /// <para>Convert cubic feet to cubic millimeters</para>
    /// </summary>
    /// <param name="value">单位为立方英尺的值</param>
    /// <returns>单位为立方毫米的值</returns>
    [DebuggerStepThrough]
    public static double CubicFeetToCubicMillimeters(this float value) => CubicFeetToCubicMillimeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (立方英尺) 转为 (立方厘米)
    /// <para>Convert cubic feet to cubic centimeters</para>
    /// </summary>
    /// <param name="doubleValue">单位为立方英尺的值</param>
    /// <returns>单位为立方厘米的值</returns>
    [DebuggerStepThrough]
    public static double CubicFeetToCubicCentimeters(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_CUBIC_FEET, DisplayUnitType.DUT_CUBIC_CENTIMETERS);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.CubicFeet, UnitTypeId.CubicCentimeters);
#endif
    }

    /// <summary>
    /// 将值的单位从 (立方英尺) 转为 (立方厘米)
    /// <para>Convert cubic feet to cubic centimeters</para>
    /// </summary>
    /// <param name="value">单位为立方英尺的值</param>
    /// <returns>单位为立方厘米的值</returns>
    [DebuggerStepThrough]
    public static double CubicFeetToCubicCentimeters(this int value) => CubicFeetToCubicCentimeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (立方英尺) 转为 (立方厘米)
    /// <para>Convert cubic feet to cubic centimeters</para>
    /// </summary>
    /// <param name="value">单位为立方英尺的值</param>
    /// <returns>单位为立方厘米的值</returns>
    [DebuggerStepThrough]
    public static double CubicFeetToCubicCentimeters(this float value) => CubicFeetToCubicCentimeters(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (立方米) 转为 (立方英尺)
    /// <para>Convert cubic meters to cubic feet</para>
    /// </summary>
    /// <param name="doubleValue">单位为立方米的值</param>
    /// <returns>单位为立方英尺的值</returns>
    [DebuggerStepThrough]
    public static double CubicMetersToCubicFeet(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_CUBIC_METERS, DisplayUnitType.DUT_CUBIC_FEET);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.CubicMeters, UnitTypeId.CubicFeet);
#endif
    }

    /// <summary>
    /// 将值的单位从 (立方米) 转为 (立方英尺)
    /// <para>Convert cubic meters to cubic feet</para>
    /// </summary>
    /// <param name="value">单位为立方米的值</param>
    /// <returns>单位为立方英尺的值</returns>
    [DebuggerStepThrough]
    public static double CubicMetersToCubicFeet(this int value) => CubicMetersToCubicFeet(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (立方米) 转为 (立方英尺)
    /// <para>Convert cubic meters to cubic feet</para>
    /// </summary>
    /// <param name="value">单位为立方米的值</param>
    /// <returns>单位为立方英尺的值</returns>
    [DebuggerStepThrough]
    public static double CubicMetersToCubicFeet(this float value) => CubicMetersToCubicFeet(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (立方毫米) 转为 (立方英尺)
    /// <para>Convert cubic millimeters to cubic feet</para>
    /// </summary>
    /// <param name="doubleValue">单位为立方毫米的值</param>
    /// <returns>单位为立方英尺的值</returns>
    [DebuggerStepThrough]
    public static double CubicMillimetersToCubicFeet(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_CUBIC_MILLIMETERS, DisplayUnitType.DUT_CUBIC_FEET);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.CubicMillimeters, UnitTypeId.CubicFeet);
#endif
    }

    /// <summary>
    /// 将值的单位从 (立方毫米) 转为 (立方英尺)
    /// <para>Convert cubic millimeters to cubic feet</para>
    /// </summary>
    /// <param name="value">单位为立方毫米的值</param>
    /// <returns>单位为立方英尺的值</returns>
    [DebuggerStepThrough]
    public static double CubicMillimetersToCubicFeet(this int value) => CubicMillimetersToCubicFeet(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (立方毫米) 转为 (立方英尺)
    /// <para>Convert cubic millimeters to cubic feet</para>
    /// </summary>
    /// <param name="value">单位为立方毫米的值</param>
    /// <returns>单位为立方英尺的值</returns>
    [DebuggerStepThrough]
    public static double CubicMillimetersToCubicFeet(this float value) => CubicMillimetersToCubicFeet(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (立方厘米) 转为 (立方英尺)
    /// <para>Convert cubic centimeters to cubic feet</para>
    /// </summary>
    /// <param name="doubleValue">单位为立方厘米的值</param>
    /// <returns>单位为立方英尺的值</returns>
    [DebuggerStepThrough]
    public static double CubicCentimetersToCubicFeet(this double doubleValue)
    {
#if Rvt_16 || Rvt_17 || Rvt_18 || Rvt_19 || Rvt_20
        return UnitUtils.Convert(doubleValue, DisplayUnitType.DUT_CUBIC_CENTIMETERS, DisplayUnitType.DUT_CUBIC_FEET);
#else
        return UnitUtils.Convert(doubleValue, UnitTypeId.CubicCentimeters, UnitTypeId.CubicFeet);
#endif
    }

    /// <summary>
    /// 将值的单位从 (立方厘米) 转为 (立方英尺)
    /// <para>Convert cubic centimeters to cubic feet</para>
    /// </summary>
    /// <param name="value">单位为立方厘米的值</param>
    /// <returns>单位为立方英尺的值</returns>
    [DebuggerStepThrough]
    public static double CubicCentimetersToCubicFeet(this int value) => CubicCentimetersToCubicFeet(doubleValue: value);

    /// <summary>
    /// 将值的单位从 (立方厘米) 转为 (立方英尺)
    /// <para>Convert cubic centimeters to cubic feet</para>
    /// </summary>
    /// <param name="value">单位为立方厘米的值</param>
    /// <returns>单位为立方英尺的值</returns>
    [DebuggerStepThrough]
    public static double CubicCentimetersToCubicFeet(this float value) => CubicCentimetersToCubicFeet(doubleValue: value);
}
