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
	public partial class BuscarView : ContentPage
	{
        String[] Temas = { "CONJUNTOS","DIVISION DE LOS ENTEROS","MATRICES BOOLEANAS", "LOGICA PROPOSICIONAL", "CUANTIFICADORES","INDUCCION MATEMATICA",
        "ALGORITMOS","SUCESIONES","RELACIONES","RELACIONES DEFINICION", "RELACIONES PROPIEDADES","RELACIONES MANIPULACION","FUNCIONES","FUNCIONES DE PERMUTACION", "ESTUCTURAS DE ORDEN DIAGRAMA DE HASSE",
        "ESTRUCTUAS DE ORDEN ELEMENTOS EXTREMOS COTAS", "RETICULAS DEFINICION TIPOS","ALGEBRA DE BOOLE DEFINICION PROPIEDADES","CLASE INTEGRAL", "","", "EXAMENES PARCIALES", "PARCIALES PASADOS", "EA",
        "FUNCIONES BOOLEANAS","MAPA DE KARNAUGH","ARBOLES DIRIGIDOS","ARBOLES DIRIGIDOS","BUSQUEDA EN ARBOLES","ESPACIO EUCLIDIANO", "COMBINACION LINEAL", "BASE DE ESPACIO VECTORIAL","CAMBIO DE BASE", "PC2",
        "PRACTICA CALIFICADA 2", "TRANSFORMACIONES LINEALES", "NUCLEO TRANSFORMACION LINEAL", "IMAGEN TRANSFORMACION LINEAL", "AUTOVALORES Y AUTOVECTORES", "CADENA DE MARKOV", "MARKOV", "CLASE INTEGRADORA"        };
       
        Button[] Encontrados;
        int numerx;
        public BuscarView ()
		{
            numerx = 0;
            
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            for (int i = 0; i < 42; i++)
            {
                if (Temas[i] == Encontrados[numerx].Text)
                {
                    int j = i+1;
                    for (j = 1; j <= 3; j++)
                    {
                        if (j % 3 == 0) break;
                        j++;
                    }
                    Application.Current.MainPage.Navigation.PushAsync(new DisPage(j/3));
                }
            }
           
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            for (int i = 0; i < numerx; i++)
                micont.Children.Remove(Encontrados[numerx]);
            numerx = 0;

            String temBuscar = this.FindByName<Entry>("Bs").Text;
            for (int i = 0; i < 42; i++)
            {
                if (Temas[i].StartsWith(temBuscar))
                {
                    
                    Button nuevo = new Button { Text = Temas[i] };
                    nuevo.Clicked+= Button_Clicked;
                    Encontrados[numerx] = nuevo;
                    micont.Children.Add(Encontrados[numerx]);
                    numerx++;
                    
                }

            }
        }
    }
}