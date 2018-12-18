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
        //bool exitLoop = false;
        public MorsePage()
        {
            InitializeComponent();
        }

        private async void NewMorseBtn_Clicked(object sender, EventArgs e)
        {
            bool isTextEmpty = String.IsNullOrEmpty(MorseName.Text);
            if (isTextEmpty)
            {

            }
            else
            {
                OBtn.IsEnabled = true;
                LBtn.IsEnabled = true;
                SBtn.IsEnabled = true;
                EndBtn.IsEnabled = true;

               // String morseName = MorseName.Text;

                //String[,] morseSave = new String[100,100];

            }
            //File.WriteAllText(morseName, text);
            //while (exitLoop != true)
            //{

            //}

        }

        private void LoadMorseBtn_Clicked(object sender, EventArgs e)
        {
           
        }

        private void PlayMorseBtn_Clicked(object sender, EventArgs e)
        {

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

        private void EndBtn_Clicked(object sender, EventArgs e)
        {

        }

    }
}