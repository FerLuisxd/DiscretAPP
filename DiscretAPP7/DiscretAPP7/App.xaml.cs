using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Push;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace DiscretAPP7
{
    using Views;
	public partial class App : Application
	{
        public App()
        {
            InitializeComponent();
            AppCenter.Start("4008dcae-02a6-4771-bebe-5dbdcab8c65d", typeof(Push));
            NavigationPage nav;
            nav = new NavigationPage(new LoginPage());
            string a = Infrastructure.Settings.LastUsedSec;
            if (a != "") {
                if (a != string.Empty) {
                    if (!string.IsNullOrWhiteSpace(a))
                    { nav = new NavigationPage(new InicioPage()); } } }
            nav.BarBackgroundColor = Color.Brown;
            MainPage = nav;
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
