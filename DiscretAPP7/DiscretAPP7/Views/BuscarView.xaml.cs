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
        List<String> Temas;
        List<Button> Encontrados;
        public BuscarView()
        {
            Temas = new List<String>();
            Encontrados = new List<Button>();
            Temas.Add("CONJUNTOS");
            Temas.Add("DIVISION DE LOS ENTEROS");
            Temas.Add("MATRICES BOOLEANAS");
            Temas.Add("LOGICA PROPOSICIONAL");
            Temas.Add("CUANTIFICADORES");
            Temas.Add("ALGORITMOS");
            Temas.Add("SUCESIONES");
            Temas.Add("RELACIONES");
            Temas.Add("RELACIONES DEFINICION");
            Temas.Add("RELACIONES PROPIEDADES");
            Temas.Add("RELACIONES MANIPULACION");
            Temas.Add("FUNCIONES");
            Temas.Add("FUNCIONES DE PERMUTACION");
            Temas.Add("ESTUCTURAS DE ORDEN DIAGRAMA DE HASSE");
            Temas.Add("ESTRUCTUAS DE ORDEN ELEMENTOS EXTREMOS COTAS");
            Temas.Add("RETICULAS DEFINICION TIPOS");
            Temas.Add("ALGEBRA DE BOOLE DEFINICION PROPIEDADES");
            Temas.Add("CLASE INTEGRAL");
            Temas.Add("");
            Temas.Add("");
            Temas.Add("EXAMENES PARCIALES");
            Temas.Add("PARCIALES PASADOS");
            Temas.Add("EA");
            Temas.Add("FUNCIONES BOOLEANAS");
            Temas.Add("MAPA DE KARNAUGH");
            Temas.Add("ARBOLES DIRIGIDOS");
            Temas.Add("ARBOLES DIRIGIDOS");
            Temas.Add("BUSQUEDA EN ARBOLES");
            Temas.Add("ESPACIO EUCLIDIANO");
            Temas.Add("COMBINACION LINEAL");
            Temas.Add("BASE DE ESPACIO VECTORIAL");
            Temas.Add("CAMBIO DE BASE");
            Temas.Add("PC2");
            Temas.Add("PRACTICA CALIFICADA 2");
            Temas.Add("TRANSFORMACIONES LINEALES");
            Temas.Add("NUCLEO TRANSFORMACION LINEAL");
            Temas.Add("IMAGEN TRANSFORMACION LINEAL");
            Temas.Add("AUTOVALORES Y AUTOVECTORES");
            Temas.Add("CADENA DE MARKOV");
            Temas.Add("MARKOV");
            Temas.Add("CLASE INTEGRADORA");
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button o = sender as Button;
            String nombre = o.Text;
            nombre = nombre.ToUpper();
            for (int i = 0; i < Temas.Count(); i++)
                if (Temas[i] == nombre)
                    Application.Current.MainPage.Navigation.PushAsync(new DisPage(i + 1));

        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            for (int i = 0; i < Encontrados.Count(); i++)
                micont.Children.Remove(Encontrados[i]);

            String temBuscar = Bs.Text;
            temBuscar = temBuscar.ToUpper();
            for (int i = 0; i < Temas.Count(); i++)
            {
                if (Temas[i].StartsWith(temBuscar))
                {
                    if (Temas[i] != "")
                    {
                        Button nuevo = new Button
                        {
                            Text = Temas[i],
                            TextColor = Color.Black,
                            BackgroundColor = Color.Transparent
                        };
                        nuevo.Clicked += Button_Clicked;
                        Encontrados.Add(nuevo);
                        micont.Children.Add(nuevo);
                    }
                }

            }

        }
    }
}