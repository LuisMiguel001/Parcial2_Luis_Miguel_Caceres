using Microsoft.EntityFrameworkCore;
using Parcial2_Luis_Miguel_Caceres.Shared;

namespace Parcial2_Luis_Miguel_Caceres.Server.DAL
{
	public class Context : DbContext
	{
		public Context(DbContextOptions<Context> options)
			: base(options) { }

		public DbSet<Entradas> Entradas { get; set; }
	}
}

