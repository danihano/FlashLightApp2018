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

        ////ring morseData = string.Empty;
        ////ol exitLoop = false;
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

        private async void SosBtn_Clicked(object sender, EventArgs e) 
        {
            try
            {
                //dot
                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();
                //end dot

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Flashlight.TurnOffAsync();

                await Task.Delay(2500);

                //dash
                await Flashlight.TurnOnAsync();
                await Task.Delay(2500);
                await Flashlight.TurnOffAsync();
                //end dash

                await Flashlight.TurnOnAsync();
                await Task.Delay(2500);
                await Flashlight.TurnOffAsync();

                await Flashlight.TurnOnAsync();
                await Task.Delay(2500);
                await Flashlight.TurnOffAsync();

                await Task.Delay(2500);
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

        private async void WOWBtn_Clicked_1(object sender, EventArgs e)
        {
            try
            {
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

        private async void PoliceBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
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
    }
}