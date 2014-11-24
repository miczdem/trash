 

using Mic.Trash.Domain;
using SSW.Data.Interfaces;

namespace Mic.Trash.RepositoryInterfaces
{
	public partial interface IArticleRepository : IRepository<Article>
	{
	}
    public partial interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
    }
}

