using Crud_Demo_UsingSQLIte.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Ceremonie_Oscar
{
    public partial class App : Application
    {
        public App()
        {
            //InitializeComponent();

            MainPage = new NavigationPage(new ShowInvitePage());
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