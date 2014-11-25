using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Mic.Trash.Domain;
using Mic.Trash.RepositoryInterfaces;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Mic.Trash.Data
{
  

    public partial class TrashDataContext : IdentityDbContext<ApplicationUser>
    {

        public TrashDataContext() 
            : base("DefaultConnection", false)
        {
            Configuration.LazyLoadingEnabled = false;
        }


        public TrashDataContext(string connectionString)
            : base(connectionString, throwIfV1Schema: false)
        {
            Configuration.LazyLoadingEnabled = false;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            
        }

    }
}