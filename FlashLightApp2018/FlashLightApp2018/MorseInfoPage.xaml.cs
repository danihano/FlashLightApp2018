using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private void TestBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}