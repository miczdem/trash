using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mic.Trash.Domain;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Mic.Trash.RepositoryInterfaces
{
    public interface ITrashDataContext
    {
        IdentityDbContext<ApplicationUser> IdentityContext { get; }
        DbContext Context { get; } 
        IDbSet<Article> Articles { get; set; }

    }
}
