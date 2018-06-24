using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        protected void Acercade(object sender, EventArgs e)
        {
            //Application.Current.MainPage.Navigation.PushAsync(new DisPage());
        }

    }
}