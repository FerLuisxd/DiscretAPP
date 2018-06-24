using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiscretAPP7.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InicioPage : ContentPage
	{
		public InicioPage ()
		{
			InitializeComponent ();
		}
        protected void DisPage(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new DisPage());
        }
        private void Acercade(object o, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PopUpView(2));
        }

    }
}