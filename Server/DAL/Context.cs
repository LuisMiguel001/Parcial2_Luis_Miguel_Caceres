using Microsoft.EntityFrameworkCore;
using Parcial2_Luis_Miguel_Caceres.Shared;
using Parcial2_Luis_Miguel_Caceres.Shared.Models;

namespace Parcial2_Luis_Miguel_Caceres.Server.DAL;

public class Context : DbContext
{
	public Context(DbContextOptions<Context> options)
		: base(options) { }

	public DbSet<Entradas> Entradas { get; set; }
	public DbSet<Productos> Productos { get; set; }
	public DbSet<EntradasDetalle> EntradasDetalle { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<Productos>().HasData(new List<Productos>()
		{
			new Productos(){Tipo=1, Descripcion="Maní", Existencia = 50, CantidadUtilizada = 5},
			new Productos(){Tipo=2, Descripcion="Pistachos",  Existencia = 600, CantidadUtilizada = 5},
			new Productos(){Tipo=3, Descripcion="Pasas", Existencia = 500, CantidadUtilizada = 5},
			new Productos(){Tipo=4, Descripcion="Ciruelas",  Existencia = 700, CantidadUtilizada = 5},
			new Productos(){Tipo=5, Descripcion="MPP0.5lb",  Existencia = 0, CantidadUtilizada = 0},
			new Productos(){Tipo=6, Descripcion="MPC0.5lb",  Existencia = 0, CantidadUtilizada = 0},
			new Productos(){Tipo=7, Descripcion="MPP0.2lb",  Existencia = 0, CantidadUtilizada = 0}
		});;
	}
}


