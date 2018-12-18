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
        }

        private async void OnBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Turn on
                await Flashlight.TurnOnAsync();
            }
            catch(FeatureNotSupportedException fnsEx)
            {
                //Handle not supported on device exception
            }
            catch(PermissionException pEx)
            {
                //Handle permission exception
            }
            catch(Exception ex)
            {
                //Unable to turn on/off flashlight
            }
        }

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

        private async void MorseBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MorsePage());
        }

        private void LightStr_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LightStrength());
        }
    }
}
