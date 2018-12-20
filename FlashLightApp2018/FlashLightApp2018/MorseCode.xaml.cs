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

        //SOS Morse
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

        //Hello morse
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

        //Warning morse
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

        //WOW morse
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

        //LOL Morse
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

        //911 morse
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

        //Bye Morse
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

        //GMIT morse
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

//This is the code i tryed to set up the more complicated morsecode buttons where you creat your own code, but i didnt get it working
//bool exitLoop = false;
//public MorsePage()
//{
//    InitializeComponent();
//}

//private async void NewMorseBtn_Clicked(object sender, EventArgs e)
//{
//    bool isTextEmpty = String.IsNullOrEmpty(MorseName.Text);
//    if (isTextEmpty)
//    {

//    }
//    else
//    {
//        OBtn.IsEnabled = true;
//        LBtn.IsEnabled = true;
//        SBtn.IsEnabled = true;
//        EndBtn.IsEnabled = true;

//        // String morseName = MorseName.Text;

//        //String[,] morseSave = new String[100,100];

//    }
//    //File.WriteAllText(morseName, text);
//    //while (exitLoop != true)
//    //{

//    //}

//}

//private void LoadMorseBtn_Clicked(object sender, EventArgs e)
//{

//}

//private void PlayMorseBtn_Clicked(object sender, EventArgs e)
//{

//}

//private void OBtn_Clicked(object sender, EventArgs e)
//{
//    //rseData += ".";
//}

//private void LBtn_Clicked(object sender, EventArgs e)
//{
//   //rseData += "-";
//}

//private void SBtn_Clicked(object sender, EventArgs e)
//{
//  //morseData += "~";
//}

//private void EndBtn_Clicked(object sender, EventArgs e)
//{
// // morseData = "#";   
//}
//try
//{
//    //dot
//    await Flashlight.TurnOnAsync();
//    await Flashlight.TurnOffAsync();
//    //end dot

//    await Flashlight.TurnOnAsync();
//    await Flashlight.TurnOffAsync();

//    await Flashlight.TurnOnAsync();
//    await Flashlight.TurnOffAsync();

//    await Task.Delay(2500);

//    //dash
//    await Flashlight.TurnOnAsync();
//    await Task.Delay(2500);
//    await Flashlight.TurnOffAsync();
//    //end dash

//    await Flashlight.TurnOnAsync();
//    await Task.Delay(2500);
//    await Flashlight.TurnOffAsync();

//    await Flashlight.TurnOnAsync();
//    await Task.Delay(2500);
//    await Flashlight.TurnOffAsync();

//    await Task.Delay(2500);
//    await Flashlight.TurnOnAsync();
//    await Flashlight.TurnOffAsync();

//    await Flashlight.TurnOnAsync();
//    await Flashlight.TurnOffAsync();

//    await Flashlight.TurnOnAsync();
//    await Flashlight.TurnOffAsync();
//}
//catch (FeatureNotSupportedException fnsEx)
//{
//    //Handle not supported on device exception
//}
//catch (PermissionException pEx)
//{
//    //Handle permission exception
//}
//catch (Exception ex)
//{
//    //Unable to turn on/off flashlight
//}