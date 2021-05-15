using Crud_Demo_UsingSQLIte.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Crud_Demo_UsingSQLIte
{
    public class DatabaseContext : DbContext
    {
        public DbSet<InviteModel> Invite { get; set; }
        public DatabaseContext()
        {
            this.Database.EnsureCreated();
        }
        // overrides the OnConfigure Method 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Invite.db");
            optionsBuilder.UseSqlite($"Filename={dbPath}");

            
        }
        
    }
}