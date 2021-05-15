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
    public partial class AddInvite : ContentPage
    {
        InviteService _services;
        bool _isUpdate;
        int invitesID;
        public AddInvite()
        {
            InitializeComponent();
            _services = new InviteService();
            _isUpdate = false;

        }
        public AddInvite(InviteModel obj)
        {
            InitializeComponent();
            _services = new InviteService();

            if (obj != null)
            {
                invitesID = obj.Id;
                txtNom.Text = obj.Nom;
                txtPrenom.Text = obj.Prenom;
                txtEmail.Text = obj.Email;
                txtAddress.Text = obj.Address;
                txtSiege.Text = obj.Siege;
                _isUpdate = true;
            }
        }

        private async void BtnSaveUpdate_ClickedAsync(object sender, EventArgs e)
        {
            InviteModel obj = new InviteModel();
            obj.Nom = txtNom.Text;
            obj.Prenom = txtPrenom.Text;
            obj.Email = txtEmail.Text;
            obj.Address = txtAddress.Text;
            obj.Siege = txtSiege.Text;
            if (_isUpdate)
            {
                obj.Id = invitesID;
                await _services.UpdateInvite(obj);
            }
            else
            {
                _services.InsertInvite(obj);
            }
            await this.Navigation.PopAsync();
        }
    }
}