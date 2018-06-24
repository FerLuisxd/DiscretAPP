using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiscretAPP7.Views
{
    using Infrastructure;
    using Microsoft.AppCenter;
    using ViewModels;
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
       
        Picker p;
        Switch s;
        public LoginPage()
        {

            InitializeComponent();
            var listData = new List<string>();
            listData.Add("SW33");
            listData.Add("SW55");
            listData.Add("SI32");
            listData.Add("CC21");
            p = this.FindByName<Picker>("picker");
            p.ItemsSource = listData;
            p.SelectedItem = Infrastructure.Settings.LastUsedSec;


            //if(Infrastructure.Settings.LastOption != string.Empty)
            //{
            //    s.IsEnabled = true;
            //}
            // if( Infrastructure.Settings.LastUsedSec != string.Empty)
            // {
            //     DoStuff();
            // }
        }
        void startUP() { }
        protected void Dis(object sender, EventArgs e)
        {
            string option = (string)p.SelectedItem;
            if (string.IsNullOrEmpty(option))
            {
                Application.Current.MainPage.DisplayAlert("Error", "Elije una sección", "Aceptar");
                return;
            }
            MainViewModel.setString(option);

            Infrastructure.Settings.LastUsedSec = option;
            //this.Option = string.Empty;
            // MainViewModel.GetInstance().dis = new DisViewModel();
            CustomProperties properties = new CustomProperties();
            properties.Set("Seccion", option);
            AppCenter.SetCustomProperties(properties);
            Application.Current.MainPage.Navigation.PushAsync(new InicioPage());
        }
        // void DoStuff()
        // {
        //     
        //     Application.Current.MainPage.Navigation.PushAsync(new DisPage());
        // }

    }
}