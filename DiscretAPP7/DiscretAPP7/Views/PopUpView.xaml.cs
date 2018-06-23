using DiscretAPP7.Extensions;
using Rg.Plugins.Popup.Services;
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
	public partial class PopUpView 
	{

        int tipo, numero, max;
        double currentScale = 1;
        double startScale = 1;
        double xOffset = 0;
        double yOffset = 0;
        public PopUpView (int t)
		{
			InitializeComponent ();
       
            if (t == 1) { tag.Source = "pc1"; max = 2; }
            else { tag.Source = "silabo"; max = 4; }
            tipo = t;
            numero = 1;
		}

        void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
        {
            if (e.Status == GestureStatus.Started)
            {
                startScale = Content.Scale;
                Content.AnchorX = 0;
                Content.AnchorY = 0;
            }
            if (e.Status == GestureStatus.Running)
            {
                currentScale += (e.Scale - 1) * startScale;
                currentScale = Math.Max(1, currentScale);

                double renderedX = Content.X + xOffset;
                double deltaX = renderedX / Width;
                double deltaWidth = Width / (Content.Width * startScale);
                double originX = (e.ScaleOrigin.X - deltaX) * deltaWidth;

                double renderedY = Content.Y + yOffset;
                double deltaY = renderedY / Height;
                double deltaHeight = Height / (Content.Height * startScale);
                double originY = (e.ScaleOrigin.Y - deltaY) * deltaHeight;

                double targetX = xOffset - (originX * Content.Width) * (currentScale - startScale);
                double targetY = yOffset - (originY * Content.Height) * (currentScale - startScale);

                Content.TranslationX = targetX.Clamp(-Content.Width * (currentScale - 1), 0);
                Content.TranslationY = targetY.Clamp(-Content.Height * (currentScale - 1), 0);


                Content.Scale = currentScale;
            }
            if (e.Status == GestureStatus.Completed)
            {
                xOffset = Content.TranslationX;
                yOffset = Content.TranslationY;
            }
        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (numero - 1 >= 1) numero--;
            else return;
            if (tipo == 1)
            {
                if(numero==1) tag.Source = "pc1";
                else tag.Source = "pc2";
            }
            else {
                if(numero==1) tag.Source = "silabo";
                else if(numero==2) tag.Source = "silabo2";
                else if (numero == 3) tag.Source = "silabo3";
                else tag.Source = "silabo4";


            }


        }
        private void Button_Clicked_2(object sender, EventArgs e)
        {
            if (numero + 1 <= max) numero++;
            else return;
            if (tipo == 1)
            {
                if (numero == 1) tag.Source = "pc1";
                else tag.Source = "pc2";
            }
            else
            {
                if (numero == 1) tag.Source = "silabo";
                else if (numero == 2) tag.Source = "silabo2";
                else if (numero == 3) tag.Source = "silabo3";
                else tag.Source = "silabo4";


            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
        }
    }
}