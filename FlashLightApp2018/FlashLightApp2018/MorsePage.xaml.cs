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
	public partial class MorsePage : ContentPage
	{
		public MorsePage ()
		{
			InitializeComponent ();
		}
        
        private async void NewMorseBtn_Clicked(object sender, EventArgs e)
        {
            OBtn.IsEnabled = true;
            LBtn.IsEnabled = true;
            SBtn.IsEnabled = true;

            //File.WriteAllText(fileName, text);

        }

        private void OBtn_Clicked(object sender, EventArgs e)
        {
            
        }

        private void LBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void SBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void LoadMorseBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void PlayMorseBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}