using System;
using System.Collections.Generic;
using System.Text;

namespace DiscretAPP7.Infrastructure
{
    using ViewModels;
    public class InstanceLocator
    {
        #region Propieties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion

    }
}
