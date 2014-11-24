 

namespace Mic.Trash.Data
{
	using System.Data.Entity;
	
		using Mic.Trash.Domain;


	using SSW.Data.Entities;

	public partial class TrashDataContext
	{
		public IDbSet<Article> Articles { get; set; }

	}
}

