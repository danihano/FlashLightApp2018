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
	public partial class MorseCode : ContentPage
	{
		public MorseCode ()
		{
			InitializeComponent ();
		}

        private async void SOSBtn_Clicked(object sender, EventArgs e)
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
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();
                //end dash

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);
                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
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

        private async void HelloBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
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

        private async void WarningBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
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

        private async void WOWBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
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

        private async void LOLBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
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

        private async void EmergancyBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
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

        private async void ByeBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
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

        private async void GMITBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Task.Delay(650);

                await Flashlight.TurnOnAsync();
                await Task.Delay(700);
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
    }
}