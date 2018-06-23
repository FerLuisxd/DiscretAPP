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
        public CalcPage()
        {
            InitializeComponent();
            Calculadora();
        }
        void Calculadora()
        {
            double N1;
            double N2;
            double N3;
            double N4;
            double N5;
            double N6;
            double notaF;
            var n1 = this.FindByName<Entry>("N1");


            var n2 = this.FindByName<Entry>("N2");


            var n3 = this.FindByName<Entry>("N3");


            var n4 = this.FindByName<Entry>("N4");


            var n5 = this.FindByName<Entry>("N5");


            var n6 = this.FindByName<Entry>("N6");


            var bt = this.FindByName<Button>("Calc");
            var lb = this.FindByName<Label>("Nota");
            bt.Clicked += cal;

            void cal(object sender, EventArgs e)
            {
                N1 = 0;
                N2 = 0;
                N3 = 0;
                N4 = 0;
                N5 = 0;
                N6 = 0;
                if (!string.IsNullOrEmpty(n1.Text)){ N1 = double.Parse(n1.Text); }
                if (!string.IsNullOrEmpty(n1.Text)){ N2 = double.Parse(n2.Text); }
                if (!string.IsNullOrEmpty(n1.Text)){ N3 = double.Parse(n3.Text); }
                if (!string.IsNullOrEmpty(n1.Text)){ N4 = double.Parse(n4.Text); }
                if (!string.IsNullOrEmpty(n1.Text)) { N5 = double.Parse(n5.Text); }
                if (!string.IsNullOrEmpty(n1.Text)) { N6 = double.Parse(n6.Text); }
                N1 = N1 * 0.1;
                N2 = N2 * 0.15;
                N3 = N3 * 0.1;
                N4 = N4 * 0.15;
                N5 = N5 * 0.2;
                N6 = N6 * 0.3;
                notaF = N1 + N2 + N3 + N4 + N5 + N6;
                lb.Text = notaF.ToString();
            }
        }
    }
}