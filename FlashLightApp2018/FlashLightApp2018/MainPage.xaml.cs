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
                //dot
                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();
                //end dot

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                //dash
                await Flashlight.TurnOnAsync();
                await Task.Delay(750);
                await Flashlight.TurnOffAsync();
                //end dash

                await Flashlight.TurnOnAsync();
                await Task.Delay(750);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(750);
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);
                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();
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
