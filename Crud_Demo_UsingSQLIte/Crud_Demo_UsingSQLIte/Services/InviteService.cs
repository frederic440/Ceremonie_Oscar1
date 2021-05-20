using Crud_Demo_UsingSQLIte;
using Crud_Demo_UsingSQLIte.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.WindowsAzure.MobileServices;
//using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
//using Microsoft.WindowsAzure.MobileServices.Sync;
//using Plugin.Connectivity;
//using System.Diagnostics;
//using Xamarin.Forms;
//using System.Collections;


namespace Crud_Demo_UsingSQLIte.Services
{
    /// <summary>
    /// Les méthodes du CRUD
    /// </summary>
    class InviteService
    {
       
        private DatabaseContext getContext()
        {
            return new DatabaseContext();
        }

        public async Task<List<InviteModel>> GetLesInvite()
        {
            var _dbcontext = getContext();
            var res = await _dbcontext.Invite.ToListAsync();
            return res;
        }

        public async Task<int> UpdateInvite(InviteModel obj)
        {
            var _dbContext = getContext();
            _dbContext.Invite.Update(obj);
            int c = await _dbContext.SaveChangesAsync();
            return c;
        }

        public int InsertInvite(InviteModel obj)
        {
            var _dbContext = getContext();
            _dbContext.Invite.Add(obj);
            int c = _dbContext.SaveChanges();
            return c;
        }

        public int DeleteInvite(InviteModel obj)
        {
            var _dbContext = getContext();
            _dbContext.Invite.Remove(obj);
            int c = _dbContext.SaveChanges();
            return c;
        }

    }


    /// Les blocs ci-dessous commenté sont les méthodes permetant l'éxécution des actios (CRUD) sur le serveur Azure 
    /// 


    //MobileServiceClient client = null;
    //IMobileServiceSyncTable<InviteModel> inviteTable;
    //public async Task Intialize()
    //{
    //    if (client?.SyncContext?.IsInitialized ?? false)
    //        return;


    //    var appUrl = "https://ENTER-APP-SERVICE-NAME.azurewebsites.net";

    //    //Create our client
    //    client = new MobileServiceClient("https://Invite.azurewebsites.net");

    //    const string path = "Invite.db";
    //    //setup our local sqlite store and intialize our table
    //    var store = new MobileServiceSQLiteStore(path);
    //    store.DefineTable<InviteModel>();
    //    await client.SyncContext.InitializeAsync(store, new MobileServiceSyncHandler());

    //    //Get our sync table that will call out to azure
    //    inviteTable = client.GetSyncTable<InviteModel>();
    //}
    //public async Task SyncInvite()
    //{
    //    try
    //    {
    //        if (!CrossConnectivity.Current.IsConnected)
    //            return;

    //        await inviteTable.PullAsync("allInvite", inviteTable.CreateQuery());

    //        await client.SyncContext.PushAsync();
    //    }
    //    catch (Exception ex)
    //    {
    //        Debug.WriteLine("Impossible de synchroniser les invités, ce n'est pas grave car nous avons des capacités hors ligne: " + ex);
    //    }


       
        //##################### Methode Serveur ####################
        //public async Task<IEnumerable> GetlesInvite()
        //{
        //    await SyncInvite();
        //    return await inviteTable.ToListAsync();
        //}

        
        //##################### Methode Serveur ####################
        //public async Task<InviteModel> MAJInvite(InviteModel obj)
        //{
        //    //create and insert coffee
        //    var unInvite = new InviteModel
        //    {

        //    };
        //    //{
        //    //    DateUtc = DateTime.UtcNow,
        //    //    MadeAtHome = madeAtHome
        //    //};

        //    await inviteTable.UpdateAsync(obj);

        //    //Synchronize coffee
        //    await SyncInvite();
        //    return obj;
        //}



       
        //##################### Methode Serveur ####################
        //public async Task<InviteModel> AddInvite(InviteModel obj)
        //{
        //    //create and insert coffee
           

        //    await inviteTable.InsertAsync(obj);

        //    //Synchronize coffee
        //    await SyncInvite();
        //    return obj;
        //}

        
        ////##################### Methode Serveur ####################
        //public async Task<InviteModel> DeleteInvite(InviteModel obj)
        //{
        //    //delete Invite
          
        //    await inviteTable.DeleteAsync(obj);

        //    //Synchronize coffee
        //    await SyncInvite();
        //    return obj;
        //}

    
}