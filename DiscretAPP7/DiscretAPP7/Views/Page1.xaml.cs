using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Messaging;

namespace DiscretAPP7.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        List<String> correosParaEnviar = new List<String>();

		public Page1 ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            
            String texto = msj.Text;
            var email = CrossMessaging.Current.EmailMessenger;
            if (email.CanSendEmail)
            {
                for (int i = 0; i < correosParaEnviar.Count(); i++)
                    email.SendEmail(correosParaEnviar[i], "ALUMNO DESDE DISCRETAPP", texto);
            }
        }
    }
}