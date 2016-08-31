﻿using Imagin.Common;
using System;
using System.Timers;

namespace Imagin.Common
{
    [Serializable]
    ///<summary>
    /// An object with a date that periodically notifies.
    /// </summary>
    public class NamedEntry : Entry, INamable
    {
        #region Properties

        string name = string.Empty;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        #endregion

        #region Methods
        
        public override string ToString()
        {
            return this.Name;
        }

        #endregion

        #region NamedEntry

        public NamedEntry() : base()
        {
        }

        public NamedEntry(string Name, int NotifyEvery = 1000) : base(NotifyEvery)
        {
            this.Name = Name;
        }

        public NamedEntry(string Name, DateTime Date, int NotifyEvery = 1000) : base(Date, NotifyEvery)
        {
            this.Name = Name;
        }

        public NamedEntry(DateTime Date, int NotifyEvery = 1000) : base(Date, NotifyEvery)
        {
        }
        #endregion
    }
}
