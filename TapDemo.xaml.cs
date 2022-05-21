using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab9Gestures
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TapDemo : ContentPage
    {
        int tapCount;
        readonly Label label;
        public TapDemo()
        {
            InitializeComponent();
            var image = new Image 
            { 
                Source ="fondo_hd.jpg",
                HorizontalOptions=LayoutOptions.Center,
                VerticalOptions=LayoutOptions.CenterAndExpand,

             };
            var tapGestureRecognizer =new TapGestureRecognizer();
            tapGestureRecognizer.NumberOfTapsRequired = 2;
            tapGestureRecognizer.Tapped += OnTapGestureRecognizerTapped;
            image.GestureRecognizers.Add(tapGestureRecognizer);

            label = new Label
            {
                Text = "tap the photo!!",
                FontSize=Device.GetNamedSize(NamedSize.Large,typeof(Label)),
                HorizontalOptions=LayoutOptions.Center,
                VerticalOptions=LayoutOptions.CenterAndExpand
            };
            Content = new StackLayout
            {
                Padding = new Thickness(20,100),
                Children=
                {
                    image,label
                }
            };
        }

        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            tapCount++; ;
            label.Text = String.Format("{0} tap{1} so far !!",
                tapCount,
                tapCount == 1 ? "" : "s");
            var imageSender = (Image)sender;

            //watch the image go from color to black& white
            if (tapCount % 2 == 0)
            {
                imageSender.Source = "fondo_hd.jpg";
            }
            else
            {
                imageSender.Source = "Fantasticascasas.jpg";
            }
            //throw new NotImplementedException();
        }
    }
}