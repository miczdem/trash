using System.Data.Entity;
using Mic.Trash.Domain;
using Mic.Trash.RepositoryInterfaces;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Mic.Trash.Data
{
  

    public partial class TrashDataContext : IdentityDbContext<ApplicationUser>, ITrashDataContext
    {
        public TrashDataContext()
            : base("DefaultConnection", false)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public static TrashDataContext Create()
        {
            return new TrashDataContext();
        }

        public IdentityDbContext<ApplicationUser> IdentityContext { get { return this; } }
        public DbContext Context { get { return this; }  }


    }
}