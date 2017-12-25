﻿using System;

namespace Imagin.Common
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class SearchableAttribute : Attribute
    {
        readonly bool isSearchable;
        /// <summary>
        /// 
        /// </summary>
        public bool IsSearchable
        {
            get
            {
                return isSearchable;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public SearchableAttribute() : this(true)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IsSearchable"></param>
        public SearchableAttribute(bool IsSearchable)
        {
            isSearchable = IsSearchable;
        }
    }
}
