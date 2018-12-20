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
		public MorseInfoPage ()
		{
			InitializeComponent ();
		}

        private async void TestBtn_Pressed(object sender, EventArgs e)
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