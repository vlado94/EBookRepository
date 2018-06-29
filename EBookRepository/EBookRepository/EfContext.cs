using EBookRepository.Models;
using System.Data.Entity;
using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;

namespace EBookRepository
{
    public class EfContext : DbContext
    {
        public EfContext() : base("name = EfContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EfContext, EBookRepository.Migrations.Configuration>("EfContext"));
            // Turns On logging of SQL on console for selected instance of the Context
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

            //this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<EBook> EBooks { get; set; }
    }
}