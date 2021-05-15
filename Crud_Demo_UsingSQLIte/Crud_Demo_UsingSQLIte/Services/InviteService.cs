using Crud_Demo_UsingSQLIte;
using Crud_Demo_UsingSQLIte.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Demo_UsingSQLIte.Services
{
    public class InviteService
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
}