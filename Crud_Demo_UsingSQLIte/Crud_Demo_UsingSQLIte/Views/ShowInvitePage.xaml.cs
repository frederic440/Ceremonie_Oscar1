using Crud_Demo_UsingSQLIte.Services;
using Crud_Demo_UsingSQLIte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Crud_Demo_UsingSQLIte.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowInvitePage : ContentPage
    {
        InviteService services;
        public ShowInvitePage()
        {
            InitializeComponent();
            services = new InviteService();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ShowInvite();
        }
        private void ShowInvite()
        {
            var res = services.GetLesInvite().Result;
            lstData.ItemsSource = res;
        }

        private void BtnAjoutInvite_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new AddInvite());
        }
        private async void LstData_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                InviteModel obj = (InviteModel)e.SelectedItem;
                string res = await DisplayActionSheet("Opération", "Quitter", null, "Mettre à jour", "Supprimer");

                switch (res)
                {
                    case "Mettre à jour":
                        await Navigation.PushAsync(new AddInvite(obj));
                        break;
                    case "Supprimer":
                        services.DeleteInvite(obj);
                        ShowInvite();
                        break;
                }
                lstData.SelectedItem = null;
            }
        }
    }
}