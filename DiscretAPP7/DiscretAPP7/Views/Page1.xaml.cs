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
        List<bool> seleccionados = new List<bool>();
		public Page1 ()
		{
			InitializeComponent ();
            Correos.ItemsSource = new List<String>
            {
                "Coordinadador del Área de Ciencias - José Cuevas",
                "Coordinador del Curso - Marcos Medina",
                "Luis Acosta",
                "Daniel Muñoz",
                "Raul Acosta",
                "Kenny Venegas",
                "Luis Iquise"
            };
            for (int i = 0; i < 7; i++)
                seleccionados.Add(false);
		}
       

        private void Boton_Enviar(object sender, EventArgs e)
        {
           
            for(int i =0; i< seleccionados.Count();i++)
            {
                if(seleccionados[i])
                {
                    
                     if(i == 0)
                       correosParaEnviar.Add("u201711590@upc.edu.pe");
                     else if(i==1)
                        correosParaEnviar.Add("u201711590@upc.edu.pe");
                     else if(i==2)
                        correosParaEnviar.Add("u201711590@upc.edu.pe");
                     else if(i==3)
                        correosParaEnviar.Add("u201711590@upc.edu.pe");
                     else if(i==4)
                        correosParaEnviar.Add("u201711590@upc.edu.pe");
                     else if(i==5)
                        correosParaEnviar.Add("u201711590@upc.edu.pe");
                     else
                        correosParaEnviar.Add("u201711590@upc.edu.pe");

                }
            }
            
            String texto = msj.Text;
            var email = CrossMessaging.Current.EmailMessenger;
            if (email.CanSendEmail)
            {
                for (int i = 0; i < correosParaEnviar.Count(); i++)
                    email.SendEmail(correosParaEnviar[i], "ALUMNO DESDE DISCRETAPP", texto);
            }
        }

        private void Correos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Label o = sender as Label;
            switch(o.Text){

                case "Coordinadador del Área de Ciencias - José Cuevas":
                    seleccionados[0] = seleccionados[0] ? false : true;
                     break;

                case "Coordinador del Curso - Marcos Medina":
                    seleccionados[1] = seleccionados[1] ? false : true;
                    break;

                case "Luis Acosta":

                    seleccionados[2] = seleccionados[2] ? false : true;
                    break;


                case "Daniel Muñoz":

                    seleccionados[3] = seleccionados[3] ? false : true;
                    break;
                case "Raul Acosta":

                    seleccionados[4] = seleccionados[4] ? false : true;
                    break;
                case "Kenny Venegas":

                    seleccionados[5] = seleccionados[5] ? false : true;
                    break;
                case "Luis Iquise":

                    seleccionados[6] = seleccionados[6] ? false : true;
                    break;
            }
         
        }
    }
}