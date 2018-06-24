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
            double P1;
            double P2;
            double P3;
            double P4;
            double P5;
            double P6;
            double notaF;
            var n1 = this.FindByName<Entry>("N1");


            var n2 = this.FindByName<Entry>("N2");


            var n3 = this.FindByName<Entry>("N3");


            var n4 = this.FindByName<Entry>("N4");


            var n5 = this.FindByName<Entry>("N5");


            var n6 = this.FindByName<Entry>("N6");

            var p1 = this.FindByName<Entry>("P1");
            var p2 = this.FindByName<Entry>("P2");
            var p3 = this.FindByName<Entry>("P3");
            var p4 = this.FindByName<Entry>("P4");
            var p5 = this.FindByName<Entry>("P5");
            var p6 = this.FindByName<Entry>("P6");


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
                P1 = 0;
                P2 = 0;
                P3 = 0;
                P4 = 0;
                P5 = 0;
                P6 = 0;
                if (!string.IsNullOrEmpty(n1.Text)) { N1 = double.Parse(n1.Text); }
                if (!string.IsNullOrEmpty(n2.Text)) { N2 = double.Parse(n2.Text); }
                if (!string.IsNullOrEmpty(n3.Text)) { N3 = double.Parse(n3.Text); }
                if (!string.IsNullOrEmpty(n4.Text)) { N4 = double.Parse(n4.Text); }
                if (!string.IsNullOrEmpty(n5.Text)) { N5 = double.Parse(n5.Text); }
                if (!string.IsNullOrEmpty(n6.Text)) { N6 = double.Parse(n6.Text); }
                if (!string.IsNullOrEmpty(p1.Text)) { P1 = double.Parse(p1.Text); }
                if (!string.IsNullOrEmpty(p2.Text)) { P2 = double.Parse(p2.Text); }
                if (!string.IsNullOrEmpty(p3.Text)) { P3 = double.Parse(p3.Text); }
                if (!string.IsNullOrEmpty(p4.Text)) { P4 = double.Parse(p4.Text); }
                if (!string.IsNullOrEmpty(p5.Text)) { P5 = double.Parse(p5.Text); }
                if (!string.IsNullOrEmpty(p6.Text)) { P6 = double.Parse(p6.Text); }

                N1 = N1 * (P1 / 100);
                N2 = N2 * (P2 / 100);
                N3 = N3 * (P3 / 100);
                N4 = N4 * (P4 / 100);
                N5 = N5 * (P5 / 100);
                N6 = N6 * (P6 / 100);
                notaF = N1 + N2 + N3 + N4 + N5 + N6;
                lb.Text = notaF.ToString();
            }
        }
    }
}