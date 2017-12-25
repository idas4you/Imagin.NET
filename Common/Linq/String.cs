﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Reflection;

namespace Imagin.Common.Linq
{
    /// <summary>
    /// 
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Get string after a.
        /// </summary>
        public static string After(this string value, string a)
        {
            var pos_a = value.LastIndexOf(a);

            if (pos_a == -1)
                return string.Empty;

            var adjusted = pos_a + a.Length;

            return adjusted >= value.Length ? string.Empty : value.Substring(adjusted);
        }

        /// <summary>
        /// Get string between a and b.
        /// </summary>
        public static string Between(this string value, string a, string b)
        {
            var pos_a = value.IndexOf(a);
            var pos_b = value.LastIndexOf(b);

            if (pos_a == -1)
                return string.Empty;

            if (pos_b == -1)
                return string.Empty;

            var adjusted = pos_a + a.Length;

            return adjusted >= pos_b ? string.Empty : value.Substring(adjusted, pos_b - adjusted);
        }

        /// <summary>
        /// Get string before a a.
        /// </summary>
        public static string Before(this string value, string a)
        {
            var pos_a = value.IndexOf(a);
            return pos_a == -1 ? string.Empty : value.Substring(0, pos_a);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Values"></param>
        /// <returns></returns>
        public static bool EndsWithAny(this string Value, params char[] Values)
        {
            return Value.EndsWithAny(Values.Select(i => i.ToString()).ToArray());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Values"></param>
        /// <returns></returns>
        public static bool EndsWithAny(this string Value, params object[] Values)
        {
            return Value.EndsWithAny(Values.Select(i => i.ToString()).ToArray());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Values"></param>
        /// <returns></returns>
        public static bool EndsWithAny(this string Value, params string[] Values)
        {
            foreach (var i in Values)
            {
                if (Value.EndsWith(i))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <param name="Args"></param>
        /// <returns></returns>
        public static string F(this string Format, params object[] Args)
        {
            return string.Format(Format, Args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <param name="Args"></param>
        /// <returns></returns>
        public static string Format(this string Format, params object[] Args)
        {
            return Format.F(Args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static bool IsAlphaNumeric(this string Value)
        {
            return Regex.IsMatch(Value, @"^[a-zA-Z0-9]+$");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ToCheck"></param>
        /// <returns></returns>
        public static bool IsDouble(this string ToCheck)
        {
            double n;
            return double.TryParse(ToCheck, out n);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ToEvaluate"></param>
        /// <returns></returns>
        public static bool IsEmpty(this string ToEvaluate)
        {
            return ToEvaluate.Length == 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ToCheck"></param>
        /// <returns></returns>
        public static bool IsInt(this string ToCheck)
        {
            int n;
            return int.TryParse(ToCheck, out n);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ToCheck"></param>
        /// <returns></returns>
        public static bool IsLong(this string ToCheck)
        {
            long n;
            return long.TryParse(ToCheck, out n);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ToEvaluate"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string ToEvaluate)
        {
            return string.IsNullOrEmpty(ToEvaluate);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ToEvaluate"></param>
        /// <returns></returns>
        public static bool IsNullOrWhiteSpace(this string ToEvaluate)
        {
            return string.IsNullOrWhiteSpace(ToEvaluate) || ToEvaluate.All(char.IsWhiteSpace);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ToCheck"></param>
        /// <returns></returns>
        public static bool IsShort(this string ToCheck)
        {
            short n;
            return short.TryParse(ToCheck, out n);
        }

        /// <summary>
        /// Parses <see cref="string"/> to <see cref="Enum"/>.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="Value"></param>
        /// <param name="IgnoreCase"></param>
        /// <returns></returns>
        public static TEnum ParseEnum<TEnum>(this string Value, bool IgnoreCase = true) where TEnum : struct, IFormattable, IComparable, IConvertible
        {
            return (TEnum)Enum.Parse(typeof(TEnum), Value, IgnoreCase);
        }

        /// <summary>
        /// Parses string to boolean.
        /// </summary>
        public static string SplitCamelCase(this string value)
        {
            return Regex.Replace(Regex.Replace(value, @"(\P{Ll})(\P{Ll}\p{Ll})", "$1 $2"), @"(\p{Ll})(\P{Ll})", "$1 $2");
        }

        /// <summary>
        /// Parses string to boolean (evaluates "true" and "false"; everything else is parsed to an int).
        /// </summary>
        public static bool? ToBool(this string value)
        {
            switch (value.ToLower())
            {
                case "true":
                case "t":
                case "1":
                    return true;
                case "false":
                case "f":
                case "0":
                    return false;
            }
            return null;
        }

        /// <summary>
        /// Parses string to byte.
        /// </summary>
        public static byte ToByte(this string value)
        {
            var result = default(byte);
            byte.TryParse(value, out result);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static char ToChar(this string value)
        {
            var result = default(char);
            char.TryParse(value, out result);
            return result;
        }

        /// <summary>
        /// Parses string to short.
        /// </summary>
        public static short ToInt16(this string value)
        {
            var result = default(short);
            short.TryParse(value, out result);
            return result;
        }

        /// <summary>
        /// Parses string to int.
        /// </summary>
        public static int ToInt32(this string value)
        {
            var result = default(int);
            int.TryParse(value, out result);
            return result;
        }

        /// <summary>
        /// Parses string to long.
        /// </summary>
        public static long ToInt64(this string value)
        {
            var result = default(long);
            long.TryParse(value, out result);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static IEnumerable<int> ToInt32Array(this string Value, char Separator = ',')
        {
            return Value.ToInt32Array(Separator as char?);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static IEnumerable<int> ToInt32Array(this string Value, char? Separator)
        {
            if (String.IsNullOrEmpty(Value))
                yield break;

            if (Separator == null)
            {
                foreach (var i in Value.ToArray())
                    yield return i.ToString().ToInt32();
            }
            else
            {
                foreach (var i in Value.Split(Separator.Value))
                    yield return i.ToInt32();
            }
        }

        /// <summary>
        /// Parses string to DateTime.
        /// </summary>
        public static DateTime ToDateTime(this string value)
        {
            var result = default(DateTime);
            DateTime.TryParse(value, out result);
            return result;
        }

        /// <summary>
        /// Parses string to decimal.
        /// </summary>
        public static decimal ToDecimal(this string value)
        {
            var result = default(decimal);
            decimal.TryParse(value, out result);
            return result;
        }

        /// <summary>
        /// Parses string to double.
        /// </summary>
        public static double ToDouble(this string value)
        {
            var result = default(double);
            double.TryParse(value, out result);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TimeSpan ToTimeSpan(this string value)
        {
            var result = default(TimeSpan);
            TimeSpan.TryParse(value, out result);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static ushort ToUInt16(this string Value)
        {
            var Result = default(ushort);
            ushort.TryParse(Value, out Result);
            return Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static uint ToUInt32(this string Value)
        {
            var Result = default(uint);
            uint.TryParse(Value, out Result);
            return Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static ulong ToUInt64(this string Value)
        {
            var Result = default(ulong);
            ulong.TryParse(Value, out Result);
            return Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="kind"></param>
        /// <returns></returns>
        public static Uri ToUri(this string value, UriKind kind = UriKind.RelativeOrAbsolute)
        {
            var result = default(Uri);
            Uri.TryCreate(value, kind, out result);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="raw"></param>
        /// <param name="Delimiter"></param>
        /// <returns></returns>
        public static Version ToVersion(this string raw, char Delimiter = '.')
        {
            int major = 0, minor = 0, build = 0;
            string[] tokens = raw.Split(Delimiter);
            if (tokens.Length > 0)
            {
                int.TryParse(tokens[0], out major);
                if (tokens.Length > 1)
                {
                    int.TryParse(tokens[1], out minor);
                    if (tokens.Length > 2)
                        int.TryParse(tokens[2], out build);
                }
            }
            return new Version(major, minor, build);
        }

        /// <summary>
        /// Attempts to parse <see cref="string"/> to <see cref="Enum"/>.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="OldValue"></param>
        /// <param name="NewValue"></param>
        /// <param name="IgnoreCase"></param>
        /// <returns></returns>
        public static bool TryParseEnum<TEnum>(this string OldValue, out TEnum NewValue, bool IgnoreCase = true) where TEnum : struct, IFormattable, IComparable, IConvertible
        {
            NewValue = default(TEnum);
            return Enum.TryParse(OldValue, IgnoreCase, out NewValue);
        }
    }
}
