using System;
using System.Collections.Generic;
using System.Text;

namespace DiscretAPP7.ViewModels
{
    using ViewModels;
    using Views;
    using Xamarin.Forms;
    using System.Windows.Input;
    public class LoginViewModel : BaseViewModel
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        private string _Option;
        public string Option
        {
            get { return this._Option; }
            set { SetValue(ref this._Option, value); }
        }
        public ICommand LoginCommand
        {
            // set { return new RelayCommand(Login); }
            set;
            get;
        }
        public bool IsRunning
        {
            get;
            set;
        }
        public bool IsRemebered
        {
            get;
            set;
        }
        public bool IsEnabled
        {
            get;
            set;
        }
        async void Login()
        {
            if (string.IsNullOrEmpty(this.Option))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Elije una sección", "Aceptar");
                return;
            }
            //this.Option = string.Empty;
            this.IsRunning = false;
            this.IsEnabled = true;
            //var mainViewModel = MainViewModel.GetInstance();
            //mainViewModel.App = new AppViewModel();
            MainViewModel.setString(_Option);

            //this.Option = string.Empty;
            // MainViewModel.GetInstance().dis = new DisViewModel();

            await Application.Current.MainPage.Navigation.PushAsync(new DisPage());

        }
        public LoginViewModel()
        {
            this.IsRemebered = true;
            this.IsEnabled = true;
        }

    }
}
