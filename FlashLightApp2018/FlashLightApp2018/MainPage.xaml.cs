using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace FlashLightApp2018
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            image1();
        }

        //Title Image
        private void image1()
        {
            var assembly = typeof(MainPage);
            string FileName = "FlashLightApp2018.Assets.Images.Title.png";
            Title.Source = ImageSource.FromResource(FileName, assembly);
        }

        //on button
        private async void OnBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Turn off
                await Flashlight.TurnOnAsync();
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                //Handle not supported on device exception
            }
            catch (PermissionException pEx)
            {
                //Handle permission exception
            }
            catch (Exception ex)
            {
                //Unable to turn on/off flashlight
            }
        }
    
        //off button
        private async void OffBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Turn off
                await Flashlight.TurnOffAsync();
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                //Handle not supported on device exception
            }
            catch (PermissionException pEx)
            {
                //Handle permission exception
            }
            catch (Exception ex)
            {
                //Unable to turn on/off flashlight
            }
        }

        //morse page  button
        private void MorseBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MorseCode());
        }

        private void InfoBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MorseInfoPage());
        }

        //private void LightStr_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new LightStrength());
        //}
    }
}
