using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SGallery.View.GalleryPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
