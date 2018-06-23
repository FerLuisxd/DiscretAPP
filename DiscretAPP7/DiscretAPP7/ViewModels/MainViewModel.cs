using System;
using System.Collections.Generic;
using System.Text;

namespace DiscretAPP7.ViewModels
{
    public class MainViewModel
    {
        public LoginViewModel Login
        {
            get;
            set;
        }
     //  public DisViewModel dis
     //  {
     //      get;
     //      set;
     //  }
     //  public AnunciosBaseViewModel anu
     //  {
     //      get;
     //      set;
     //  }
        private static MainViewModel instance;
        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Singleton

        public static MainViewModel GetInstance()
        {
            if (instance == null)
                return new MainViewModel();
            return instance;
        }
        #endregion
        public static string secc;
        public static string getString()
        {
            return secc;
        }
        public static void setString(string a)
        {
            secc = a;
        }
    }
}
