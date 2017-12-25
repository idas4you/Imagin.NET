﻿using Windows.UI.Xaml;

namespace Imagin.Common.Linq
{
    /// <summary>
    /// 
    /// </summary>
    public static class BooleanExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="FalseVisibility"></param>
        /// <returns></returns>
        public static Visibility ToVisibility(this bool Value, Visibility FalseVisibility = Visibility.Collapsed)
        {
            return Value ? Visibility.Visible : FalseVisibility;
        }
    }
}
