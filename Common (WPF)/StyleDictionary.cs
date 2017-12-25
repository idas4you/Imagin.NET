﻿using Imagin.Common.Linq;
using System;
using System.Windows;

namespace Imagin.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class StyleDictionary : ResourceDictionary
    {
        string assembly = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string Assembly
        {
            get
            {
                return assembly;
            }
            set
            {
                assembly = value;
                OnAssemblyChanged(assembly);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public StyleDictionary() : base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        protected virtual void OnAssemblyChanged(string Value)
        {
            Source = new Uri("pack://application:,,,/{0};component/Styles/Generic.xaml".F(Value), UriKind.Absolute);
        }
    }
}
