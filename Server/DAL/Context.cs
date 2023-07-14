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
	public DbSet<Frutos> Frutos { get; set; }	
	public DbSet<EntradasDetalle> EntradasDetalle { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<Frutos>().HasData(new List<Frutos>()
		{
			new Frutos(){FrutoId=1, Nombre="Maní", Disponibilidad = 50},
			new Frutos(){FrutoId=2, Nombre="Pistachos",  Disponibilidad = 600},
			new Frutos(){FrutoId=3, Nombre="Pasas", Disponibilidad = 500},
			new Frutos(){FrutoId=4, Nombre="Ciruelas",  Disponibilidad = 700},
			new Frutos(){FrutoId=5,  Nombre="Arandanos", Disponibilidad = 100},
		});
	}
}


