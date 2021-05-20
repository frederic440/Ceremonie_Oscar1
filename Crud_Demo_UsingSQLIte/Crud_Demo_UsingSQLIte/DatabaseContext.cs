using Crud_Demo_UsingSQLIte.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Data.SQLite;

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
        /// <summary>
        /// Connextion à la BDD
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Invite.db");
            optionsBuilder.UseSqlite($"Filename={dbPath}");

           
            Console.WriteLine("Voici la base de donnée : " + dbPath);
        }
       
    }
}