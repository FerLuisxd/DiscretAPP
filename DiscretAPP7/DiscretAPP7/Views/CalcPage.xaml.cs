
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
    public partial class CalcPage : ContentPage
    {

        int numeroDeNotas;
        Entry[] Notas = new Entry[100];
        Label[] Textos = new Label[100];
        Entry[] Porcentajes = new Entry[100];
        public CalcPage()
        {

            numeroDeNotas = 1;
            InitializeComponent();

        }
        void AgregarNuevo()
        {
            var grid = this.FindByName<Grid>("Contend");

            Keyboard o = Keyboard.Numeric;
            Label tx = new Label { FontSize = 18, FontFamily = "{StaticResource BoldFont}", Text = "Nota " + (numeroDeNotas + 1) };
            grid.Children.Add(tx, 0, numeroDeNotas);
            Textos[numeroDeNotas] = tx;
            Entry x = new Entry { Keyboard = o, FontSize = 18, FontFamily = "{StaticResource BoldFont}" };
            grid.Children.Add(x, 1, numeroDeNotas);
            Notas[numeroDeNotas] = x;
            Entry y = new Entry { Keyboard = o, FontFamily = "{StaticResource BoldFont}" };
            grid.Children.Add(y, 2, numeroDeNotas);
            Porcentajes[numeroDeNotas] = y;

            numeroDeNotas++;
        }
        void EliminarUltimo()
        {
            if (numeroDeNotas > 1)
            {

                var grid = this.FindByName<Grid>("Contend");
                grid.Children.Remove(Notas[numeroDeNotas - 1]);
                grid.Children.Remove(Porcentajes[numeroDeNotas - 1]);
                grid.Children.Remove(Textos[numeroDeNotas - 1]);
                numeroDeNotas--;
            }
        }
        void Calculadora()
        {
            double sumaPorc = 0;
            double notaF = 0, numero, porcentaje;
            if (!string.IsNullOrEmpty(this.FindByName<Entry>("N1").Text) && !string.IsNullOrEmpty(this.FindByName<Entry>("P1").Text))
            {
                notaF = double.Parse(this.FindByName<Entry>("N1").Text) * (double.Parse(this.FindByName<Entry>("P1").Text) / 100);
                sumaPorc = double.Parse(this.FindByName<Entry>("P1").Text);
            }
            var lb = this.FindByName<Label>("Nota");
            for (int i = 1; i < numeroDeNotas; i++)
            {
                numero = 0;
                porcentaje = 0;
                if (!string.IsNullOrEmpty((Notas[i]).Text))
                {
                    numero = double.Parse((Notas[i]).Text);
                    if (numero < 0 || numero > 20)
                    {
                        Application.Current.MainPage.DisplayAlert("Error", "Las notas deben ser números entre 0 y 20", "Aceptar");
                        return;
                    }
                }
                if (!string.IsNullOrEmpty(Porcentajes[i].Text))
                {
                    porcentaje = double.Parse((Porcentajes[i]).Text);
                    sumaPorc += porcentaje;
                }
                notaF += numero * (porcentaje / 100);
                if (sumaPorc > 100)
                {
                    Application.Current.MainPage.DisplayAlert("Error", "Porcentaje es mayor a 100%", "Aceptar");



                    return;
                }
            }
            lb.Text = notaF.ToString();
        }

    }
}