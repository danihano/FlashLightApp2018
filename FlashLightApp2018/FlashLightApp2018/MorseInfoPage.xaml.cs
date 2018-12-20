using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlashLightApp2018
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MorseInfoPage : ContentPage
	{
        public MorseInfoPage()
        {
            InitializeComponent();
            image1();
            image2();
            image3();

        }

        private void image1()
        {
            var assembly = typeof(MorseInfoPage);
            string FileName = "FlashLightApp2018.Assets.Images.Title.png";
            Title.Source = ImageSource.FromResource(FileName, assembly);
        }

        private void image2()
        {
            var assembly = typeof(MorseInfoPage);
            string FileName = "FlashLightApp2018.Assets.Images.mrMorse.jpg";
            mrMorse.Source = ImageSource.FromResource(FileName, assembly);
        }

        private void image3()
        {
            var assembly = typeof(MorseInfoPage);
            string FileName = "FlashLightApp2018.Assets.Images.morseAlphabet.jpg";
            morseAlphabet.Source = ImageSource.FromResource(FileName, assembly);
        }
    }
}