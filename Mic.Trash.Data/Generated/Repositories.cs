 


using Mic.Trash.Domain;

using Mic.Trash.RepositoryInterfaces;
using SSW.Data.EF;

namespace Mic.Trash.Data
{
	public partial class ArticleRepository : SSW.Data.EF.BaseRepository<Article>, IArticleRepository
	{
		public ArticleRepository(IDbContextManager contextmanager)
			: base(contextmanager)
		{
		}
	}
}

